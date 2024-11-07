using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Xml;

namespace PictureManager
{
    public partial class FormMain : Form
    {
        public String CurrentUser = "";

        public FormMain()
        {
            InitializeComponent();
        }

        /*---------------------------------------------------------------------*/
        /*                   Functions for working with service                */

        // Add file to database
        private void PictureAdd(String FileName)
        {
            FileStream ImageFile = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            BinaryReader Reader = new BinaryReader(ImageFile);

            byte[] Picture = Reader.ReadBytes((int)ImageFile.Length);

            ImageFile.Close();
            Reader.Close();

            Service PictureService = new Service();

            PictureService.PictureAdd(Picture, CurrentUser);
        }

        // Delete file from database
        private void PictureDelete(String ID)
        {
            byte[] ParameterString = Encoding.ASCII.GetBytes("ID=" + ID);

            WebRequest Request = WebRequest.Create("http://localhost:2483/PictureService/Service.asmx/PictureDelete");
            Request.Method = "POST";
            Request.ContentType = "application/x-www-form-urlencoded";
            Request.ContentLength = ParameterString.Length;

            Stream Buffer = Request.GetRequestStream();
            Buffer.Write(ParameterString, 0, ParameterString.Length);
            Buffer.Close();
        }

        private void PictureLoad(String ID)
        {
            byte[] ParameterString = Encoding.ASCII.GetBytes("ID=" + ID);

            WebRequest Request = WebRequest.Create("http://localhost:2483/PictureService/Service.asmx/PictureLoad");
            Request.Method = "POST";
            Request.ContentType = "application/x-www-form-urlencoded";
            Request.ContentLength = ParameterString.Length;

            Stream Buffer = Request.GetRequestStream();
            Buffer.Write(ParameterString, 0, ParameterString.Length);
            Buffer.Close();

            WebResponse Response = Request.GetResponse();
            StreamReader Reader = new StreamReader(Response.GetResponseStream());

            String ResponseData = Reader.ReadToEnd();

            XmlDocument Document = new XmlDocument();
            Document.LoadXml(ResponseData);

            XmlNodeList nodes = Document.GetElementsByTagName("base64Binary");

            foreach (XmlElement xel in nodes)
            {
                MemoryStream ImageStream = new MemoryStream();
                byte[] ImageBytes = Convert.FromBase64String(xel.InnerXml);

                ImageStream.Write(ImageBytes, 0, ImageBytes.Length);
                PictureSelected.Image = Image.FromStream(ImageStream);

            }
        }

        private String CommentLoad(String ID)
        {
            byte[] ParameterString = Encoding.ASCII.GetBytes("ID=" + ID);

            WebRequest Request = WebRequest.Create("http://localhost:2483/PictureService/Service.asmx/CommentLoad");
            Request.Method = "POST";
            Request.ContentType = "application/x-www-form-urlencoded";
            Request.ContentLength = ParameterString.Length;

            Stream Buffer = Request.GetRequestStream();
            Buffer.Write(ParameterString, 0, ParameterString.Length);
            Buffer.Close();

            WebResponse Response = Request.GetResponse();
            StreamReader Reader = new StreamReader(Response.GetResponseStream());

            String ResponseData = Reader.ReadToEnd();

            XmlDocument Document = new XmlDocument();
            Document.LoadXml(ResponseData);

            XmlNodeList nodes = Document.GetElementsByTagName("string");

            return nodes[0].InnerXml;
        }

        // Filling file list
        public void FillTable()
        {
            ListDatabase.Items.Clear();

            byte[] ParameterString = Encoding.ASCII.GetBytes("UserID=" + CurrentUser);

            WebRequest Request = WebRequest.Create("http://localhost:2483/PictureService/Service.asmx/PictureList");
            Request.Method = "POST";
            Request.ContentType = "application/x-www-form-urlencoded";
            Request.ContentLength = ParameterString.Length;

            Stream Buffer = Request.GetRequestStream();
            Buffer.Write(ParameterString, 0, ParameterString.Length);
            Buffer.Close();

            WebResponse Response = Request.GetResponse();
            StreamReader Reader = new StreamReader(Response.GetResponseStream());
            String ResponseData = Reader.ReadToEnd();

            XmlDocument Document = new XmlDocument();
            Document.LoadXml(ResponseData);

            XmlNodeList Nodes = Document.GetElementsByTagName("guid");
            foreach (XmlElement Element in Nodes)
            {
                ListViewItem Item = new ListViewItem();
                Item.SubItems.Add(new ListViewItem.ListViewSubItem(Item, Element.InnerXml));
                Item.SubItems.Add(new ListViewItem.ListViewSubItem(Item, CommentLoad(Element.InnerXml)));
                Item.ImageIndex = 0;
                ListDatabase.Items.Add(Item);
            }
        }

