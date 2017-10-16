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
    public partial class Cotizar : Form
    {
        public Cotizar()
        {
            InitializeComponent();
        }

        private void ForestersView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            ForestersView.Url = e.TargetUrl;
        }

        private void Cotizar_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow ss = new MainWindow();
            ss.Show();
        }

        private void FidelityView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            FidelityView.Url = e.TargetUrl;
        }

        private void AIGView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            AIGView.Url = e.TargetUrl;
        }
    }
}
