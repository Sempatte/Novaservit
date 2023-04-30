using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Data.Entity;

namespace Funda_Trabajo_Parcial
{
    class ControladorClientes 
    {
        public ControladorClientes() { }

        public static List<cliente> GetListaClientes()
        {
            List<cliente> Clientes = new List<cliente>();
            var userData = (from oData in Database.Main.clientes
                            select oData);
            foreach (var user in userData)
            {
                cliente Cliente = new cliente();
                Cliente.nombreEmpresa = user.nombreEmpresa;
                Cliente.fechaRegistro = user.fechaRegistro;
                Cliente.RUC = user.RUC;
                
                Clientes.Add(Cliente);
            }
            return Clientes;
        }

        public static cliente GetCliente(string NombreEmpresa)
        {
            cliente _Cliente = Database.Main.clientes.SingleOrDefault(u => u.nombreEmpresa.Contains(NombreEmpresa));
            return _Cliente;
        }


        public static void ActualizarDataModificableCliente(cliente Cliente)
        {
            ThreadPool.QueueUserWorkItem(delegate
            {
                try
                {

                    if (ModificarClientes._DataGridViewModificarCliente.InvokeRequired)
                    {

                        ModificarClientes._DataGridViewModificarCliente.Invoke((MethodInvoker)delegate
                        {

                            ModificarClientes._DataGridViewModificarCliente.Rows.Clear();
                            ModificarClientes._DataGridViewModificarCliente.Rows.Add(Cliente.nombreEmpresa, Cliente.fechaRegistro, Cliente.RUC);
                        });
                    }
                    else
                    {
                        ModificarClientes._DataGridViewModificarCliente.Rows.Clear();
                        ModificarClientes._DataGridViewModificarCliente.Rows.Add(Cliente.nombreEmpresa, Cliente.fechaRegistro, Cliente.RUC);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Retrying...");
                    Thread.Sleep(600);
                    ActualizarDataModificableCliente(Cliente);
                }
            }, null);
        }




        

        public static void GuardarDatosCliente(cliente clienteModificado)
        {
            ModificarClientes._LblErrorMessage.Visible = false;
            ModificarClientes._LblSuccess.Visible = false;

            try
            {
                var ClienteEmpresa = Database.Main.clientes.FirstOrDefault(s => s.RUC == clienteModificado.RUC);

                ClienteEmpresa.nombreEmpresa = clienteModificado.nombreEmpresa;
                ClienteEmpresa.fechaRegistro = clienteModificado.fechaRegistro;
                //ClienteEmpresa.RUC = clienteModificado.RUC;
                Database.Main.Entry(ClienteEmpresa).State = EntityState.Modified;
                Database.Main.SaveChanges();
                ModificarClientes._LblSuccess.Visible = true;
            }
            catch (System.NullReferenceException ex)
            {
                ModificarClientes._LblErrorMessage.Visible = true;
                ModificarClientes._LblErrorMessage.Text = ex.Message.ToString();
            }
            catch (Exception ex)
            {
                ModificarClientes._LblErrorMessage.Visible = true;
                ModificarClientes._LblErrorMessage.Text = ex.Message.ToString();
            }



        }

        public static string AddProjectAndClient(string nombre_empresa_cliente, Int64 RUC, string nombre_proyecto, decimal costo_proyecto ,DateTime fechaInicio)
        {
            cliente Cliente = new cliente();
            Cliente.nombreEmpresa = nombre_empresa_cliente;
            Cliente.fechaRegistro = DateTime.Now.Date;
            Cliente.RUC = RUC;
            Database.Main.clientes.Add(Cliente);

            proyecto Proyecto = new proyecto();
            Proyecto.cliente = Cliente;
            Proyecto.nombre = nombre_proyecto;
            Proyecto.fecha_inicio = fechaInicio.Date;
            Proyecto.costo = costo_proyecto;
            Proyecto.estado = true;

            Database.Main.proyectos.Add(Proyecto);

            Database.Main.SaveChanges();

            return "";
        }

        public static void ActualizarTablaClientes()
        {
            List<cliente> Clientes = new List<cliente>();


            ThreadPool.QueueUserWorkItem(delegate
            {
                var userData = (from oData in Database.Main.clientes
                                select oData).OrderBy(x => x.fechaRegistro);
            try
            {
                foreach (var _cliente in userData)
                    {
                        cliente cln = new cliente();
                        cln.nombreEmpresa = _cliente.nombreEmpresa;
                        cln.fechaRegistro = _cliente.fechaRegistro;
                        cln.RUC = _cliente.RUC;
                        Clientes.Add(cln);
                    }

                if (ListarTodosLosClientes._DataGridViewClientes.InvokeRequired)
                {

                    ListarTodosLosClientes._DataGridViewClientes.Invoke((MethodInvoker)delegate
                    {
                        ListarTodosLosClientes._DataGridViewClientes.DataSource = Database.Main.clientes.Select(l => new {
                            l.nombreEmpresa,
                            l.fechaRegistro,
                            l.RUC
                        }).ToList();


                    });
                }
                else
                {
                    ListarTodosLosClientes._DataGridViewClientes.DataSource = Database.Main.clientes.Select(l => new {
                        l.nombreEmpresa,
                        l.fechaRegistro,
                        l.RUC
                    }).ToList();

                }

                ListarTodosLosClientes._DataGridViewClientes.Columns[0].HeaderText = "Nombre de la Empresa";
                ListarTodosLosClientes._DataGridViewClientes.Columns[1].HeaderText = "Fecha de Registro";
                ListarTodosLosClientes._DataGridViewClientes.Columns[2].HeaderText = "RUC";


            }
            catch (Exception ex)
            {
                if (ex is System.Data.Entity.Core.EntityCommandExecutionException || ex is System.InvalidOperationException)
                {
                    Console.WriteLine("Fail... Retrying clients...");
                    Thread.Sleep(600);
                    ActualizarTablaClientes();
                }

            }
            }, null);
        }


    }
}
