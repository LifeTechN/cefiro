using EO.WebBrowser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromiseLandAPP
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Aplicar ss = new Aplicar();
            ss.Show();
        }

        private void LabelSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ss = new Login();
            ss.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Cotizar ss = new Cotizar();
            ss.Show();
        }

        private void ACA_Click(object sender, EventArgs e)
        {
            this.Close();
            PortalACA ss = new PortalACA();
            ss.Show();
        }

        private void Herramientas_Click(object sender, EventArgs e)
        {
            this.Close();
            Herramientas ss = new Herramientas();
            ss.Show();
        }
    }
}
