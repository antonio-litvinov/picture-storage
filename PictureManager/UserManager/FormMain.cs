using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;

namespace UserManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // Add file to database
        private void UserAdd(String Login, String Password)
        {
            byte[] ParameterString = Encoding.ASCII.GetBytes("Login=" + Login + "&Password=" + Password);

            WebRequest Request = WebRequest.Create("http://localhost:2483/PictureService/Service.asmx/UserAdd");
            Request.Method = "POST";
            Request.ContentType = "application/x-www-form-urlencoded";
            Request.ContentLength = ParameterString.Length;

            Stream Buffer = Request.GetRequestStream();
            Buffer.Write(ParameterString, 0, ParameterString.Length);
            Buffer.Close();
        }

        // Delete file from database
        private void UserDelete(String ID)
        {
            byte[] ParameterString = Encoding.ASCII.GetBytes("ID=" + ID);

            WebRequest Request = WebRequest.Create("http://localhost:2483/PictureService/Service.asmx/UserDelete");
            Request.Method = "POST";
            Request.ContentType = "application/x-www-form-urlencoded";
            Request.ContentLength = ParameterString.Length;

            Stream Buffer = Request.GetRequestStream();
            Buffer.Write(ParameterString, 0, ParameterString.Length);
            Buffer.Close();
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

        // Filling file list
        private void FillUsers()
        {
            TreeUsers.Nodes.Clear();

            WebRequest Request = WebRequest.Create("http://localhost:2483/PictureService/Service.asmx/UserList");
            Request.Method = "POST";
            Request.ContentType = "application/x-www-form-urlencoded";

            WebResponse Response = Request.GetResponse();
            StreamReader Reader = new StreamReader(Response.GetResponseStream());
            String ResponseData = Reader.ReadToEnd();

            XmlDocument Document = new XmlDocument();
            Document.LoadXml(ResponseData);

            XmlNodeList Nodes = Document.GetElementsByTagName("guid");
            foreach (XmlElement Element in Nodes)
            {
                TreeNode Node = new TreeNode();
                Node.Tag = Element.InnerXml;
                Node.Text = UserLoad(Element.InnerXml);
                TreeUsers.Nodes.Add(Node);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if ((TextLogin.Text.Trim() != "") && (TextPassword.Text.Trim() != ""))
            {
                UserAdd(TextLogin.Text, TextPassword.Text);
                FillUsers();

                TextPassword.Clear();
                TextLogin.Clear();
                TextLogin.Focus();
            }
            else
                MessageBox.Show("Заполните все поля", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FillUsers();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if ((TreeUsers.Nodes.Count > 0) && (TreeUsers.SelectedNode != null))
            {
                if (MessageBox.Show("Вы уверены?", "Удалить пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UserDelete(TreeUsers.SelectedNode.Tag.ToString());
                    FillUsers();
                }
            }
        }

        private void TextLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                ButtonAdd_Click(this, null);
        }

        private void TreeUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
                ButtonDelete_Click(this, null);
        }
    }
}