        // Save comment
        private void CommentSave(String ID, String Comment)
        {
            if (ListDatabase.SelectedItems.Count > 0)
            {
                byte[] ParameterString = Encoding.Default.GetBytes("ID=" + ID + "&Comment=" + Comment);

                WebRequest Request = WebRequest.Create("http://localhost:2483/PictureService/Service.asmx/CommentSave");
                Request.Method = "POST";
                Request.ContentType = "application/x-www-form-urlencoded";
                Request.ContentLength = ParameterString.Length;

                Stream Buffer = Request.GetRequestStream();
                Buffer.Write(ParameterString, 0, ParameterString.Length);
                Buffer.Close();
            }
        }

        // Shows actual information in status bar
        public void CheckStatus()
        {
            if (CurrentUser== "")
                ToolStatus.Text = "Текущий пользователь: не выбран";
            else
                ToolStatus.Text = "Текущий пользователь: " + UserLoad(CurrentUser);
        }

        private String UserLoad(String ID)
        {
            byte[] ParameterString = Encoding.ASCII.GetBytes("ID=" + ID);

            WebRequest Request = WebRequest.Create("http://localhost:2483/PictureService/Service.asmx/UserLoad");
            Request.Method = "POST";
            Request.ContentType = "application/x-www-form-urlencoded";
            Request.ContentLength = ParameterString.Length;

            Stream Buffer = Request.GetRequestStream();
            Buffer.Write(ParameterString, 0, ParameterString.Length);
            Buffer.Close();

            WebResponse Response = Request.GetResponse();
            StreamReader Reader = new StreamReader(Response.GetResponseStream());

            String ResponseData = Reader.ReadToEnd();

            XmlDocument Document = new XmlDocument();
            Document.LoadXml(ResponseData);

            XmlNodeList nodes = Document.GetElementsByTagName("string");

            return nodes[0].InnerXml;
        }



        /*---------------------------------------------------------------------*/
        /*                             Event handlers                          */

        // Add selected file to database
        private void ToolAddToDatabase_Click(object sender, EventArgs e)
        {
            if (CurrentUser == "") return;

            if (ListFiles.SelectedItems.Count > 0)
            {
                PictureAdd(FolderBrowser.SelectedPath + "\\" + ListFiles.SelectedItems[0].Text);
                FillTable();
            }
        }

        // Add all files in list to database
        private void ToolAddAll_Click(object sender, EventArgs e)
        {
            if (CurrentUser == "") return;
            
            if (ListFiles.Items.Count > 0)
            {
                foreach (ListViewItem Item in ListFiles.Items)
                {
                    PictureAdd(FolderBrowser.SelectedPath + "\\" + Item.Text);
                }
                FillTable();
            }
        }

        // Delete from database
        private void ToolDeleteFromDatabase_Click(object sender, EventArgs e)
        {
            if (CurrentUser == "") return;
            
            if (ListDatabase.SelectedItems.Count > 0)
            {
                PictureDelete(ListDatabase.SelectedItems[0].SubItems[1].Text);
                FillTable();
                PictureSelected.Image = null;
            }
        }

        // Select folder
        private void ToolSelectFolder_Click(object sender, EventArgs e)
        {
            if (CurrentUser == "") return;

            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                ListFiles.Clear();

                DirectoryInfo Info = new DirectoryInfo(FolderBrowser.SelectedPath);
                FileInfo[] Files;

                Files = Info.GetFiles();

                foreach (FileInfo File in Files)
                {
                    if (File.Extension == ".jpg")
                    {
                        ListViewItem Item = new ListViewItem();
                        Item.Text = File.ToString();
                        Item.ImageIndex = 0;
                        ListFiles.Items.Add(Item);
                    }
                }
            }
        }

        // Exit
        private void ToolExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Select file in file list
        private void ListFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListFiles.SelectedItems.Count > 0)
                PictureSelected.Load(FolderBrowser.SelectedPath + "\\" + ListFiles.SelectedItems[0].Text);
            else
                PictureSelected.Image = null;
        }
        
        // Select file in database list
        private void ListDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListDatabase.SelectedItems.Count > 0)
            {
                PictureLoad(ListDatabase.SelectedItems[0].SubItems[1].Text);
                TextComment.Text = CommentLoad(ListDatabase.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                PictureSelected.Image = null;
                TextComment.Clear();
            }
        }

        // Save comment button
        private void ButtonSaveComment_Click(object sender, EventArgs e)
        {
            if (CurrentUser == "") return;
            
            if (ListDatabase.SelectedItems.Count > 0)
            {
                CommentSave(ListDatabase.SelectedItems[0].SubItems[1].Text, TextComment.Text);
                FillTable();
            }
        }

        // Delete comment button
        private void ButtonDeleteComment_Click(object sender, EventArgs e)
        {
            if (CurrentUser == "") return;
            
            TextComment.Clear();
            CommentSave(ListDatabase.SelectedItems[0].SubItems[1].Text, TextComment.Text);
        }

        private void ToolLogin_Click(object sender, EventArgs e)
        {
            FormLogin LoginForm = new FormLogin(this);
            LoginForm.Show();
        }
    }
}