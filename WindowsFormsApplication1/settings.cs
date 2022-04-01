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
    public partial class settings : Form
    {

        public settings()
        {
            InitializeComponent();
        }

        private void btnblue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(49, 51, 75);
            this.ForeColor = Color.White;
            //btnbeige.ForeColor = Color.White;
            //btngray.ForeColor = Color.White;
            //btnsend.ForeColor = Color.White;
            //btnwhite.ForeColor = Color.White;

            //addsotrudnik
            Program.faddsotrd.pnladdsotr.BackColor = Color.FromArgb(49, 51, 75);
            Program.faddsotrd.pnladdsotr.ForeColor = Color.White;

            //Program.f2.calendarmenu.BackColor = Color.FromArgb(49, 51, 75);
            //Program.f2.btntimetable.BackColor = Color.FromArgb(49, 51, 75);
            //Program.f2.pacientmenu.BackColor = Color.FromArgb(49, 51, 75);
            //Program.f2.sotrudnikmenu.BackColor = Color.FromArgb(49, 51, 75);
            //Program.f2.settingmenu.BackColor = Color.FromArgb(49, 51, 75);
            //Program.f2.panelmenu.ForeColor = Color.White;

            //Program.f2.panelmenu.ForeColor = Color.White;
            //Program.f2.calendarmenu.ForeColor = Color.White;
            //Program.f2.btntimetable.ForeColor = Color.White;
            //Program.f2.pacientmenu.ForeColor = Color.White;
            //Program.f2.sotrudnikmenu.ForeColor = Color.White;
            //Program.f2.settingmenu.ForeColor = Color.White;
        }
    }
}
