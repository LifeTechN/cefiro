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
    public partial class Herramientas : Form
    {
        public Herramientas()
        {
            InitializeComponent();
        }

        private void CorreoView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            CorreoView.Url = e.TargetUrl;
        }

        private void WunderlistView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            WunderlistView.Url = e.TargetUrl;
        }

        private void Herramientas_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow ss = new MainWindow();
            ss.Show();
        }

        private void HangoutsView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            HangoutsView.Url = e.TargetUrl;
        }

        private void HangoutsView_RequestPermissions(object sender, EO.WebBrowser.RequestPermissionEventArgs e) => e.Allow();

        private void CorreoView_RequestPermissions(object sender, EO.WebBrowser.RequestPermissionEventArgs e) => e.Allow();

        private void WunderlistView_RequestPermissions(object sender, EO.WebBrowser.RequestPermissionEventArgs e) => e.Allow();

        private void ExcelView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            ExcelView.Url = e.TargetUrl;
        }

        private void ExcelView_RequestPermissions(object sender, EO.WebBrowser.RequestPermissionEventArgs e) => e.Allow();

        private void CalendarView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            CalendarView.Url = e.TargetUrl;
        }

        private void CalendarView_RequestPermissions(object sender, EO.WebBrowser.RequestPermissionEventArgs e) => e.Allow();

        private void DriveView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            DriveView.Url = e.TargetUrl;
        }

        private void DriveView_RequestPermissions(object sender, EO.WebBrowser.RequestPermissionEventArgs e) => e.Allow();

        private void MapsView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            MapsView.Url = e.TargetUrl;
        }

        private void MapsView_RequestPermissions(object sender, EO.WebBrowser.RequestPermissionEventArgs e) => e.Allow();

        private void ZipCodeView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            ZipCodeView.Url = e.TargetUrl;
        }

        private void ZipCodeView_RequestPermissions(object sender, EO.WebBrowser.RequestPermissionEventArgs e) => e.Allow();

        private void RutasView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            RutasView.Url = e.TargetUrl;
        }

        private void RutasView_RequestPermissions(object sender, EO.WebBrowser.RequestPermissionEventArgs e) => e.Allow();

        private void GoogleView_NewWindow(object sender, EO.WebBrowser.NewWindowEventArgs e)
        {
            GoogleView.Url = e.TargetUrl;
        }

        private void GoogleView_RequestPermissions(object sender, EO.WebBrowser.RequestPermissionEventArgs e) => e.Allow();
 
    }
}
