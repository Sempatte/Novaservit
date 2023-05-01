using FluentValidation.Results;
using Funda_Trabajo_Parcial.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;


namespace Funda_Trabajo_Parcial
{
    public partial class AgregarProyectos : UserControl
    {
        public static DataGridView _DataGridViewProyectos { get; set; }
        public static Label _lblSuccess { get; set; }
        public static Label _lblError { get; set; }

        public AgregarProyectos()
        {
            InitializeComponent();
            List<cliente> Clientes = ControladorClientes.GetListaClientes();
            var BindingSourceCombobox = new BindingSource();
            BindingSourceCombobox.DataSource = Clientes;

            comboboxClientes.DataSource = BindingSourceCombobox.DataSource;
            comboboxClientes.DisplayMember = "nombreEmpresa";
            comboboxClientes.ValueMember = "nombreEmpresa";
            
        }

  

        private void btnActualizarProyectos_Click(object sender, EventArgs e)
        {

        }

        
        private void dataGridViewProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void comboboxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente Cliente = (cliente)comboboxClientes.SelectedItem;
            Console.WriteLine(Cliente.nombreEmpresa);
            //ControladorClientes.ActualizarDataModificableCliente(Cliente);
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


        private void btnAgregarDatos_Click(object sender, EventArgs e)
        {
            lblMessageErrorProyectos.Visible = false;
            lblSuccessProyectos.Visible = false;
            cliente ClienteCombobox = (cliente)comboboxClientes.SelectedItem;

            decimal priceParsed;
            decimal.TryParse(txtboxPrice.Text, out priceParsed);
            string nombre_proyecto = txtboxNombreProyecto.Text;   
            DateTime fechaInicio = datepickerFechaInicio.Value.Date;


            proyecto newProject = new proyecto()
            {
                idCliente = ClienteCombobox.RUC,
                costo = priceParsed,
                fecha_inicio = fechaInicio,
                nombre = nombre_proyecto,
                estado = true
            };

            var validatorProject = new ProjectValidator();
            ValidationResult result2 = validatorProject.Validate(newProject);

            if (!result2.IsValid)
            {
                Console.WriteLine("Project invalid");
                lblMessageErrorProyectos.Visible = true;
                foreach (var error in result2.Errors)
                {
                    Console.WriteLine("2", error.ErrorMessage);
                    lblMessageErrorProyectos.Text = error.ErrorMessage;
                }
                return;
            }

            ControladorProyectos.AgregarProyecto(newProject);


            lblSuccessProyectos.Visible = true;

            ClearTextBoxes(this.Controls);
            //lblClienteEmpresa.Text = "";
        }
    }
}
