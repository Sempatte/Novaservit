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
using Funda_Trabajo_Parcial.Validators;
using FluentValidation.Results;

namespace Funda_Trabajo_Parcial
{
    public partial class ModificarClientes : UserControl
    {
        DateTimePicker dtp  = new DateTimePicker();
        Rectangle _Rectangle;

        public static DataGridView _DataGridViewModificarCliente { get; set; }
        public static Label _LblErrorMessage { get; set; }
        public static Label _LblSuccess { get; set; }

        public void ActualizarCombobox()
        {
            ThreadPool.QueueUserWorkItem(delegate
            {
                List<cliente> Clientes = ControladorClientes.GetListaClientes();
                var BindingSourceCombobox = new BindingSource();
                BindingSourceCombobox.DataSource = Clientes;
                if (comboBoxListClientes.InvokeRequired) comboBoxListClientes.Invoke((MethodInvoker)delegate
                {
                    comboBoxListClientes.DataSource = BindingSourceCombobox.DataSource;
                    comboBoxListClientes.DisplayMember = "nombreEmpresa";
                    comboBoxListClientes.ValueMember = "nombreEmpresa";
                });
                


            }, null);
        }
        
        public ModificarClientes()
        {
            InitializeComponent();

            _DataGridViewModificarCliente = this.dataGridViewClienteEditables;
            _LblErrorMessage = this.lblMessageErrorModificarCliente;
            _LblSuccess = this.lblSuccessModificarCliente;

            _DataGridViewModificarCliente.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp__TextChange);

            ActualizarCombobox();

        }

        private void dtp__TextChange(Object sender, EventArgs e)
        {
            dataGridViewClienteEditables.CurrentCell.Value = dtp.Text.ToString();
        }

        private void comboBoxListClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente Cliente = (cliente)comboBoxListClientes.SelectedItem;
            Console.WriteLine(Cliente.nombreEmpresa);
            ControladorClientes.ActualizarDataModificableCliente(Cliente);
            
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            
            lblSuccessModificarCliente.Visible = false;
            cliente ClienteCombobox = (cliente)comboBoxListClientes.SelectedItem;
            string NuevoNombreEmpresa = dataGridViewClienteEditables.Rows[0].Cells[0].Value.ToString();
            DateTime NuevaFechaRegistro = Convert.ToDateTime(dataGridViewClienteEditables.Rows[0].Cells[1].Value.ToString());


            cliente clienteModificado = new cliente()
            {
                nombreEmpresa = NuevoNombreEmpresa,
                fechaRegistro = NuevaFechaRegistro,
                RUC = ClienteCombobox.RUC,
                proyectos = ClienteCombobox.proyectos
            };

            var validator = new ClientValidator();
            ValidationResult result = validator.Validate(clienteModificado);

            if (!result.IsValid)
            {
                lblMessageErrorModificarCliente.Visible = true;
                foreach (var error in result.Errors)
                {

                    lblMessageErrorModificarCliente.Text = error.ErrorMessage;
                }
                return;
            }

            ControladorClientes.GuardarDatosCliente(clienteModificado);
            lblSuccessModificarCliente.Visible = true;
            ActualizarCombobox();


        }

        private void ModificarClientes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewClienteEditables_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            switch(dataGridViewClienteEditables.Columns[e.ColumnIndex].Name)
            {
                case "ColumnFechaRegistro":
                    dtp.Value = Convert.ToDateTime(dataGridViewClienteEditables.Rows[0].Cells[1].Value.ToString());
                    _Rectangle = dataGridViewClienteEditables.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height);
                    dtp.Location = new Point(_Rectangle.X, _Rectangle.Y + 10);
                    dtp.Visible = true;
                    break;
                default:
                    dtp.Visible = false;
                    break;
            }
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {
            dtp.Visible = false;
        }
    }
}
    