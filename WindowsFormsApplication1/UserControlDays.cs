using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UserControlDays : UserControl
    {

        string connString = "server=localhost; port=3306;user=root;password=root; database=registratura";

        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        public void days (int numday)
        {
            lbdays.Text = numday+"";    
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {

            static_day = lbdays.Text;
            //start timer 

            addevent eventform = new addevent();
            eventform.Show();
            timer1.Start();

        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayEvent();
        }
        private void displayEvent()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "SELECT * FROM tbl_calendar where date = @Date"; /*time=@Time*/
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", calendar.static_year  + "-" + calendar.static_month + "-" + lbdays.Text);
            MySqlDataReader reader = cmd.ExecuteReader();  
            if (reader.Read())
            {
                lblevent.Text = reader["event"].ToString();

            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();

        }
        //timer for auto display  if added  new event 

        private void timer1_Tick(object sender, EventArgs e)
        {
            // вызов дисплей метода
            displayEvent();
        }
        


    }
}
