namespace PromiseLandAPP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginUser = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelUser = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginUser
            // 
            resources.ApplyResources(this.LoginUser, "LoginUser");
            this.LoginUser.Name = "LoginUser";
            // 
            // UserPassword
            // 
            resources.ApplyResources(this.UserPassword, "UserPassword");
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PromiseLandAPP.Properties.Resources.bg_contact_center;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // LabelUser
            // 
            resources.ApplyResources(this.LabelUser, "LabelUser");
            this.LabelUser.ForeColor = System.Drawing.Color.White;
            this.LabelUser.Name = "LabelUser";
            // 
            // LabelPassword
            // 
            resources.ApplyResources(this.LabelPassword, "LabelPassword");
            this.LabelPassword.ForeColor = System.Drawing.Color.White;
            this.LabelPassword.Name = "LabelPassword";
            // 
            // LabelLogin
            // 
            resources.ApplyResources(this.LabelLogin, "LabelLogin");
            this.LabelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LabelExit
            // 
            resources.ApplyResources(this.LabelExit, "LabelExit");
            this.LabelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelExit.ForeColor = System.Drawing.Color.White;
            this.LabelExit.Name = "LabelExit";
            this.LabelExit.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelExit);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.LoginUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Enter += new System.EventHandler(this.LoginButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginUser;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelExit;
        private System.Windows.Forms.Label label1;
    }
}