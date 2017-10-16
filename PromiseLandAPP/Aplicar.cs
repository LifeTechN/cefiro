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
    public partial class Aplicar : Form
    {
        public Aplicar()
        {
            InitializeComponent();
        }

        private void Aplicar_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow ss = new MainWindow();
            ss.Show();
        }
    }
}
