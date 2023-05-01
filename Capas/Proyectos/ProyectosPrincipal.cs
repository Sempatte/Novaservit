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
    public partial class ProyectosPrincipal : Form
    {
        public ProyectosPrincipal()
        {
            InitializeComponent();
            MenuPrincipal._AreaLabel.Text = "Proyectos";
            ListarProyectos ListarProyectosUI = new ListarProyectos();
            addUserControl(ListarProyectosUI);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCentroProyectosMain.Controls.Clear();
            panelCentroProyectosMain.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            ListarProyectos ListarProyectosUI = new ListarProyectos();
            addUserControl(ListarProyectosUI);
        }

        private void btnModificarProyectos_Click(object sender, EventArgs e)
        {
            ModificarProyectos ModificarProyectosUI = new ModificarProyectos();
            addUserControl(ModificarProyectosUI);
        }

        private void panelCentroProyectosMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarProyectos_Click(object sender, EventArgs e)
        {
            AgregarProyectos AgregarProyectosUI = new AgregarProyectos();
            addUserControl(AgregarProyectosUI);
        }
    }
}
