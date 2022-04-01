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
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class addevent : Form
    {
        //conn
        string connString = "server=localhost; port=3306;user=root;password=root; database=registratura";

        public addevent()
        {
            InitializeComponent();
            Program.fevent = this;
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


       
        private void addevent_Load(object sender, EventArgs e)
        {
            txtdate.ReadOnly = true;

            txtdate.Text = calendar.static_year + "-" + calendar.static_month + "-" + UserControlDays.static_day;

            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn =  new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO tbl_calendar(date,time,fio,phon,event)values(?,?,?,?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", txtdate.Text);
            cmd.Parameters.AddWithValue("time", cmbtime.Text);
            cmd.Parameters.AddWithValue("fio", txtfio.Text);
            cmd.Parameters.AddWithValue("phon", mtxtphone.Text);
            cmd.Parameters.AddWithValue("event", txtevent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Запись создана");
            cmd.Dispose();
            conn.Close();
            this.Close();

        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
