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
    public partial class BuscarAlumno : Form
    {
        BindingSource _ALUMNOS = new BindingSource();
        public DataGridViewRow datosAlumnoEnviar;

        public void CargarDatos(bool activo)
        {
            if (activo)
            {
                try
                {
                    _ALUMNOS.DataSource = DataManager.DBConsultas.ALUMNOS_ACTIVOS();
                    dtgvAlumnos.DataSource = _ALUMNOS;
                    dtgvAlumnos.AutoGenerateColumns = false;
                    lblRegistros.Text = dtgvAlumnos.Rows.Count.ToString() + " Registros Encontrados";
                }
                catch (Exception)
                {

                }
            }
            else
            {
                try
                {
                    _ALUMNOS.DataSource = DataManager.DBConsultas.ALUMNOS_INACTIVOS();
                    dtgvAlumnos.DataSource = _ALUMNOS;
                    dtgvAlumnos.AutoGenerateColumns = false;
                    lblRegistros.Text = dtgvAlumnos.Rows.Count.ToString() + " Registros Encontrados";
                }
                catch (Exception)
                {

                }
            }
            
        }

        public BuscarAlumno()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dtgvAlumnos.SelectedRows.Count != 0)
            {
                datosAlumnoEnviar = dtgvAlumnos.CurrentRow;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un alumno.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BuscarAlumno_Load(object sender, EventArgs e)
        {
            
        }


       
    }
}
