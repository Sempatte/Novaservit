using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Collections;

namespace Funda_Trabajo_Parcial
{
    public partial class MenuPrincipal : Form
    {
        public static string UsernameConnected { get; set; }

        public static Label _AreaLabel { get; set; }

        public static Bunifu.UI.WinForms.BunifuLoader LoaderMainImage { get; set; }

        public static Bunifu.UI.WinForms.BunifuPictureBox _pictureboxUserImage { get; set; }


        public static Bunifu.UI.WinForms.BunifuLabel _lblUsername { get; set; }

        public usuario usuarioActivo;

        private Thread CheckConnection;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,    
            int nTopRect,     
            int nRightRect,
            int nBottomRect,  
            int nWidthEllipse,
            int nHeightEllipse
        );

        public MenuPrincipal()
        {
            InitializeComponent();

            if (!FTPClient.SetupConnectionCDN()) {
                MessageBox.Show("Error al conectarse con el servidor CDN. Revise consola para mas detalles.", "Success", MessageBoxButtons.OK);
                Application.Exit();
            }

            this.lblArea.Text = "Menu principal";

            _lblUsername = this.lblUsername; _pictureboxUserImage = this.pictureboxUserImage; _AreaLabel = this.lblArea;// Para usar en las otras capas.
            LoaderMainImage = this.LoaderProfileImageMenu;

            this.StartPosition = FormStartPosition.CenterScreen;  // Centrar ventana.
            CheckConnection = new Thread(new ThreadStart(CheckConn)); // Thread controladora de la conexion activa.
            CheckConnection.Start();
            UsernameConnected = InicioDeSesion.UsernameLogin;
            Console.WriteLine("UsernameConnected: " + UsernameConnected.ToString());
            usuarioActivo = ControladorUsuarios.getUsuarioDb(InicioDeSesion.UsernameLogin);

            lblUserType.Text = ControladorUsuarios.GetUserRank(usuarioActivo.username);
            lblUsername.Text = usuarioActivo.username;
            //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10)); // Bordes redondeados

            ControladorUsuarios.SetUserPicture(usuarioActivo.username, true);
            UISwitch(new Inicio());
        }

        private Form activeForm = null;

        private void UISwitch(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCentro.Controls.Add(childForm);
            panelCentro.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CheckConn()
        {
            while (true)
            {

                bool status = Utils
                    .CheckConnection();

                if (status == true){
                    lblStatusConn.ForeColor = Color.Lime;
                    if (lblStatusConn.InvokeRequired) lblStatusConn.Invoke((MethodInvoker)delegate { lblStatusConn.Text = "Connected."; });
                    else lblStatusConn.Text = "Connected.";
                }
                else{
                    lblStatusConn.ForeColor = Color.Red;
                    if (lblStatusConn.InvokeRequired) lblStatusConn.Invoke((MethodInvoker)delegate { lblStatusConn.Text = "Unconnected. Retrying..."; });
                    else lblStatusConn.Text = "Unconnected. Retrying...";
                }


                Thread.Sleep(5000); // Each 5 seconds.
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            UISwitch(new Inicio());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToShortDateString();
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


        private void panelSlider_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnClients_Click(object sender, EventArgs e)
        {
            UISwitch(new Clientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonUserConfig_Click(object sender, EventArgs e)
        {
            UISwitch(new Config());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UISwitch(new ProyectosPrincipal());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UISwitch(new Extras());
        }
    }
}
