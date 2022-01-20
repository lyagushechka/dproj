using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WindowsFormsApplication1
{
    public partial class FormMainMenu : Form
    {

        //field
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Constuctor

        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            panelmenu.Controls.Add(leftBorderBtn);
        }



            //Method
            private void ActivateButton (object sendBtn, Color color)
            {
                if (sendBtn != null)
                   {
                DisableButton();
                //button
                        currentBtn = (IconButton)sendBtn;
                        currentBtn.BackColor = Color.FromArgb(37, 36,81);
                        currentBtn.ForeColor = color;
                        currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                        currentBtn.IconColor = color;
                        currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                        currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button 
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                    }
            }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = Color.Black ;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }




        private void f2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

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

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
           // DisableButton();
           // leftBorderBtn.visible = false;

        }
    }
}
