using System;

using System.Windows.Forms;

namespace Funda_Trabajo_Parcial
{
    public partial class ListarTodosLosClientes : UserControl
    {
        public static DataGridView _DataGridViewClientes { get; set; }

        public ListarTodosLosClientes()
        {
            InitializeComponent();
            _DataGridViewClientes = this.dataGridViewClientes;
            ControladorClientes.ActualizarTablaClientes();
        }

    

        void dataGridViewClientes_MouseWheel(object sender, MouseEventArgs e)
        {
            int currentIndex = dataGridViewClientes.FirstDisplayedScrollingRowIndex;
            int scrollLines = SystemInformation.MouseWheelScrollLines;

            if (e.Delta > 0)
            {
                dataGridViewClientes.FirstDisplayedScrollingRowIndex
                    = Math.Max(0, currentIndex - scrollLines);
            }
            else if (e.Delta < 0)
            {
                dataGridViewClientes.FirstDisplayedScrollingRowIndex
                    = currentIndex + scrollLines;
            }
        }

    }
}
