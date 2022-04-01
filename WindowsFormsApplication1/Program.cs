using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        public static Formsotr fsotrd;
        public static addevent fevent;
        public static addsotrudnik faddsotrd;
        public static pacienty fpacienty;


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loginform());
        }

        //public static System.Windows.Forms.Panel panel3;
    }
}
