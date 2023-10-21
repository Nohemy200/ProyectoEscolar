using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosDeSeleccion.GUI
{
    public partial class BuscarApoderado : Form
    {
        BindingSource _APODERADOS = new BindingSource();

        public DataGridViewRow datosApoderadoEnviar;

        private void CargarDatos()
        {

            try
            {
                _APODERADOS.DataSource = DataManager.DBConsultas.APODERADOS();
                dtgvApoderado.DataSource = _APODERADOS;
                dtgvApoderado.AutoGenerateColumns = false;
                lblRegistros.Text = dtgvApoderado.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public BuscarApoderado()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dtgvApoderado.SelectedRows.Count != 0)
            {
                datosApoderadoEnviar = dtgvApoderado.CurrentRow;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un alumno.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BuscarApoderado_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

    }
}
