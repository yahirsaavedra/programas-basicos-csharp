using System;
using System.Windows.Forms;

namespace ProyectoFinal_TAP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppMenu());
            //Application.Run(new AppDescripcion());
        }
    }
}
