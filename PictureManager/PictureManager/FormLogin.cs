using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;

namespace PictureManager
{
    public partial class FormLogin : Form
    {
        FormMain FormParent;

        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(FormMain FormParent)
        {
            InitializeComponent();
            this.FormParent = FormParent;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                ButtonLogin_Click(this, null);
            if (e.KeyData == Keys.Escape)
                Close();

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if ((TextLogin.Text.Trim() != "") && (TextPassword.Text.Trim() != ""))
            {

                byte[] ParameterString = Encoding.ASCII.GetBytes("Login=" + TextLogin.Text + "&Password=" + TextPassword.Text);

                WebRequest Request = WebRequest.Create("http://localhost:2483/PictureService/Service.asmx/UserCheck");
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

                String S = nodes[0].InnerXml;
                if (S != "")
                {
                    FormParent.CurrentUser = S;
                    FormParent.FillTable();
                    FormParent.CheckStatus();
                    Close();
                }
                else
                    MessageBox.Show("Пользователь не найден", "Вход в систему", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}