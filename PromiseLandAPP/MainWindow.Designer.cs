namespace PromiseLandAPP
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ForestersWebView = new EO.WebBrowser.WebView();
            this.LabelAplicar = new System.Windows.Forms.Label();
            this.LabelCotizar = new System.Windows.Forms.Label();
            this.LabelHerramientas = new System.Windows.Forms.Label();
            this.LabelSalir = new System.Windows.Forms.Label();
            this.LabelACA = new System.Windows.Forms.Label();
            this.ACA = new System.Windows.Forms.PictureBox();
            this.Herramientas = new System.Windows.Forms.PictureBox();
            this.Cotizar = new System.Windows.Forms.PictureBox();
            this.Aplicar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ACA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Herramientas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cotizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aplicar)).BeginInit();
            this.SuspendLayout();
            // 
            // ForestersWebView
            // 
            this.ForestersWebView.ObjectForScripting = null;
            this.ForestersWebView.Url = "https://portal.foresters.biz";
            // 
            // LabelAplicar
            // 
            this.LabelAplicar.AutoSize = true;
            this.LabelAplicar.Font = new System.Drawing.Font("Walkway Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAplicar.ForeColor = System.Drawing.Color.White;
            this.LabelAplicar.Location = new System.Drawing.Point(467, 429);
            this.LabelAplicar.Name = "LabelAplicar";
            this.LabelAplicar.Size = new System.Drawing.Size(161, 51);
            this.LabelAplicar.TabIndex = 3;
            this.LabelAplicar.Text = "Aplicar";
            // 
            // LabelCotizar
            // 
            this.LabelCotizar.AutoSize = true;
            this.LabelCotizar.Font = new System.Drawing.Font("Walkway Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCotizar.ForeColor = System.Drawing.Color.White;
            this.LabelCotizar.Location = new System.Drawing.Point(818, 429);
            this.LabelCotizar.Name = "LabelCotizar";
            this.LabelCotizar.Size = new System.Drawing.Size(168, 51);
            this.LabelCotizar.TabIndex = 4;
            this.LabelCotizar.Text = "Cotizar";
            // 
            // LabelHerramientas
            // 
            this.LabelHerramientas.AutoSize = true;
            this.LabelHerramientas.Font = new System.Drawing.Font("Walkway Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHerramientas.ForeColor = System.Drawing.Color.White;
            this.LabelHerramientas.Location = new System.Drawing.Point(1115, 429);
            this.LabelHerramientas.Name = "LabelHerramientas";
            this.LabelHerramientas.Size = new System.Drawing.Size(296, 51);
            this.LabelHerramientas.TabIndex = 5;
            this.LabelHerramientas.Text = "Herramientas";
            // 
            // LabelSalir
            // 
            this.LabelSalir.AutoSize = true;
            this.LabelSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSalir.Font = new System.Drawing.Font("Walkway Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSalir.ForeColor = System.Drawing.Color.White;
            this.LabelSalir.Location = new System.Drawing.Point(1284, 18);
            this.LabelSalir.Name = "LabelSalir";
            this.LabelSalir.Size = new System.Drawing.Size(144, 67);
            this.LabelSalir.TabIndex = 6;
            this.LabelSalir.Text = "Salir";
            this.LabelSalir.Click += new System.EventHandler(this.LabelSalir_Click);
            // 
            // LabelACA
            // 
            this.LabelACA.AutoSize = true;
            this.LabelACA.Font = new System.Drawing.Font("Walkway Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelACA.ForeColor = System.Drawing.Color.White;
            this.LabelACA.Location = new System.Drawing.Point(55, 429);
            this.LabelACA.Name = "LabelACA";
            this.LabelACA.Size = new System.Drawing.Size(254, 51);
            this.LabelACA.TabIndex = 8;
            this.LabelACA.Text = "Portal ACA";
            // 
            // ACA
            // 
            this.ACA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ACA.Image = global::PromiseLandAPP.Properties.Resources.AcaAdvisor;
            this.ACA.Location = new System.Drawing.Point(12, 100);
            this.ACA.Name = "ACA";
            this.ACA.Size = new System.Drawing.Size(353, 311);
            this.ACA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ACA.TabIndex = 7;
            this.ACA.TabStop = false;
            this.ACA.Click += new System.EventHandler(this.ACA_Click);
            // 
            // Herramientas
            // 
            this.Herramientas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Herramientas.Image = global::PromiseLandAPP.Properties.Resources.Wunderlist;
            this.Herramientas.Location = new System.Drawing.Point(1082, 100);
            this.Herramientas.Name = "Herramientas";
            this.Herramientas.Size = new System.Drawing.Size(346, 311);
            this.Herramientas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Herramientas.TabIndex = 2;
            this.Herramientas.TabStop = false;
            this.Herramientas.Click += new System.EventHandler(this.Herramientas_Click);
            // 
            // Cotizar
            // 
            this.Cotizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cotizar.Image = global::PromiseLandAPP.Properties.Resources.Cotizar;
            this.Cotizar.Location = new System.Drawing.Point(730, 100);
            this.Cotizar.Name = "Cotizar";
            this.Cotizar.Size = new System.Drawing.Size(346, 311);
            this.Cotizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cotizar.TabIndex = 1;
            this.Cotizar.TabStop = false;
            this.Cotizar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Aplicar
            // 
            this.Aplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aplicar.Image = global::PromiseLandAPP.Properties.Resources.Apple_Computer_PNG_File;
            this.Aplicar.Location = new System.Drawing.Point(371, 100);
            this.Aplicar.Name = "Aplicar";
            this.Aplicar.Size = new System.Drawing.Size(353, 311);
            this.Aplicar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Aplicar.TabIndex = 0;
            this.Aplicar.TabStop = false;
            this.Aplicar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1441, 522);
            this.Controls.Add(this.LabelACA);
            this.Controls.Add(this.ACA);
            this.Controls.Add(this.LabelSalir);
            this.Controls.Add(this.LabelHerramientas);
            this.Controls.Add(this.LabelCotizar);
            this.Controls.Add(this.LabelAplicar);
            this.Controls.Add(this.Herramientas);
            this.Controls.Add(this.Cotizar);
            this.Controls.Add(this.Aplicar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Céfiro Menú";
            ((System.ComponentModel.ISupportInitialize)(this.ACA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Herramientas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cotizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aplicar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EO.WebBrowser.WebView ForestersWebView;
        private System.Windows.Forms.PictureBox Aplicar;
        private System.Windows.Forms.PictureBox Cotizar;
        private System.Windows.Forms.PictureBox Herramientas;
        private System.Windows.Forms.Label LabelAplicar;
        private System.Windows.Forms.Label LabelCotizar;
        private System.Windows.Forms.Label LabelHerramientas;
        private System.Windows.Forms.Label LabelSalir;
        private System.Windows.Forms.PictureBox ACA;
        private System.Windows.Forms.Label LabelACA;
    }
}

