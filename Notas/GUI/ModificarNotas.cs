using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas.GUI
{
    public partial class ModificarNotas : Form
    {
        BindingSource _NOTAS = new BindingSource();

        public DataGridViewRow DatosAlumno { get; private set; }

        public ModificarNotas()
        {
            InitializeComponent();
        }

        private void CargarPeriodos()
        {
            DataTable periodos = new DataTable();
            try
            {
                periodos = DataManager.DBConsultas.CONSULTA_PERIODOS();
                combPeriodo.DataSource = periodos;
                combPeriodo.DisplayMember = "periodo";
                combPeriodo.ValueMember = "idperiodo";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarDatos()
        {
            String idalumno;
            String idperiodo;
            if (DatosAlumno != null)
            {
                idalumno = DatosAlumno.Cells["idalumno"].Value.ToString();
                idperiodo = "1";
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN ALUMNO", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            idperiodo = combPeriodo.SelectedValue.ToString();
            try
            {
                _NOTAS.DataSource = DataManager.DBConsultas.NOTAS_POR_ALUMNO_EN_PERIODO(idalumno, idperiodo);
                dgvNotas.DataSource = _NOTAS;
                dgvNotas.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

            }
        }

        private void combPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void ModificarNotas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            if (dgvNotas.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro que desea cambiar de alumno? Los datos ya establecidos se perderan", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtNie.Text = "";
                    txtNombre.Text = "";
                    FormulariosDeSeleccion.GUI.BuscarAlumno f = new FormulariosDeSeleccion.GUI.BuscarAlumno();
                    f.CargarDatos(true);
                    f.btnSeleccionar.Visible = true;
                    f.ShowDialog();
                    DatosAlumno = f.datosAlumnoEnviar;
                    if (DatosAlumno != null)
                    {
                        txtNie.Text = DatosAlumno.Cells["nie"].Value.ToString();
                        txtNombre.Text = DatosAlumno.Cells["nombres"].Value.ToString();
                    }
                }
            }
            else
            {
                txtNie.Text = "";
                txtNombre.Text = "";
                FormulariosDeSeleccion.GUI.BuscarAlumno f = new FormulariosDeSeleccion.GUI.BuscarAlumno();
                f.CargarDatos(true);
                f.btnSeleccionar.Visible = true;
                f.ShowDialog();
                DatosAlumno = f.datosAlumnoEnviar;
                if (DatosAlumno != null)
                {
                    txtNie.Text = DatosAlumno.Cells["nie"].Value.ToString();
                    txtNombre.Text = DatosAlumno.Cells["nombres"].Value.ToString();
                }
            }
            CargarPeriodos();
            CargarDatos();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (dgvNotas.Rows.Count>0)
            {
                EditarNotas f = new EditarNotas();
                f.txtIdAlumno.Text = DatosAlumno.Cells["idalumno"].Value.ToString();
                f.txtIdPeriodo.Text = dgvNotas.CurrentRow.Cells["idperiodo"].Value.ToString();
                f.txtIdNota.Text = dgvNotas.CurrentRow.Cells["idnota"].Value.ToString();
                f.txtPeriodo.Text = dgvNotas.CurrentRow.Cells["periodo"].Value.ToString();
                f.txtNombre.Text = DatosAlumno.Cells["nombres"].Value.ToString();
                f.txtIdMateria.Text = dgvNotas.CurrentRow.Cells["idmateria"].Value.ToString();
                f.txtMateria.Text = dgvNotas.CurrentRow.Cells["materia"].Value.ToString();
                f.txtNota.Text = dgvNotas.CurrentRow.Cells["nota"].Value.ToString();
                f.ShowDialog();
            }
            CargarDatos();

        }
    }
}
