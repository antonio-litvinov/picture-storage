namespace PictureManager
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.PictureLogin = new System.Windows.Forms.PictureBox();
            this.LabelCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // TextLogin
            // 
            this.TextLogin.Location = new System.Drawing.Point(115, 95);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(200, 20);
            this.TextLogin.TabIndex = 0;
            this.TextLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextLogin_KeyDown);
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(115, 121);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(200, 20);
            this.TextPassword.TabIndex = 1;
            this.TextPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextLogin_KeyDown);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.ForeColor = System.Drawing.Color.DimGray;
            this.LabelLogin.Location = new System.Drawing.Point(6, 98);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(106, 13);
            this.LabelLogin.TabIndex = 2;
            this.LabelLogin.Text = "Имя пользователя:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.ForeColor = System.Drawing.Color.DimGray;
            this.LabelPassword.Location = new System.Drawing.Point(6, 124);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(48, 13);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Пароль:";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(159, 147);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Войти";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(240, 147);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // PictureLogin
            // 
            this.PictureLogin.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogin.Image")));
            this.PictureLogin.Location = new System.Drawing.Point(0, 0);
            this.PictureLogin.Name = "PictureLogin";
            this.PictureLogin.Size = new System.Drawing.Size(320, 60);
            this.PictureLogin.TabIndex = 6;
            this.PictureLogin.TabStop = false;
            // 
            // LabelCaption
            // 
            this.LabelCaption.AutoSize = true;
            this.LabelCaption.ForeColor = System.Drawing.Color.DimGray;
            this.LabelCaption.Location = new System.Drawing.Point(6, 66);
            this.LabelCaption.Name = "LabelCaption";
            this.LabelCaption.Size = new System.Drawing.Size(216, 13);
            this.LabelCaption.TabIndex = 7;
            this.LabelCaption.Text = "Введите Ваши регистрационные данные:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 176);
            this.Controls.Add(this.PictureLogin);
            this.Controls.Add(this.LabelCaption);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextLogin);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.ButtonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextLogin;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.PictureBox PictureLogin;
        private System.Windows.Forms.Label LabelCaption;
    }
}