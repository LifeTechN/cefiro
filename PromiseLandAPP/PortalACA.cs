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
    public partial class PortalACA : Form
    {
        public PortalACA()
        {
            InitializeComponent();
        }

        private void PortalACA_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow ss = new MainWindow();
            ss.Show();
        }

        private void PortalACAView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            PortalACAView.Url = e.TargetUrl;
        }
    }
}
