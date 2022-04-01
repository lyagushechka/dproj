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
    public partial class addsotrudnik : Form
    {
        private readonly Formsotr _parent;
        public string id, name, familia, otchestvo, phone;

        public addsotrudnik(Formsotr parent)
        {
            Program.faddsotrd = this;
            InitializeComponent();
            _parent = parent;
            

        }
        public void UpdateInfo()
        {
            label3.Text = "Изменить информацию";
            button_add.Text = "Изменить";
            textBoxname.Text = name;
            textBoxfamil.Text = familia;
            textBoxotche.Text = otchestvo;
            mtxtphone.Text = phone;
        }

        public void SaveInfo()
        {
            label3.Text = "Добавить сотрудника";
            button_add.Text = "Добавить";
        }

        public void Clear1()
        {
            textBoxname.Text = textBoxname.Text = textBoxfamil.Text = textBoxotche.Text= mtxtphone.Text = string.Empty;
            
        }
        private void exitoknosave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParm);
        private void gradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            Clear1();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text.Trim().Length < 2 )
            { MessageBox.Show("Мало символов");
                return;
            }

            if (textBoxfamil.Text.Trim().Length < 2)
            {
                MessageBox.Show("Мало символов");
                return;
            }

            if (mtxtphone.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите номер телефона");
                return;
            }

            if(button_add.Text == "Добавить")
            {
                Sotrudniki std = new Sotrudniki(textBoxname.Text.Trim(), textBoxfamil.Text.Trim(), textBoxotche.Text.Trim(), mtxtphone.Text.Trim());
                DB.Addsotrudnik(std);
                Clear1();
                this.Hide();
            }

            if (button_add.Text == "Изменить")
            {
                Sotrudniki std = new Sotrudniki(textBoxname.Text.Trim(), textBoxfamil.Text.Trim(), textBoxotche.Text.Trim(), mtxtphone.Text.Trim());
                DB.Updatesotrudnik(std,id);
                Clear1();
                this.Hide();
            }

            _parent.Display();
            
        }

      
    }
}
