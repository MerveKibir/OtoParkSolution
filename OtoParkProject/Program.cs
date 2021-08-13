using OtoParkProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoParkProject
{
    public static class Program
    {
        public static  bool ilk=false;
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseContext context = new DatabaseContext();
            //if (context.Sirketler_TB.Count() > 1)
            //{
            //    ilk = true;
            //}
            Application.Run(new AnaSayfa());

        }
    }
}
