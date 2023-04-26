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


        private void txtboxPrice_Validating(object sender, CancelEventArgs e)
        {
            string value;
            NumberStyles style;
            CultureInfo culture;
            decimal currency;

            value = txtboxPrice.Text;
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("es-PE");
            if (!Decimal.TryParse(value, style, culture, out currency))
            {
                MessageBox.Show("Coloca una cantidad valida.", "Cantidad invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // prevent the textbox from losing focus
                e.Cancel = true;
            }
        }

        private void txtboxPrice_Validated(object sender, EventArgs e)
        {
            string input = txtboxPrice.Text.Trim();
            if (input.StartsWith("$"))
            {
                string temp = input.Replace("$", "");
                string specifier = "C";
                CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
                txtboxPrice.Text = Decimal.Parse(temp).ToString(specifier, culture);
            }
        }

        private void txtboxNombreEmpresa_KeyUp(object sender, KeyEventArgs e)
        {
            lblClienteEmpresa.Text = txtboxNombreEmpresa.Text;
        }

        private void txtboxNombreProyecto_KeyUp(object sender, KeyEventArgs e)
        {
            lblNombreProyecto.Text = txtboxNombreProyecto.Text;
        }

        private void txtboxRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
            
            lblSuccessClienteAgregado.Visible = false;
            lblMessageErrorClienteAgregado.Visible = false;
            string nombre_empresa_cliente = txtboxNombreEmpresa.Text;
            long RUC_parsed;
            long.TryParse(txtboxRUC.Text, out RUC_parsed);
            string nombre_proyecto = txtboxNombreProyecto.Text;   
            DateTime fechaInicio = datepickerFechaInicio.Value.Date;

            var nuevoCliente = new cliente()
            {
                fechaRegistro = fechaInicio,
                nombreEmpresa = nombre_empresa_cliente,
                RUC = RUC_parsed,
            };

            var validator = new ClientValidator();
            ValidationResult result = validator.Validate(nuevoCliente);

            if (!result.IsValid)
            {
                lblMessageErrorClienteAgregado.Visible = true;
                foreach (var error in result.Errors)
                {

                    lblMessageErrorClienteAgregado.Text = error.ErrorMessage;
                }
                return;
            }

            //if(string.IsNullOrEmpty(nombre_empresa_cliente) || string.IsNullOrEmpty(RUC) || string.IsNullOrEmpty(nombre_proyecto) || string.IsNullOrEmpty(txtboxPrice.Text.ToString()))
            //{
            //    //MessageBox.Show("Llene todos los campos.", "Alerta", MessageBoxButtons.OK);
            //    lblMessageErrorClienteAgregado.Visible = true;
            //    lblMessageErrorClienteAgregado.Text = "Llene todos los campos.";
            //    return;
            //}

            //if (RUC.ToString().Length != 11) {
            //    //MessageBox.Show("Inserte un RUC válido.", "Alerta", MessageBoxButtons.OK);
            //    lblMessageErrorClienteAgregado.Visible = true;
            //    lblMessageErrorClienteAgregado.Text = "Inserte un RUC válido.";
            //    return;
            //}
            
            decimal costo_proyecto = decimal.Parse(txtboxPrice.Text);

            var response = ControladorClientes.AddProjectAndClient(nombre_empresa_cliente, RUC_parsed, nombre_proyecto, costo_proyecto, fechaInicio);
            if (response.Length > 0){
                lblSuccessClienteAgregado.Visible = false;
                lblMessageErrorClienteAgregado.Visible = true;
                lblMessageErrorClienteAgregado.Text = response;
            }
            else
            {
                lblSuccessClienteAgregado.Visible = true;

                lblMessageErrorClienteAgregado.Visible = false;
                ClearTextBoxes(this.Controls);
                lblClienteEmpresa.Text = "";
                lblNombreProyecto.Text = "";
            }
        }
    }
}
