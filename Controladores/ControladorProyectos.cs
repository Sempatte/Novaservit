using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Data.Entity;
using System.Windows.Forms;
using System.Globalization;

namespace Funda_Trabajo_Parcial
{
    class ControladorProyectos
    {
        public ControladorProyectos() { }


        public static List<proyecto> GetListaProyectos()
        {
            List<proyecto> Proyectos = new List<proyecto>();

            try
            {
                var userData = (from oData in Database.Main.proyectos
                                select oData);
                foreach (var proyecto in userData)
                {
                    proyecto _Proyecto = new proyecto();
                    _Proyecto.nombre = proyecto.nombre;
                    _Proyecto.id = proyecto.id;
                    _Proyecto.fecha_inicio = proyecto.fecha_inicio.Date;
                    _Proyecto.costo = proyecto.costo;
                    _Proyecto.idCliente = proyecto.idCliente;
                    _Proyecto.estado = proyecto.estado;
                    Proyectos.Add(_Proyecto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("GetListaProyectos() Retrying...");
                Thread.Sleep(600);
                GetListaProyectos();
            }


            return Proyectos;
        }

        public static void ActualizarTablaProyectos()
        {
            List<proyecto> ListProyectos = new List<proyecto>();


            ThreadPool.QueueUserWorkItem(delegate
            {
                var dataProyectos = (from oData in Database.Main.proyectos
                                     select oData).OrderBy(x => x.fecha_inicio);
                try
                {
                    foreach (var _proyecto in dataProyectos)
                    {
                        proyecto _tempProyecto = new proyecto();
                        _tempProyecto.id = _proyecto.id;
                        _tempProyecto.nombre = _proyecto.nombre;
                        _tempProyecto.fecha_inicio = _proyecto.fecha_inicio.Date;
                        _tempProyecto.costo = _proyecto.costo;
                        _tempProyecto.idCliente = _proyecto.idCliente;

                        ListProyectos.Add(_tempProyecto);
                    }
                    if (ListarProyectos._DataGridViewProyectos.InvokeRequired)
                    {

                        ListarProyectos._DataGridViewProyectos.Invoke((MethodInvoker)delegate
                        {
                            ListarProyectos._DataGridViewProyectos.DataSource = Database.Main.proyectos.Select(l => new
                            {
                                l.id,
                                l.nombre,
                                l.fecha_inicio,
                                l.costo,
                                l.idCliente,
                                l.estado
                            }).Where(a => a.estado == true).OrderBy(x => x.fecha_inicio).ToList();

                        });
                    }
                    else
                    {
                        ListarProyectos._DataGridViewProyectos.DataSource = Database.Main.proyectos.Select(l => new
                        {
                            l.id,
                            l.nombre,
                            l.fecha_inicio,
                            l.costo,
                            l.estado
                        }).Where(a => a.estado == true).OrderBy(x => x.fecha_inicio).ToList();

                    }

                    

                    ListarProyectos._DataGridViewProyectos.Columns[0].HeaderText = "ID";
                    ListarProyectos._DataGridViewProyectos.Columns[1].HeaderText = "Nombre";
                    ListarProyectos._DataGridViewProyectos.Columns[2].HeaderText = "Fecha de inicio";
                    ListarProyectos._DataGridViewProyectos.Columns[3].HeaderText = "Costo (S/.)";
                    ListarProyectos._DataGridViewProyectos.Columns[4].HeaderText = "RUC del Cliente";
                    ListarProyectos._DataGridViewProyectos.Columns[5].Visible = false;

                    ListarProyectos._DataGridViewProyectos.Columns[2].DefaultCellStyle.Format = "d";
                    ListarProyectos._DataGridViewProyectos.Columns[3].DefaultCellStyle.Format = "c2";
                    ListarProyectos._DataGridViewProyectos.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-PE");

                    foreach (DataGridViewColumn column in ListarProyectos._DataGridViewProyectos.Columns)
                    {

                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Retrying projects...");
                    Thread.Sleep(600);
                    ActualizarTablaProyectos();
                }
            }, null);
        }


        public static void ActualizarDataModificableProyectos(proyecto Proyecto)
        {
            ThreadPool.QueueUserWorkItem(delegate
            {
                try
                {
                    string estado;

                    if (Proyecto.estado == true) estado = "No finalizado";
                    else estado = "Finalizado";

                    if (ModificarProyectos._DataGridViewModificarProyecto.InvokeRequired)
                    {

                        ModificarProyectos._DataGridViewModificarProyecto.Invoke((MethodInvoker)delegate
                        {

                            ModificarProyectos._DataGridViewModificarProyecto.Rows.Clear();
                            ModificarProyectos._DataGridViewModificarProyecto.Rows.Add(Proyecto.nombre, Proyecto.fecha_inicio, Proyecto.costo, estado);
                        });
                    }
                    else
                    {
                        ModificarProyectos._DataGridViewModificarProyecto.Rows.Clear();
                        ModificarProyectos._DataGridViewModificarProyecto.Rows.Add(Proyecto.nombre, Proyecto.fecha_inicio, Proyecto.costo, estado);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("ActualizarDataModificableProyectos() Retrying...");
                    Thread.Sleep(600);
                    ActualizarDataModificableProyectos(Proyecto);
                }
            }, null);
        }

        public static void FinalizarProyecto(int idProyecto)
        {

            ListarProyectos._lblSuccess.Visible = false;
            ListarProyectos._lblError.Visible = false;
            try
            {
                var _Proyecto = Database.Main.proyectos.SingleOrDefault(u => u.id == idProyecto);
                _Proyecto.estado = false;
                Database.Main.SaveChanges();
                ListarProyectos._lblSuccess.Visible = true;
                ListarProyectos._lblSuccess.Text = "Proyecto finalizado con éxito.";
            }
            catch (Exception ex)
            {
                Console.WriteLine("FinalizarProyecto() retrying...");
                ListarProyectos._lblError.Visible = true;
                ListarProyectos._lblError.Text = ex.Message;
            }

        }

        public static void EditarProyecto(proyecto _proyectoEditado)
        {


            try
            {
                var Proyecto = Database.Main.proyectos.FirstOrDefault(s => s.id == _proyectoEditado.id);

                Proyecto.nombre = _proyectoEditado.nombre;
                Proyecto.fecha_inicio = _proyectoEditado.fecha_inicio;
                Proyecto.costo = _proyectoEditado.costo;
                Proyecto.estado = _proyectoEditado.estado;

                Database.Main.Entry(Proyecto).State = EntityState.Modified;
                Database.Main.SaveChanges();
                ModificarProyectos._LblSuccess.Visible = true;
            }
            catch (System.NullReferenceException ex)
            {
                ModificarProyectos._LblErrorMessage.Visible = true;
                ModificarProyectos._LblErrorMessage.Text = ex.Message.ToString();
            }
            catch (Exception ex)
            {
                ModificarProyectos._LblErrorMessage.Visible = true;
                ModificarProyectos._LblErrorMessage.Text = ex.Message.ToString();
            }



        }

    }
}
