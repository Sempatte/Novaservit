using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using Funda_Trabajo_Parcial.Validators;
using FluentValidation.Results;

namespace Funda_Trabajo_Parcial
{
    public partial class ModificarProyectos : UserControl
    {
        public static DataGridView _DataGridViewModificarProyecto { get; set; }
        public static Label _LblErrorMessage { get; set; }
        public static Label _LblSuccess { get; set; }

        public void ActualizarCombobox()
        {
            ThreadPool.QueueUserWorkItem(delegate
            {
                List<proyecto> Proyectos = ControladorProyectos.GetListaProyectos();

                var BindingSourceCombobox = new BindingSource();
                BindingSourceCombobox.DataSource = Proyectos;
                if (comboBoxListProyectos.InvokeRequired) comboBoxListProyectos.Invoke((MethodInvoker)delegate
                {
                    comboBoxListProyectos.DataSource = BindingSourceCombobox.DataSource;
                    comboBoxListProyectos.DisplayMember = "nombre";
                    comboBoxListProyectos.ValueMember = "nombre";
                });
                else
                {
                    comboBoxListProyectos.DataSource = BindingSourceCombobox.DataSource;
                    comboBoxListProyectos.DisplayMember = "nombre";
                    comboBoxListProyectos.ValueMember = "nombre";
                }
            }, null);
        }
        
        public ModificarProyectos()
        {
            InitializeComponent();
            _DataGridViewModificarProyecto = this.dataGridViewProyectoEditables;
            _LblErrorMessage = this.lblMessageErrorModificarProyecto;
            _LblSuccess = this.lblSuccessModificarProyecto;
            dataGridViewProyectoEditables.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-PE");

            ActualizarCombobox();

        }


        private void ModificarClientes_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxListProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            proyecto Proyecto  = (proyecto)comboBoxListProyectos.SelectedItem;
            ControladorProyectos.ActualizarDataModificableProyectos(Proyecto);
        }

        private void btnGuardarDatosProyecto_Click(object sender, EventArgs e)
        {   lblMessageErrorModificarProyecto.Visible = false;
            _LblSuccess.Visible = false;
            try
            {
                proyecto proyectoEnCombobox = (proyecto)comboBoxListProyectos.SelectedItem;

                string NuevoNombreProyecto = dataGridViewProyectoEditables.Rows[0].Cells[0].Value.ToString();
                DateTime NuevaFechaInicio = Convert.ToDateTime(dataGridViewProyectoEditables.Rows[0].Cells[1].Value.ToString()).Date;
                decimal NuevoCosto = Convert.ToDecimal(dataGridViewProyectoEditables.Rows[0].Cells[2].Value.ToString().Replace("S/", "").Replace(",", ""));
                string NuevoEstado = dataGridViewProyectoEditables.Rows[0].Cells[3].Value.ToString();

                var proyectoAModificar = new proyecto()
                {
                    id = proyectoEnCombobox.id,
                    cliente = proyectoEnCombobox.cliente,
                    nombre = NuevoNombreProyecto,
                    fecha_inicio = NuevaFechaInicio,
                    costo = NuevoCosto,
                    estado = NuevoEstado == "Finalizado" ? false : true
                };

                var validator = new ProjectValidator();
                ValidationResult result = validator.Validate(proyectoAModificar);

                if (!result.IsValid)
                {
                    lblMessageErrorModificarProyecto.Visible = true;
                    foreach (var error in result.Errors)
                    {

                        lblMessageErrorModificarProyecto.Text = error.ErrorMessage;
                    }
                    return;
                }

                ControladorProyectos.EditarProyecto(proyectoAModificar);
                ActualizarCombobox();
            } catch(Exception ex)
            {
                if (ex.Message.Contains("DateTime válido"))
                {
                    MessageBox.Show("Fecha con formato invalido", "Alerta", MessageBoxButtons.OK);
                } else
                {
                    MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
                }
                
            }

        }
    }
}
    