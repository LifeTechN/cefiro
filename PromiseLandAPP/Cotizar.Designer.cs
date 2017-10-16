namespace PromiseLandAPP
{
    partial class Cotizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizar));
            this.CotizarContainer = new System.Windows.Forms.TabControl();
            this.Foresters = new System.Windows.Forms.TabPage();
            this.ForestersControl = new EO.WinForm.WebControl();
            this.ForestersView = new EO.WebBrowser.WebView();
            this.Fidelity = new System.Windows.Forms.TabPage();
            this.AIG = new System.Windows.Forms.TabPage();
            this.FidelityControl = new EO.WinForm.WebControl();
            this.FidelityView = new EO.WebBrowser.WebView();
            this.AIGControl = new EO.WinForm.WebControl();
            this.AIGView = new EO.WebBrowser.WebView();
            this.CotizarContainer.SuspendLayout();
            this.Foresters.SuspendLayout();
            this.Fidelity.SuspendLayout();
            this.AIG.SuspendLayout();
            this.SuspendLayout();
            // 
            // CotizarContainer
            // 
            this.CotizarContainer.Controls.Add(this.Foresters);
            this.CotizarContainer.Controls.Add(this.Fidelity);
            this.CotizarContainer.Controls.Add(this.AIG);
            this.CotizarContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CotizarContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CotizarContainer.Location = new System.Drawing.Point(0, 0);
            this.CotizarContainer.Name = "CotizarContainer";
            this.CotizarContainer.SelectedIndex = 0;
            this.CotizarContainer.Size = new System.Drawing.Size(1106, 551);
            this.CotizarContainer.TabIndex = 0;
            // 
            // Foresters
            // 
            this.Foresters.Controls.Add(this.ForestersControl);
            this.Foresters.Location = new System.Drawing.Point(4, 24);
            this.Foresters.Name = "Foresters";
            this.Foresters.Padding = new System.Windows.Forms.Padding(3);
            this.Foresters.Size = new System.Drawing.Size(1098, 523);
            this.Foresters.TabIndex = 0;
            this.Foresters.Text = "Foresters";
            this.Foresters.UseVisualStyleBackColor = true;
            // 
            // ForestersControl
            // 
            this.ForestersControl.BackColor = System.Drawing.Color.White;
            this.ForestersControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForestersControl.Location = new System.Drawing.Point(3, 3);
            this.ForestersControl.Name = "ForestersControl";
            this.ForestersControl.Size = new System.Drawing.Size(1092, 517);
            this.ForestersControl.TabIndex = 0;
            this.ForestersControl.Text = "webControl1";
            this.ForestersControl.WebView = this.ForestersView;
            // 
            // ForestersView
            // 
            this.ForestersView.ObjectForScripting = null;
            this.ForestersView.Url = "https://portal.foresters.biz";
            this.ForestersView.NewWindow += new EO.WebBrowser.NewWindowHandler(this.ForestersView_NewWindow);
            // 
            // Fidelity
            // 
            this.Fidelity.Controls.Add(this.FidelityControl);
            this.Fidelity.Location = new System.Drawing.Point(4, 24);
            this.Fidelity.Name = "Fidelity";
            this.Fidelity.Padding = new System.Windows.Forms.Padding(3);
            this.Fidelity.Size = new System.Drawing.Size(1098, 523);
            this.Fidelity.TabIndex = 1;
            this.Fidelity.Text = "Fidelity";
            this.Fidelity.UseVisualStyleBackColor = true;
            // 
            // AIG
            // 
            this.AIG.Controls.Add(this.AIGControl);
            this.AIG.Location = new System.Drawing.Point(4, 24);
            this.AIG.Name = "AIG";
            this.AIG.Padding = new System.Windows.Forms.Padding(3);
            this.AIG.Size = new System.Drawing.Size(1098, 523);
            this.AIG.TabIndex = 2;
            this.AIG.Text = "AIG";
            this.AIG.UseVisualStyleBackColor = true;
            // 
            // FidelityControl
            // 
            this.FidelityControl.BackColor = System.Drawing.Color.White;
            this.FidelityControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FidelityControl.Location = new System.Drawing.Point(3, 3);
            this.FidelityControl.Name = "FidelityControl";
            this.FidelityControl.Size = new System.Drawing.Size(1092, 517);
            this.FidelityControl.TabIndex = 0;
            this.FidelityControl.Text = "webControl1";
            this.FidelityControl.WebView = this.FidelityView;
            // 
            // FidelityView
            // 
            this.FidelityView.ObjectForScripting = null;
            this.FidelityView.Url = "https://www.fglife.com/Logon/passport_logon.asp";
            this.FidelityView.NewWindow += new EO.WebBrowser.NewWindowHandler(this.FidelityView_NewWindow);
            // 
            // AIGControl
            // 
            this.AIGControl.BackColor = System.Drawing.Color.White;
            this.AIGControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AIGControl.Location = new System.Drawing.Point(3, 3);
            this.AIGControl.Name = "AIGControl";
            this.AIGControl.Size = new System.Drawing.Size(1092, 517);
            this.AIGControl.TabIndex = 0;
            this.AIGControl.Text = "webControl1";
            this.AIGControl.WebView = this.AIGView;
            // 
            // AIGView
            // 
            this.AIGView.ObjectForScripting = null;
            this.AIGView.Url = "https://estationsecure.americangeneral.com/Login/Login.aspx?returnurl=%2fProducer" +
    "%2fMarketing%2fIllustrationsQuotes%2fAGLACalculators";
            this.AIGView.NewWindow += new EO.WebBrowser.NewWindowHandler(this.AIGView_NewWindow);
            // 
            // Cotizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 551);
            this.Controls.Add(this.CotizarContainer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Walkway Black", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cotizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Céfiro - Cotizar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cotizar_FormClosed);
            this.CotizarContainer.ResumeLayout(false);
            this.Foresters.ResumeLayout(false);
            this.Fidelity.ResumeLayout(false);
            this.AIG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CotizarContainer;
        private System.Windows.Forms.TabPage Foresters;
        private EO.WinForm.WebControl ForestersControl;
        private EO.WebBrowser.WebView ForestersView;
        private System.Windows.Forms.TabPage Fidelity;
        private System.Windows.Forms.TabPage AIG;
        private EO.WinForm.WebControl FidelityControl;
        private EO.WebBrowser.WebView FidelityView;
        private EO.WinForm.WebControl AIGControl;
        private EO.WebBrowser.WebView AIGView;
    }
}