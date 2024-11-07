namespace PictureManager
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
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.ImageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.Status = new System.Windows.Forms.StatusStrip();
            this.ToolStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.ToolSelectFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupImages = new System.Windows.Forms.GroupBox();
            this.PanelView = new System.Windows.Forms.Panel();
            this.PictureSelected = new System.Windows.Forms.PictureBox();
            this.ListFiles = new System.Windows.Forms.ListView();
            this.GroupDatabase = new System.Windows.Forms.GroupBox();
            this.LabelComment = new System.Windows.Forms.Label();
            this.ButtonDeleteComment = new System.Windows.Forms.Button();
            this.ButtonSaveComment = new System.Windows.Forms.Button();
            this.TextComment = new System.Windows.Forms.TextBox();
            this.ListDatabase = new System.Windows.Forms.ListView();
            this.ColumnImage = new System.Windows.Forms.ColumnHeader();
            this.ColumnGuid = new System.Windows.Forms.ColumnHeader();
            this.ColumnComment = new System.Windows.Forms.ColumnHeader();
            this.ImageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.MenuImages = new System.Windows.Forms.MenuStrip();
            this.ToolAddToDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolDeleteFromDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAddAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Splitter = new System.Windows.Forms.Splitter();
            this.Status.SuspendLayout();
            this.MenuMain.SuspendLayout();
            this.GroupImages.SuspendLayout();
            this.PanelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSelected)).BeginInit();
            this.GroupDatabase.SuspendLayout();
            this.MenuImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.Description = "Выберите папку с изображениями";
            // 
            // ImageListLarge
            // 
            this.ImageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListLarge.ImageStream")));
            this.ImageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListLarge.Images.SetKeyName(0, "Pictures-32x32.png");
            this.ImageListLarge.Images.SetKeyName(1, "Pictures-16x16.png");
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStatus});
            this.Status.Location = new System.Drawing.Point(0, 411);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(603, 22);
            this.Status.TabIndex = 9;
            this.Status.Text = "statusStrip1";
            // 
            // ToolStatus
            // 
            this.ToolStatus.Name = "ToolStatus";
            this.ToolStatus.Size = new System.Drawing.Size(186, 17);
            this.ToolStatus.Text = "Текущий пользователь: не выбран";
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSelectFolder,
            this.ToolLogin,
            this.ToolExit});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(603, 24);
            this.MenuMain.TabIndex = 16;
            this.MenuMain.Text = "menuStrip1";
            // 
            // ToolSelectFolder
            // 
            this.ToolSelectFolder.Image = ((System.Drawing.Image)(resources.GetObject("ToolSelectFolder.Image")));
            this.ToolSelectFolder.Name = "ToolSelectFolder";
            this.ToolSelectFolder.Size = new System.Drawing.Size(112, 20);
            this.ToolSelectFolder.Text = "Выбрать папку";
            this.ToolSelectFolder.Click += new System.EventHandler(this.ToolSelectFolder_Click);
            // 
            // ToolLogin
            // 
            this.ToolLogin.Image = ((System.Drawing.Image)(resources.GetObject("ToolLogin.Image")));
            this.ToolLogin.Name = "ToolLogin";
            this.ToolLogin.Size = new System.Drawing.Size(117, 20);
            this.ToolLogin.Text = "Войти в систему";
            this.ToolLogin.Click += new System.EventHandler(this.ToolLogin_Click);
            // 
            // ToolExit
            // 
            this.ToolExit.Image = ((System.Drawing.Image)(resources.GetObject("ToolExit.Image")));
            this.ToolExit.Name = "ToolExit";
            this.ToolExit.Size = new System.Drawing.Size(68, 20);
            this.ToolExit.Text = "Выход";
            this.ToolExit.Click += new System.EventHandler(this.ToolExit_Click);
            // 
            // GroupImages
            // 
            this.GroupImages.Controls.Add(this.PanelView);
            this.GroupImages.Controls.Add(this.ListFiles);
            this.GroupImages.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupImages.Location = new System.Drawing.Point(0, 24);
            this.GroupImages.Name = "GroupImages";
            this.GroupImages.Size = new System.Drawing.Size(212, 387);
            this.GroupImages.TabIndex = 18;
            this.GroupImages.TabStop = false;
            this.GroupImages.Text = "Изображения";
            // 
            // PanelView
            // 
            this.PanelView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelView.BackgroundImage")));
            this.PanelView.Controls.Add(this.PictureSelected);
            this.PanelView.Location = new System.Drawing.Point(6, 178);
            this.PanelView.Name = "PanelView";
            this.PanelView.Size = new System.Drawing.Size(200, 200);
            this.PanelView.TabIndex = 7;
            // 
            // PictureSelected
            // 
            this.PictureSelected.BackColor = System.Drawing.Color.Transparent;
            this.PictureSelected.Location = new System.Drawing.Point(3, 3);
            this.PictureSelected.Name = "PictureSelected";
            this.PictureSelected.Size = new System.Drawing.Size(194, 194);
            this.PictureSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureSelected.TabIndex = 1;
            this.PictureSelected.TabStop = false;
            // 
            // ListFiles
            // 
            this.ListFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ListFiles.LargeImageList = this.ImageListLarge;
            this.ListFiles.Location = new System.Drawing.Point(6, 19);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(200, 153);
            this.ListFiles.TabIndex = 4;
            this.ListFiles.TileSize = new System.Drawing.Size(168, 34);
            this.ListFiles.UseCompatibleStateImageBehavior = false;
            this.ListFiles.SelectedIndexChanged += new System.EventHandler(this.ListFiles_SelectedIndexChanged);
            // 
            // GroupDatabase
            // 
            this.GroupDatabase.Controls.Add(this.LabelComment);
            this.GroupDatabase.Controls.Add(this.ButtonDeleteComment);
            this.GroupDatabase.Controls.Add(this.ButtonSaveComment);
            this.GroupDatabase.Controls.Add(this.TextComment);
            this.GroupDatabase.Controls.Add(this.ListDatabase);
            this.GroupDatabase.Controls.Add(this.MenuImages);
            this.GroupDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupDatabase.Location = new System.Drawing.Point(215, 24);
            this.GroupDatabase.Name = "GroupDatabase";
            this.GroupDatabase.Size = new System.Drawing.Size(388, 387);
            this.GroupDatabase.TabIndex = 20;
            this.GroupDatabase.TabStop = false;
            this.GroupDatabase.Text = "База данных";
            // 
            // LabelComment
            // 
            this.LabelComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelComment.AutoSize = true;
            this.LabelComment.Location = new System.Drawing.Point(6, 322);
            this.LabelComment.Name = "LabelComment";
            this.LabelComment.Size = new System.Drawing.Size(57, 13);
            this.LabelComment.TabIndex = 19;
            this.LabelComment.Text = "Описание";
            // 
            // ButtonDeleteComment
            // 
            this.ButtonDeleteComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeleteComment.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteComment.Image")));
            this.ButtonDeleteComment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDeleteComment.Location = new System.Drawing.Point(308, 352);
            this.ButtonDeleteComment.Name = "ButtonDeleteComment";
            this.ButtonDeleteComment.Size = new System.Drawing.Size(74, 23);
            this.ButtonDeleteComment.TabIndex = 18;
            this.ButtonDeleteComment.Text = "Удалить";
            this.ButtonDeleteComment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDeleteComment.UseVisualStyleBackColor = true;
            this.ButtonDeleteComment.Click += new System.EventHandler(this.ButtonDeleteComment_Click);
            // 
            // ButtonSaveComment
            // 
            this.ButtonSaveComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveComment.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSaveComment.Image")));
            this.ButtonSaveComment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSaveComment.Location = new System.Drawing.Point(219, 352);
            this.ButtonSaveComment.Name = "ButtonSaveComment";
            this.ButtonSaveComment.Size = new System.Drawing.Size(84, 23);
            this.ButtonSaveComment.TabIndex = 17;
            this.ButtonSaveComment.Text = "Сохранить";
            this.ButtonSaveComment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSaveComment.UseVisualStyleBackColor = true;
            this.ButtonSaveComment.Click += new System.EventHandler(this.ButtonSaveComment_Click);
            // 
            // TextComment
            // 
            this.TextComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextComment.Location = new System.Drawing.Point(9, 338);
            this.TextComment.Multiline = true;
            this.TextComment.Name = "TextComment";
            this.TextComment.Size = new System.Drawing.Size(204, 40);
            this.TextComment.TabIndex = 16;
            // 
            // ListDatabase
            // 
            this.ListDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListDatabase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnImage,
            this.ColumnGuid,
            this.ColumnComment});
            this.ListDatabase.FullRowSelect = true;
            this.ListDatabase.GridLines = true;
            this.ListDatabase.Location = new System.Drawing.Point(6, 43);
            this.ListDatabase.Name = "ListDatabase";
            this.ListDatabase.Size = new System.Drawing.Size(376, 276);
            this.ListDatabase.SmallImageList = this.ImageListSmall;
            this.ListDatabase.TabIndex = 14;
            this.ListDatabase.UseCompatibleStateImageBehavior = false;
            this.ListDatabase.View = System.Windows.Forms.View.Details;
            this.ListDatabase.SelectedIndexChanged += new System.EventHandler(this.ListDatabase_SelectedIndexChanged);
            // 
            // ColumnImage
            // 
            this.ColumnImage.Text = "";
            this.ColumnImage.Width = 25;
            // 
            // ColumnGuid
            // 
            this.ColumnGuid.Text = "Идентификатор";
            this.ColumnGuid.Width = 205;
            // 
            // ColumnComment
            // 
            this.ColumnComment.Text = "Описание";
            this.ColumnComment.Width = 140;
            // 
            // ImageListSmall
            // 
            this.ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            this.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListSmall.Images.SetKeyName(0, "Pictures-16x16.png");
            // 
            // MenuImages
            // 
            this.MenuImages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolAddToDatabase,
            this.ToolDeleteFromDatabase,
            this.ToolAddAll});
            this.MenuImages.Location = new System.Drawing.Point(3, 16);
            this.MenuImages.Name = "MenuImages";
            this.MenuImages.Size = new System.Drawing.Size(382, 24);
            this.MenuImages.TabIndex = 13;
            this.MenuImages.Text = "menuStrip2";
            // 
            // ToolAddToDatabase
            // 
            this.ToolAddToDatabase.Image = ((System.Drawing.Image)(resources.GetObject("ToolAddToDatabase.Image")));
            this.ToolAddToDatabase.Name = "ToolAddToDatabase";
            this.ToolAddToDatabase.Size = new System.Drawing.Size(85, 20);
            this.ToolAddToDatabase.Text = "Добавить";
            this.ToolAddToDatabase.Click += new System.EventHandler(this.ToolAddToDatabase_Click);
            // 
            // ToolDeleteFromDatabase
            // 
            this.ToolDeleteFromDatabase.Image = ((System.Drawing.Image)(resources.GetObject("ToolDeleteFromDatabase.Image")));
            this.ToolDeleteFromDatabase.Name = "ToolDeleteFromDatabase";
            this.ToolDeleteFromDatabase.Size = new System.Drawing.Size(79, 20);
            this.ToolDeleteFromDatabase.Text = "Удалить";
            this.ToolDeleteFromDatabase.Click += new System.EventHandler(this.ToolDeleteFromDatabase_Click);
            // 
            // ToolAddAll
            // 
            this.ToolAddAll.Name = "ToolAddAll";
            this.ToolAddAll.Size = new System.Drawing.Size(89, 20);
            this.ToolAddAll.Text = "Добавить всё";
            this.ToolAddAll.Click += new System.EventHandler(this.ToolAddAll_Click);
            // 
            // Splitter
            // 
            this.Splitter.Enabled = false;
            this.Splitter.Location = new System.Drawing.Point(212, 24);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(3, 387);
            this.Splitter.TabIndex = 13;
            this.Splitter.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 433);
            this.Controls.Add(this.GroupDatabase);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.GroupImages);
            this.Controls.Add(this.MenuMain);
            this.Controls.Add(this.Status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер картинок";
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.GroupImages.ResumeLayout(false);
            this.PanelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureSelected)).EndInit();
            this.GroupDatabase.ResumeLayout(false);
            this.GroupDatabase.PerformLayout();
            this.MenuImages.ResumeLayout(false);
            this.MenuImages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.ImageList ImageListLarge;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem ToolSelectFolder;
        private System.Windows.Forms.ToolStripMenuItem ToolExit;
        private System.Windows.Forms.GroupBox GroupImages;
        private System.Windows.Forms.Panel PanelView;
        private System.Windows.Forms.PictureBox PictureSelected;
        private System.Windows.Forms.ListView ListFiles;
        private System.Windows.Forms.GroupBox GroupDatabase;
        private System.Windows.Forms.MenuStrip MenuImages;
        private System.Windows.Forms.ToolStripMenuItem ToolAddToDatabase;
        private System.Windows.Forms.ToolStripMenuItem ToolDeleteFromDatabase;
        private System.Windows.Forms.ToolStripMenuItem ToolAddAll;
        private System.Windows.Forms.Splitter Splitter;
        private System.Windows.Forms.ToolStripStatusLabel ToolStatus;
        private System.Windows.Forms.ListView ListDatabase;
        private System.Windows.Forms.ColumnHeader ColumnGuid;
        private System.Windows.Forms.ColumnHeader ColumnComment;
        private System.Windows.Forms.ImageList ImageListSmall;
        private System.Windows.Forms.ColumnHeader ColumnImage;
        private System.Windows.Forms.TextBox TextComment;
        private System.Windows.Forms.Button ButtonDeleteComment;
        private System.Windows.Forms.Button ButtonSaveComment;
        private System.Windows.Forms.Label LabelComment;
        private System.Windows.Forms.ToolStripMenuItem ToolLogin;
    }
}

