using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Funda_Trabajo_Parcial
{
    public partial class Config : Form
    {
        public string uname = null;
        public int fsr;

        public static Bunifu.UI.WinForms.BunifuPictureBox _pboxUserImagePreview { get; set; }

        public static Bunifu.UI.WinForms.BunifuLoader _LoaderPhoto { get; set; }

        public static Bunifu.UI.WinForms.BunifuLoader _LoaderChangeImage { get; set; }

        public static Bunifu.UI.WinForms.BunifuLoader _LoaderChangePassword { get; set; }

        public static Label _lblErrorMessage { get; set; }

        public static Label _lblSuccess { get; set; }

        public static Label _lblErrorMessageChangeEmail { get; set; }

        public static Label _lblSuccessChangeEmail { get; set; }

        public Config()
        {
            InitializeComponent();

            MenuPrincipal._AreaLabel.Text = "Ajustes de usuario";

            lblErrorMessage.Visible = false;
            lblSuccess.Visible = false;
            lblErrorMessageChangeEmail.Visible = false;
            lblSuccessChangeEmail.Visible = false;

            fsr = 0;
            uname = MenuPrincipal.UsernameConnected;
            _pboxUserImagePreview = this.pboxUserImagePreview;
            _LoaderChangePassword = this.LoaderChangePassword;
            _lblErrorMessage = this.lblErrorMessage;
            _lblSuccess = this.lblSuccess;
            _lblErrorMessageChangeEmail = this.lblErrorMessageChangeEmail;
            _lblSuccessChangeEmail = this.lblSuccessChangeEmail;


            pboxUserImagePreview.ImageLocation = MenuPrincipal._pictureboxUserImage.ImageLocation;
            _LoaderPhoto = LoaderPhoto;
            _LoaderChangeImage = LoaderChangePhoto;

            ThreadPool.QueueUserWorkItem(delegate
            {
                if (ControladorUsuarios.GetUserRank(uname) == "Administrador")
                {
                    
                    List<usuario> usuarios = ControladorUsuarios.GetAllUsers();
                    var BindingSourceCombobox = new BindingSource();
                    BindingSourceCombobox.DataSource = usuarios;
                    if (lblUserC.InvokeRequired) comboBoxListUsersConfig.Invoke((MethodInvoker)delegate { lblUserC.Visible = true; });
                    else lblUserC.Visible = true;

                    if (comboBoxListUsersConfig.InvokeRequired) comboBoxListUsersConfig.Invoke((MethodInvoker)delegate {                      
                        comboBoxListUsersConfig.Visible = true;
                        comboBoxListUsersConfig.Enabled = true;
                        comboBoxListUsersConfig.DataSource = BindingSourceCombobox.DataSource;
                        comboBoxListUsersConfig.DisplayMember = "username";
                        comboBoxListUsersConfig.ValueMember = "username";
                    });

                    if (bunifuPanelChangeID.InvokeRequired) bunifuPanelChangeID.Invoke((MethodInvoker)delegate { bunifuPanelChangeID.Visible = true; });
                    else bunifuPanelChangeID.Visible = true;

                } 

            }, null);

        }

        private void btnChangeID_Click(object sender, EventArgs e)
        {
            string newUsername = txtboxChangeUser.Text;
            ControladorUsuarios.ChangeUsername(uname, newUsername);
            MessageBox.Show("El nombre de usuario fue cambiado con exito.", "Success", MessageBoxButtons.OK);
            txtboxChangeUser.Text = "";
            
            if (MenuPrincipal.UsernameConnected == uname) {
                MenuPrincipal.UsernameConnected = newUsername;
                MenuPrincipal._lblUsername.Text = newUsername;
            }       
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string password1 = txtboxChangePassword1.Text;
            string password2 = txtboxChangePassword2.Text;
            ControladorUsuarios.ChangePassword(uname, password1, password2);

        }

        private void txtboxChangePassword2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtboxChangePassword1.Text.Length > 0 && txtboxChangePassword2.Text.Length > 0) btnChangePassword.Enabled = true;
            else btnChangePassword.Enabled = false;
        }

        private void txtboxChangePassword1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtboxChangePassword2.Text.Length > 0 && txtboxChangePassword1.Text.Length > 0) btnChangePassword.Enabled = true;
            else btnChangePassword.Enabled = false;
        }

        private void btnChoicePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.jpg";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ControladorUsuarios.ChangeUserPicture(uname, dialog.FileName);
            }

        }


        private void comboBoxListUsersConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            fsr += 1;
            if (fsr > 2)
            {
                
                Console.WriteLine("Changed");
                string UserConfigSelected = "";
                UserConfigSelected = this.comboBoxListUsersConfig.GetItemText(this.comboBoxListUsersConfig.SelectedItem);

                Console.WriteLine("Selected: " + UserConfigSelected);

                ControladorUsuarios.SetUserPicture(UserConfigSelected, false, true);

                uname = UserConfigSelected;

            }

        }


        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            string email = txtboxEmail.Text;
            ControladorUsuarios.ChangeEmail(uname, email);
        }

        private void lblUserC_Click(object sender, EventArgs e)
        {

        }
    }
}
