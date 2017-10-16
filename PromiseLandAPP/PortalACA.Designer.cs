namespace PromiseLandAPP
{
    partial class PortalACA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortalACA));
            this.PortalACAControl = new EO.WinForm.WebControl();
            this.PortalACAView = new EO.WebBrowser.WebView();
            this.SuspendLayout();
            // 
            // PortalACAControl
            // 
            this.PortalACAControl.BackColor = System.Drawing.Color.White;
            this.PortalACAControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortalACAControl.Location = new System.Drawing.Point(0, 0);
            this.PortalACAControl.Name = "PortalACAControl";
            this.PortalACAControl.Size = new System.Drawing.Size(743, 546);
            this.PortalACAControl.TabIndex = 0;
            this.PortalACAControl.Text = "webControl1";
            this.PortalACAControl.WebView = this.PortalACAView;
            // 
            // PortalACAView
            // 
            this.PortalACAView.ObjectForScripting = null;
            this.PortalACAView.Url = "https://acaadvisor.net";
            this.PortalACAView.NewWindow += new EO.WebBrowser.NewWindowHandler(this.PortalACAView_NewWindow);
            // 
            // PortalACA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 546);
            this.Controls.Add(this.PortalACAControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PortalACA";
            this.Text = "Céfiro - PortalACA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PortalACA_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WinForm.WebControl PortalACAControl;
        private EO.WebBrowser.WebView PortalACAView;
    }
}