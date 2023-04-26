using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentFTP;

namespace Funda_Trabajo_Parcial
{

    class FTPClient
    {
        public static FtpClient Client { get; set; }

        private static FtpClient client = new FtpClient();

        public FTPClient() {
            SetupConnectionCDN();
        }

        public static bool SetupConnectionCDN()
        {
            try
            {
                client.Host = "files.000webhost.com";
                client.Credentials = new System.Net.NetworkCredential("huellitasfelices-grupo2", "estafacil1");
                client.Connect();
                Client = client;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
