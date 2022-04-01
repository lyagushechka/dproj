using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }


        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonvxod_Click(object sender, EventArgs e)
        {
            String loginuser = tblogin.Text;
            String passuser = tbparol.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL AND `pass`=@uP", DB.GetConnection());
            command.Parameters.Add("@uL",MySqlDbType.VarChar).Value = loginuser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passuser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                FormMainMenu f2 = new FormMainMenu();
                f2.Show();
            }
            else label1.Text = "Неправильный логин или пароль";

            
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParm);
        private void gradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
