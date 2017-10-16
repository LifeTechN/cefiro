namespace PromiseLandAPP
{
    partial class Aplicar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplicar));
            this.PromisePortal = new EO.WinForm.WebControl();
            this.PromiseView = new EO.WebBrowser.WebView();
            this.SuspendLayout();
            // 
            // PromisePortal
            // 
            this.PromisePortal.BackColor = System.Drawing.Color.White;
            this.PromisePortal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PromisePortal.Location = new System.Drawing.Point(0, 0);
            this.PromisePortal.Name = "PromisePortal";
            this.PromisePortal.Size = new System.Drawing.Size(1429, 620);
            this.PromisePortal.TabIndex = 0;
            this.PromisePortal.Text = "webControl1";
            this.PromisePortal.WebView = this.PromiseView;
            // 
            // PromiseView
            // 
            this.PromiseView.ObjectForScripting = null;
            this.PromiseView.Url = "http://promiselandinsurance.com/application";
            // 
            // Aplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 620);
            this.Controls.Add(this.PromisePortal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aplicar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cefiro - Aplicar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Aplicar_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WinForm.WebControl PromisePortal;
        private EO.WebBrowser.WebView PromiseView;
    }
}