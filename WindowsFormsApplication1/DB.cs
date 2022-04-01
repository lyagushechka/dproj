using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal class DB
    {

        public static MySqlConnection GetConnection()
        {

            string sql = "server=localhost; port=3306;user=root;password=root; database=registratura";

            MySqlConnection conn = new MySqlConnection(sql);

            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQLConnection! \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public static void Addsotrudnik (Sotrudniki std)
        {
            //conn.Open();
            //String sql = "INSERT INTO tbl_calendar(date,time,fio,phon,event)values(?,?,?,?,?)";
            //MySqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = sql;
            //cmd.Parameters.AddWithValue("date", txtdate.Text);
            //cmd.Parameters.AddWithValue("time", cmbtime.Text);
            //cmd.Parameters.AddWithValue("fio", txtfio.Text);
            //cmd.Parameters.AddWithValue("phon", mtxtphone.Text);
            //cmd.Parameters.AddWithValue("event", txtevent.Text);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Запись создана");
            //cmd.Dispose();
            //conn.Close();
            //this.Close();





            string sql = "INSERT INTO tbl_sotrudniki VALUES(NULL, @SotrudnikiName, @SotrudnikiFamilia, @SotrudnikiOtchestvo, @SotrudnikiPhone)"; 
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SotrudnikiName", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@SotrudnikiFamilia", MySqlDbType.VarChar).Value = std.Familia;
            cmd.Parameters.Add("@SotrudnikiOtchestvo", MySqlDbType.VarChar).Value = std.Otchestvo;
            cmd.Parameters.Add("@SotrudnikiPhone", MySqlDbType.VarChar).Value = std.Phone;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySqlException ex)
            {

                MessageBox.Show("Не удалось добавить \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Close();
        }

        public static void Updatesotrudnik(Sotrudniki std, string id)
        {
            string sql = "UPDATE tbl_sotrudniki SET Name=@SotrudnikiName, Familia=@SotrudnikiFamilia, Otchestvo=@SotrudnikiOtchestvo,Phone=@SotrudnikiPhone WHERE ID=@SotrudnikiID";

            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SotrudnikiID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@SotrudnikiName", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@SotrudnikiFamilia", MySqlDbType.VarChar).Value = std.Familia;
            cmd.Parameters.Add("@SotrudnikiOtchestvo", MySqlDbType.VarChar).Value = std.Otchestvo;
            cmd.Parameters.Add("@SotrudnikiPhone", MySqlDbType.VarChar).Value = std.Phone;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Таблица успешно обновлена", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Не удалось обновить \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeletSotrudnik(string id)
        {
            string sql = "DELETE FROM tbl_sotrudniki WHERE ID=@SotrudnikID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SotrudnikID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Не удалось удалить \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayandSearch (string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand (sql,con);
            MySqlDataAdapter adp = new MySqlDataAdapter (cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }


    }
}



        //    if (connection.State == System.Data.ConnectionState.Closed)
        //    {
        //        connection.Open();
        //    }
        //}
        //public void closeConnection()
        //{
        //    if (connection.State == System.Data.ConnectionState.Open)
        //    {
        //        connection.Close();
        //    }
        //}
        //public MySqlConnection GetConnection()
        //{
        //    return connection;
        //}

