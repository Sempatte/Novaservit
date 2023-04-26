using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace Funda_Trabajo_Parcial
{
    public partial class InicioDeSesion : Form
    {

        public Thread MP;

        public static string UsernameLogin { get; set; }

        

        public Database database = new Database();

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

        public InicioDeSesion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10)); // Bordes redondeados
        }

        private void Login(string username, string password)
        {
            
         
                MP = new Thread(() =>
                {
                    LoaderLogin.Invoke((MethodInvoker)delegate { LoaderLogin.Visible = true; });
                    //else LoaderLogin.Visible = true;

                    txtboxContrasena.Invoke((MethodInvoker)delegate { txtboxContrasena.Enabled = false; });
                    //else txtboxContrasena.Enabled = false;

                    this.Invoke((MethodInvoker)delegate { btnLogin.Enabled = false; });
                    //else btnLogin.Enabled = false;

                    string response = ControladorUsuarios.Login(username, password);

                    this.Invoke((MethodInvoker)delegate { btnLogin.Enabled = true; });
                    //else btnLogin.Enabled = true;

                    LoaderLogin.Invoke((MethodInvoker)delegate { LoaderLogin.Visible = false; });
                    //else LoaderLogin.Visible = false;


                    if (response.Length > 0)
                    {
                        txtboxContrasena.Invoke((MethodInvoker)delegate { txtboxContrasena.Enabled = true; });
      

                        this.Invoke((MethodInvoker)delegate { lblError.Visible = true; });
         

                        this.Invoke((MethodInvoker)delegate { lblError.Text = response; });
     

                        return;
                    }

                    UsernameLogin = username;

                    txtboxContrasena.Invoke((MethodInvoker)delegate { txtboxContrasena.Text = ""; });
 

                    this.Invoke((MethodInvoker)delegate { lblError.Visible = false; });
     

                    this.Invoke((MethodInvoker)delegate { this.Visible = false; });


                    var MenuPrincipal = new MenuPrincipal();
                    MenuPrincipal.ShowDialog();
                    if (MenuPrincipal.DialogResult != DialogResult.No) this.Close();

                    if (this.InvokeRequired) this.Invoke((MethodInvoker)delegate { this.Visible = true; });

                    txtboxContrasena.Invoke((MethodInvoker)delegate { txtboxContrasena.Enabled = true; });
    
                });

                MP.SetApartmentState(ApartmentState.STA);
                MP.Start();

            
   
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtboxUsuario.Text;
            string password = txtboxContrasena.Text;
            Login(username, password);

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelFondo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void InicioDeSesion_KeyDown(object sender, KeyEventArgs e)
        {
    

        }


        private void panelDerechoLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       

        private void txtboxContrasena_KeyDown(object sender, KeyEventArgs e)
        {
 
        }

        private void txtboxContrasena_KeyUp(object sender, KeyEventArgs e)
        {

            
            if (txtboxContrasena.Text.Length > 0) btnLogin.Enabled = true;
            else btnLogin.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Registro().Show();
            this.Hide();
        }

        private void txtboxContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
