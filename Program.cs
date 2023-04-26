using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Funda_Trabajo_Parcial
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Console.WriteLine(System.Configuration.ConfigurationManager.AppSettings[0]);
            Encriptacion encriptacion = new Encriptacion();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InicioDeSesion());
        }
    }
}
