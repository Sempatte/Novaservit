using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

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
        {
            try
            {
                proyecto proyectoEnCombobox = (proyecto)comboBoxListProyectos.SelectedItem;

                string NuevoNombreProyecto = dataGridViewProyectoEditables.Rows[0].Cells[0].Value.ToString();
                DateTime NuevaFechaInicio = Convert.ToDateTime(dataGridViewProyectoEditables.Rows[0].Cells[1].Value.ToString()).Date;
                decimal NuevoCosto = Convert.ToDecimal(dataGridViewProyectoEditables.Rows[0].Cells[2].Value.ToString().Replace("S/", "").Replace(",", ""));
                string NuevoEstado = dataGridViewProyectoEditables.Rows[0].Cells[3].Value.ToString();

                ControladorProyectos.EditarProyecto(proyectoEnCombobox.nombre, NuevoNombreProyecto, NuevaFechaInicio, NuevoCosto, NuevoEstado);
                ActualizarCombobox();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK);
            }

        }
    }
}
    