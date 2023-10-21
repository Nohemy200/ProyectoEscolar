using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriculas.GUI
{
    public partial class BuscarMatricula : Form
    {
        BindingSource _BUSCAR = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _BUSCAR.DataSource = DataManager.DBConsultas.BUSCAR_MATERIAS_POR_ALUMNO(txtNie.Text);
                dgvMaterias.DataSource = _BUSCAR;
                dgvMaterias.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

            }
        }

        public BuscarMatricula()
        {
            InitializeComponent();
        }

        private void BuscarMatricula_Load(object sender, EventArgs e)
        {

        }

        private void txtNie_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
            if(dgvMaterias.Rows.Count > 0)
            {
                
                
                    DataGridViewCell cell = dgvMaterias.Rows[0].Cells[8];
                    // Obtenemos el valor de la celda
                    txtNombres.Text= cell.Value.ToString();

                DataGridViewCell cell2 = dgvMaterias.Rows[0].Cells[9];
                // Obtenemos el valor de la celda
                txtApellidos.Text = cell2.Value.ToString();



            }
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            General.GUI.AlumnoGestion f = new General.GUI.AlumnoGestion();
            f.MdiParent = this.MdiParent;
            f.Show();

        }
    }
}
