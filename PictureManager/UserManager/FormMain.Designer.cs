namespace UserManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PictureLogin = new System.Windows.Forms.PictureBox();
            this.GroupUsers = new System.Windows.Forms.GroupBox();
            this.TreeUsers = new System.Windows.Forms.TreeView();
            this.GroupAdd = new System.Windows.Forms.GroupBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ImageListMain = new System.Windows.Forms.ImageList(this.components);
            this.PictureUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).BeginInit();
            this.GroupUsers.SuspendLayout();
            this.GroupAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureLogin
            // 
            this.PictureLogin.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogin.Image")));
            this.PictureLogin.Location = new System.Drawing.Point(0, 0);
            this.PictureLogin.Name = "PictureLogin";
            this.PictureLogin.Size = new System.Drawing.Size(320, 60);
            this.PictureLogin.TabIndex = 7;
            this.PictureLogin.TabStop = false;
            // 
            // GroupUsers
            // 
            this.GroupUsers.Controls.Add(this.TreeUsers);
            this.GroupUsers.Location = new System.Drawing.Point(6, 66);
            this.GroupUsers.Name = "GroupUsers";
            this.GroupUsers.Size = new System.Drawing.Size(150, 215);
            this.GroupUsers.TabIndex = 8;
            this.GroupUsers.TabStop = false;
            this.GroupUsers.Text = "Пользователи";
            // 
            // TreeUsers
            // 
            this.TreeUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeUsers.ImageIndex = 0;
            this.TreeUsers.ImageList = this.ImageListMain;
            this.TreeUsers.Location = new System.Drawing.Point(3, 16);
            this.TreeUsers.Name = "TreeUsers";
            this.TreeUsers.SelectedImageIndex = 0;
            this.TreeUsers.ShowRootLines = false;
            this.TreeUsers.Size = new System.Drawing.Size(144, 196);
            this.TreeUsers.TabIndex = 0;
            this.TreeUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TreeUsers_KeyDown);
            // 
            // GroupAdd
            // 
            this.GroupAdd.Controls.Add(this.ButtonAdd);
            this.GroupAdd.Controls.Add(this.TextLogin);
            this.GroupAdd.Controls.Add(this.TextPassword);
            this.GroupAdd.Controls.Add(this.LabelLogin);
            this.GroupAdd.Controls.Add(this.LabelPassword);
            this.GroupAdd.Location = new System.Drawing.Point(162, 66);
            this.GroupAdd.Name = "GroupAdd";
            this.GroupAdd.Size = new System.Drawing.Size(144, 135);
            this.GroupAdd.TabIndex = 9;
            this.GroupAdd.TabStop = false;
            this.GroupAdd.Text = "Добавить";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.ForeColor = System.Drawing.Color.DimGray;
            this.LabelLogin.Location = new System.Drawing.Point(6, 19);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(106, 13);
            this.LabelLogin.TabIndex = 4;
            this.LabelLogin.Text = "Имя пользователя:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.ForeColor = System.Drawing.Color.DimGray;
            this.LabelPassword.Location = new System.Drawing.Point(6, 58);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(48, 13);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "Пароль:";
            // 
            // TextLogin
            // 
            this.TextLogin.Location = new System.Drawing.Point(9, 35);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(129, 20);
            this.TextLogin.TabIndex = 6;
            this.TextLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextLogin_KeyDown);
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(9, 74);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(129, 20);
            this.TextPassword.TabIndex = 7;
            this.TextPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextLogin_KeyDown);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(9, 100);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 8;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(171, 207);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 10;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ImageListMain
            // 
            this.ImageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListMain.ImageStream")));
            this.ImageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListMain.Images.SetKeyName(0, "user-16x16.png");
            // 
            // PictureUser
            // 
            this.PictureUser.Image = ((System.Drawing.Image)(resources.GetObject("PictureUser.Image")));
            this.PictureUser.Location = new System.Drawing.Point(252, 226);
            this.PictureUser.Name = "PictureUser";
            this.PictureUser.Size = new System.Drawing.Size(64, 64);
            this.PictureUser.TabIndex = 11;
            this.PictureUser.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 293);
            this.Controls.Add(this.PictureUser);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.GroupAdd);
            this.Controls.Add(this.GroupUsers);
            this.Controls.Add(this.PictureLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер пользователей";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).EndInit();
            this.GroupUsers.ResumeLayout(false);
            this.GroupAdd.ResumeLayout(false);
            this.GroupAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureLogin;
        private System.Windows.Forms.GroupBox GroupUsers;
        private System.Windows.Forms.TreeView TreeUsers;
        private System.Windows.Forms.GroupBox GroupAdd;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox TextLogin;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.ImageList ImageListMain;
        private System.Windows.Forms.PictureBox PictureUser;
    }
}

