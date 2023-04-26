using System;

using System.Windows.Forms;


namespace Funda_Trabajo_Parcial
{
    public partial class ListarProyectos : UserControl
    {
        public static DataGridView _DataGridViewProyectos { get; set; }
        public static Label _lblSuccess { get; set; }
        public static Label _lblError { get; set; }

        public ListarProyectos()
        {
            InitializeComponent();
            _DataGridViewProyectos = this.dataGridViewProyectos;
            _lblSuccess = this.lblSuccessProyectos;
            _lblError = this.lblMessageErrorProyectos;

            ControladorProyectos.ActualizarTablaProyectos();
        }

        private void btnFinalizarProyecto_Click(object sender, EventArgs e)
        {
            int IDSELECT = int.Parse(dataGridViewProyectos.Rows[dataGridViewProyectos.CurrentCell.RowIndex].Cells[0].Value.ToString());
            ControladorProyectos.FinalizarProyecto(IDSELECT);
            ControladorProyectos.ActualizarTablaProyectos();
        }

        private void btnActualizarProyectos_Click(object sender, EventArgs e)
        {
            ControladorProyectos.ActualizarTablaProyectos();
        }

        void dataGridViewProyectos_MouseWheel(object sender, MouseEventArgs e)
        {
            int currentIndex = dataGridViewProyectos.FirstDisplayedScrollingRowIndex;
            int scrollLines = SystemInformation.MouseWheelScrollLines;

            if (e.Delta > 0)
            {
                dataGridViewProyectos.FirstDisplayedScrollingRowIndex
                    = Math.Max(0, currentIndex - scrollLines);
            }
            else if (e.Delta < 0)
            {
                dataGridViewProyectos.FirstDisplayedScrollingRowIndex
                    = currentIndex + scrollLines;
            }
        }
    }
}
