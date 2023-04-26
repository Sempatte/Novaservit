using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funda_Trabajo_Parcial
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            MenuPrincipal._AreaLabel.Text = "Clientes";
            ListarTodosLosClientes ListarClientesUI = new ListarTodosLosClientes();
            addUserControl(ListarClientesUI);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCentroClientesMain.Controls.Clear();
            panelCentroClientesMain.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            ListarTodosLosClientes ListarClientesUI = new ListarTodosLosClientes();
            addUserControl(ListarClientesUI);
        }



        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            AgregarClientes AgregarClientesUI = new AgregarClientes();
            addUserControl(AgregarClientesUI);
        }

        private void btnModificarClientes_Click(object sender, EventArgs e)
        {
            ModificarClientes ModificarClientesUI = new ModificarClientes();
            addUserControl(ModificarClientesUI);
        }
    }
}
