using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;
using Funda_Trabajo_Parcial.Validators;
using FluentValidation.Results;

namespace Funda_Trabajo_Parcial
{
    public partial class AgregarClientes : UserControl
    {
        public AgregarClientes()
        {
            InitializeComponent();

        }


   

        private void txtboxNombreEmpresa_KeyUp(object sender, KeyEventArgs e)
        {
            //lblClienteEmpresa.Text = txtboxNombreEmpresa.Text;
        }

        private void txtboxNombreProyecto_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtboxRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            //// If you want, you can allow decimal (float) numbers
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        public void ClearTextBoxes(ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        private void btnAgregarDatos_Click(object sender, EventArgs e)
        {
            lblMessageErrorClienteAgregado.Visible = false;  
            lblSuccessClienteAgregado.Visible = false;
            
            string nombre_empresa_cliente = txtboxNombreEmpresa.Text;
            long RUC_parsed;
            long.TryParse(txtboxRUC.Text, out RUC_parsed);
            //string nombre_proyecto = txtboxNombreProyecto.Text;   
            //DateTime fechaInicio = datepickerFechaInicio.Value.Date;

            var newClient = new cliente()
            {
                fechaRegistro = DateTime.Now,
                nombreEmpresa = nombre_empresa_cliente,
                RUC = RUC_parsed,
            };

            var validator = new ClientValidator();
            ValidationResult result = validator.Validate(newClient);

            if (!result.IsValid)
            {
                Console.WriteLine("Client invalid");
                lblMessageErrorClienteAgregado.Visible = true;
                foreach (var error in result.Errors)
                {
                    Console.WriteLine("1", error.ErrorMessage);
                    lblMessageErrorClienteAgregado.Text = error.PropertyName + " " +  error.ErrorMessage;
                }
                return;
            }

            
            ControladorClientes.AddCliente(newClient);
            lblSuccessClienteAgregado.Visible = true;

        

        }

        private void lblClienteEmpresa_Click(object sender, EventArgs e)
        {

        }
    }
}
