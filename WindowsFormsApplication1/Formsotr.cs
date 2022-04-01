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
    public partial class Formsotr : Form
    {
        addsotrudnik form;
        public Formsotr()
        {
            InitializeComponent();
            form = new addsotrudnik(this);
            Program.fsotrd = this;
        }
        public void Display()
        {
            DB.DisplayandSearch("SELECT ID, Name, Familia, Otchestvo, Phone FROM tbl_sotrudniki", dataGridView1);
        }


        private void btnadd_Click(object sender, EventArgs e)
        {

            form.Clear1();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void Formsotr_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DB.DisplayandSearch("SELECT ID, Name, Familia, Otchestvo, Phone FROM tbl_sotrudniki WHERE Name LIKE '%" + txtsearch.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //edit
                form.Clear1();
                form.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.familia = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.otchestvo = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.phone = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //delete
                if(MessageBox.Show("Вы уверены? Хотите удалить запись?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)== DialogResult.Yes)
                {
                    DB.DeletSotrudnik(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void Formsotr_Load(object sender, EventArgs e)
        {



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
