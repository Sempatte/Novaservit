using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using Funda_Trabajo_Parcial.Validators;
using FluentValidation.Results;

namespace Funda_Trabajo_Parcial
{
    public partial class Registro : Form
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

        public Registro()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10)); // Bordes redondeados
        }

        


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelFondo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }


        private void panelDerechoLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register(usuario newUser) {

            void setLoader(bool value)
            {
                if (RegisterLoader.InvokeRequired) RegisterLoader.Invoke((MethodInvoker)delegate { RegisterLoader.Visible = value; });
                else RegisterLoader.Visible = value;
            }
            MP = new Thread(() =>
            {
                setLoader(true);
                //if (lblError.InvokeRequired) lblError.Invoke((MethodInvoker)delegate { lblError.Visible = false; });
                //else lblError.Visible = false;

                string Response = ControladorUsuarios.Register(newUser);
                Console.WriteLine(Response);
                if (Response != "")
                {
                    if (lblError.InvokeRequired) lblError.Invoke((MethodInvoker)delegate { 
                        lblError.Visible = true;
                        lblError.Text = Response;
                        setLoader(false);
                    });
                    else {
                        lblError.Visible = true;
                        lblError.Text = Response;
                        setLoader(false);
                    };
                    return;
                }

                if (this.InvokeRequired) this.Invoke((MethodInvoker)delegate
                {
                    new InicioDeSesion().Show();
                    Hide();
                    Visible = false;

                });
                else {
                    new InicioDeSesion().Show();
                    Hide();
                    Visible = false;
                }
               

                
            });
            MP.SetApartmentState(ApartmentState.STA);
            MP.Start();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtboxUsuario.Text;
            string password = txtboxContrasena.Text;
            string password2 = txtboxContrasenaConfirmar.Text;
            string email = txtboxEmail.Text;

            lblError.Visible = false;
            //TO DO: Registrar usuario


            if (password != password2)
            {
                lblError.Visible = true;
                lblError.Text = "Las contraseñas no coinciden";
                return;
            }

            var newUser = new usuario()
            {
                email = email,
                password = password,
                username = username,
                photo = "https://media.istockphoto.com/id/1208175274/vector/avatar-vector-icon-simple-element-illustrationavatar-vector-icon-material-concept-vector.jpg?s=612x612&w=0&k=20&c=t4aK_TKnYaGQcPAC5Zyh46qqAtuoPcb-mjtQax3_9Xc=",
                rank = 1
            };

            var validator = new UserValidator();
            ValidationResult result = validator.Validate(newUser);

            if (!result.IsValid)
            {
                lblError.Visible = true;
                foreach (var error in result.Errors)
                {

                    lblError.Text = error.ErrorMessage;
                }
                return;
            }

            Register(newUser);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new InicioDeSesion().Show();
            Hide();
            
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                newUserPicture.Image = new Bitmap(opnfd.FileName);
            }
        }





        private void btnBack_Click(object sender, EventArgs e)
        {
            new InicioDeSesion().Show();
            Hide();
        }
    }
}
