using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Data.Entity;
using System.Drawing;

namespace Funda_Trabajo_Parcial
{
    class ControladorUsuarios
    {
        private static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", "");

        public ControladorUsuarios() { }

        public static List<usuario> GetAllUsers()
        {
            List<usuario> usuarios = new List<usuario>();
            try
            {
                var userData = (from oData in Database.Main.usuarios
                                select oData);
                foreach (var user in userData)
                {
                    usuario usr = new usuario();
                    usr.idUsuario = user.idUsuario;
                    usr.username = Utils.FirstCharToUpper(user.username);
                    usr.password = user.password;
                    usr.rank = user.rank;
                    usr.email = user.email;
                    usuarios.Add(usr);
                }

            }
            catch (Exception ex)
            {
                if (ex is System.Data.Entity.Core.EntityCommandExecutionException || ex is System.InvalidOperationException)
                {
                    Console.WriteLine("Fail GetAllUsers... Retrying...");
                    Thread.Sleep(600);
                    GetAllUsers();
                }

            }
            return usuarios;

        }

        public static void ChangeUserPicture(string username, string dialog_path)
        {

            ThreadPool.QueueUserWorkItem(delegate {
         
                if (Config._LoaderChangeImage.InvokeRequired) Config._LoaderChangeImage.Invoke((MethodInvoker)delegate { Config._LoaderChangeImage.Visible = true; });
                else Config._LoaderChangeImage.Visible = true;

                var Query = Database.Main.usuarios.SingleOrDefault(u => u.username == username);
                

                var l = dialog_path.Split('\\').Last();
                Query.photo = l;
                Database.Main.Entry(Query).State = EntityState.Modified;
                Database.Main.SaveChanges();

                FTPClient.Client.UploadFile(dialog_path, "/novaservit/user_photos/" + l);


                if (MenuPrincipal.UsernameConnected == username.ToLower()) SetUserPicture(username, true, true);
                else SetUserPicture(username, false, true);
                if (Config._LoaderChangeImage.InvokeRequired) Config._LoaderChangeImage.Invoke((MethodInvoker)delegate { Config._LoaderChangeImage.Visible = false; });
                else Config._LoaderChangeImage.Visible = false;


            }, null);


        }

        public static void SetUserPicture(string username, bool b, bool config = false)
        {

            ThreadPool.QueueUserWorkItem(delegate {

                if (config == true)
                {
                    if (Config._LoaderPhoto.InvokeRequired) Config._LoaderPhoto.Invoke((MethodInvoker)delegate { Config._LoaderPhoto.Visible = true; });
                    else Config._LoaderPhoto.Visible = true;
                }


                if (b == true)
                {
                    if (MenuPrincipal.LoaderMainImage.InvokeRequired) MenuPrincipal.LoaderMainImage.Invoke((MethodInvoker)delegate { MenuPrincipal.LoaderMainImage.Visible = true; });
                    else MenuPrincipal.LoaderMainImage.Visible = true;
                }

                var realpath = path + "temp\\users_thumbnails\\";

                var _user = Database.Main.usuarios.SingleOrDefault(u => u.username == username);
                string photo = _user.photo;
                try
                {
                    FTPClient.Client.DownloadFile(realpath + photo, "/novaservit/user_photos/" + photo);
                }
                catch (FluentFTP.FtpException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Retrying...");
                    Thread.Sleep(2000);
                    SetUserPicture(username, false);
                }
                if (config == true)
                {
                    Config._pboxUserImagePreview.ImageLocation = realpath + photo;
                    if (Config._LoaderPhoto.InvokeRequired) Config._LoaderPhoto.Invoke((MethodInvoker)delegate { Config._LoaderPhoto.Visible = false; });
                    else Config._LoaderPhoto.Visible = false;
                }
                if (b == true)
                {
                    if (MenuPrincipal.LoaderMainImage.InvokeRequired) MenuPrincipal.LoaderMainImage.Invoke((MethodInvoker)delegate { MenuPrincipal.LoaderMainImage.Visible = false; });
                    else MenuPrincipal.LoaderMainImage.Visible = false;
                    MenuPrincipal._pictureboxUserImage.ImageLocation = realpath + photo;
                }

            }, null);




        }

        public static string GetUserRank(string username)
        {
            try
            {
                var _user = Database.Main.usuarios.SingleOrDefault(u => u.username == username);
                if (_user.rank == 2) return "Administrador";
                else return "Usuario";
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetUserRank failed... Retrying...");
                Thread.Sleep(100);
                GetUserRank(username);
            }
            return "Usuario";

        }

