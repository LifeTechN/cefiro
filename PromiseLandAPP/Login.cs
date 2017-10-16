using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using System.Security.Cryptography;
using WordpressHash;




namespace PromiseLandAPP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(@"server=omni.websitewelcome.com;user id=promiselandinsur;password=Atato1973;database=promisel_wrdp1");
            MySql.Data.MySqlClient.MySqlDataAdapter sda = new MySql.Data.MySqlClient.MySqlDataAdapter("SELECT count(*) FROM cefiro_users where user_login='" + LoginUser.Text + "' and user_pass='" + UserPassword.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainWindow ss = new MainWindow();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Por favor revisa tu Usuario y Contraseña. En caso de no tenerlos, envía un correo a mario@promiselandinsurance.com solicitando el acceso.");
            }
        }

   
    }
}
