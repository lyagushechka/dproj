using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class calendar : Form
    {
        int year, month;
        //static variable 
        public static int static_month, static_year;
        public calendar()
        {
            InitializeComponent();
        }

        private void calendar_Load(object sender, EventArgs e)
        {
            displaDays();
        }
        private void displaDays()
        {
            
            DateTime now =  DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDATE.Text =monthname+ " "+ year;


            static_month = month;
            static_year = year;

            // first day in mounth

            DateTime startofthemonth = new DateTime(year, month,1);
            //count day month
            int days = DateTime.DaysInMonth(year, month);
            //convert 
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) ;


            
            //usercontrol

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for(int i = 1; i<= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);  
                daycontainer.Controls.Add(ucdays); 
            }
            

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            //clear control
            daycontainer.Controls.Clear();
            //decrement month to go  to prevous month
            month--;
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            //count day month
            int days = DateTime.DaysInMonth(year, month);
            //convert 
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));



            //usercontrol

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            //clear control
            daycontainer.Controls.Clear();

            //increment month to go  to next month
            month++;

            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //count day month
            int days = DateTime.DaysInMonth(year, month);
            //convert 
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));



            //usercontrol

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