        public static usuario getUsuarioDb(string usuario)
        {
            usuario usr = null;

            try
            {
                var userData = (from oData in Database.Main.usuarios
                                where oData.username == usuario
                                select oData);
                foreach (var data in userData)
                {
                    usr = new usuario();
                    usr.idUsuario = data.idUsuario;
                    usr.username = Utils.FirstCharToUpper(data.username);
                    usr.password = data.password;
                    usr.rank = data.rank;
                    usr.email = data.email;
                }
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Retrying...");
                getUsuarioDb(usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return usr;
        }

        public static void ChangeEmail(string username, string newEmail)
        {
            Config._lblErrorMessageChangeEmail.Visible = false;
            Config._lblSuccessChangeEmail.Visible = false;

            if (!newEmail.Contains("@") || newEmail.Length < 8)
            {
                Config._lblErrorMessageChangeEmail.Text = "Ingresa un correo valido.";
                Config._lblErrorMessageChangeEmail.Visible = true;
                return;
            }

            ThreadPool.QueueUserWorkItem(delegate
            {
                try
                {
                    var Query = Database.Main.usuarios.SingleOrDefault(u => u.username == username);
                    Query.email = newEmail;
                    Database.Main.SaveChanges();

                    if (Config._lblErrorMessageChangeEmail.InvokeRequired) Config._lblSuccess.Invoke((MethodInvoker)delegate { Config._lblErrorMessageChangeEmail.Visible = false; });
                    else Config._lblErrorMessageChangeEmail.Visible = false;

                    if (Config._lblSuccessChangeEmail.InvokeRequired) Config._lblSuccess.Invoke((MethodInvoker)delegate { Config._lblSuccessChangeEmail.Visible = true; });
                    else Config._lblSuccessChangeEmail.Visible = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Retrying...");
                    Thread.Sleep(600);
                    ChangeEmail(username, newEmail);
                }

            }, null);
        }

        public static void ChangeUsername(string username, string newUsername)
        {

            ThreadPool.QueueUserWorkItem(delegate
            {
                try
                {
                    var Query = Database.Main.usuarios.SingleOrDefault(u => u.username == username);
                    Query.username = newUsername;
                    Database.Main.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Retrying...");
                    ChangeUsername(username, newUsername);
                }

            }, null);
        }

        public static void ChangePassword(string username, string password1, string password2)
        {
            if (password1 != password2)
            {
                Config._lblErrorMessage.Text = "Las contrasenias no coinciden.";
                Config._lblErrorMessage.Visible = true;
                return;
            }

            if (password1.Length < 6)
            {
                Config._lblErrorMessage.Text = "La contrasenia es muy corta. Use mas de 6 caracteres.";
                Config._lblErrorMessage.Visible = true;
                return;
            }


            ThreadPool.QueueUserWorkItem(delegate
            {
                try
                {
                    if (Config._LoaderChangePassword.InvokeRequired) Config._LoaderChangePassword.Invoke((MethodInvoker)delegate { Config._LoaderChangePassword.Visible = true; });
                    else Config._LoaderChangePassword.Visible = true;
                    var Query = Database.Main.usuarios.SingleOrDefault(u => u.username == username);
                    Query.password = Encriptacion.Encrypt(password1);
                    Database.Main.SaveChanges();

                    if (Config._LoaderChangePassword.InvokeRequired) Config._LoaderChangePassword.Invoke((MethodInvoker)delegate { Config._LoaderChangePassword.Visible = false; });
                    else Config._LoaderChangePassword.Visible = false;

                    if (Config._lblErrorMessage.InvokeRequired) Config._lblErrorMessage.Invoke((MethodInvoker)delegate { Config._lblErrorMessage.Visible = false; });
                    else Config._lblErrorMessage.Visible = false;

                    if (Config._lblSuccess.InvokeRequired) Config._lblSuccess.Invoke((MethodInvoker)delegate { Config._lblSuccess.Visible = true; });
                    else Config._lblSuccess.Visible = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Retrying...");
                    Thread.Sleep(600);
                    ChangePassword(username, password1, password2);
                }

            }, null);
        }

        public static string Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return "Ingrese todos los datos.";
            usuario DatosUsuario = getUsuarioDb(username);
            if (DatosUsuario == null) return "El usuario no existe.";
            if (DatosUsuario.password != Encriptacion.Encrypt(password)) return "La contraseña es incorrecta.";

            return "";
        }

        public static string Register(usuario newUser)
        {
            // TO DO: FALTA COMPARAR USER CON LA DB

            usuario DatosUsuario = getUsuarioDb(newUser.username);
            if (DatosUsuario != null) return "El usuario ya existe.";

            newUser.password = Encriptacion.Encrypt(newUser.password);
            Database.Main.usuarios.Add(newUser);
            Database.Main.SaveChanges();
            return "";
        }

    }
}
