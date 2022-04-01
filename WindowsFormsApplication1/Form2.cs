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
using FontAwesome.Sharp;
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class FormMainMenu : Form
    {
        //field
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        //Constuctor

        public FormMainMenu()
        {
            InitializeComponent();
            
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            panelmenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false; //перхняя панель скрывает открывает
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        } 

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(13, 77, 102);
        }


        //Method
        private void ActivateButton (object sendBtn, Color color)
            {
                if (sendBtn != null)
                   {
                DisableButton();
                //button
                        currentBtn = (IconButton)sendBtn;
                        currentBtn.BackColor = Color.FromArgb(255,255,255);
                        currentBtn.ForeColor = color;
                        currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                        currentBtn.IconColor = color;
                currentBtn.IconSize = 70;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                        currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button 
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon Current Child form
                //IconCurrentChildForm.IconChar = currentBtn.IconChar;
                //IconCurrentChildForm.IconColor = Color.FromArgb(255, 255, 255);
                
                    }
            }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = Color.FromArgb(11, 137, 160);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(11, 137, 160);
                currentBtn.IconSize = 70;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            currentChildForm.Show();
            IblTitleChildForm.Text = childForm.Text;
            
        }

       


        private void f2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            OpenChildForm(new calendar());




        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pacientmenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new pacienty());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
           DisableButton();
           leftBorderBtn.Visible = false;
            IconCurrentChildForm.IconChar = IconChar.UserCircle;
            IconCurrentChildForm.IconColor = Color.FromArgb(255, 255, 255);
            IblTitleChildForm.Text = "Кабинет";

        }

        private void calendarmenu_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new calendar());
        }

        private void btnDashboard_click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new pacienty());
        }

        private void sotrudnikmenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Formsotr());
        }

        private void settingmenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new settings());
        }

        private void btntimetable_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new timetable1());
        }

        private void IconCurrentChildForm_Click(object sender, EventArgs e)
        {
            //currentChildForm.Close();
            //Reset();
        }

        private void iconSpravka_Click(object sender, EventArgs e)
        {

        }

        private void IblTitleChildForm_Click(object sender, EventArgs e)
        {

        }

        private void Maxim_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

            
        

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics mgraphics = e.Graphics;
        //    Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);
        //    Rectangle area = new Rectangle (0,0, this.Width -1, this.Height -1);
        //    LinearGradientBrush lbd = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
        //    mgraphics.FillRectangle(lbd, area);
        //    mgraphics.DrawRectangle(pen, area);
        //}

        ////DragForm
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //public static extern bool ReleaseCapture();


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParm);
        private void gradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
                  SendMessage(this.Handle, 0x112, 0xf012, 0);

            //if (e.Button == MouseButtons.Left)
            //{
            //    ReleaseCapture();
            //    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            //}

        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            exitokno mb = new exitokno();
            mb.ShowDialog();

            //DialogResult dialogResult = MessageBox.Show("Вы хотите выйти?", "Some Title", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    //do something
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    //do something else
            //}
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }










        //[DllImport("C:\Windows\SysWOW64\user32.DILL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();

        //[DllImport("user32.DILL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParm);
        //   private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        // {

        //      ReleaseCapture();
        //      SendMessage(this.Handle, 0x112, 0xf012, 0);
        //  }
    }
}
