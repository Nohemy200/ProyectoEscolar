using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class AlumnoGestion : Form
    {
        BindingSource _ALUMNOS = new BindingSource();
        public string alumnoEnviar { get; set; }
        public string idEnviar { get; set; }

        private void CargarDatos()
        {
            try
            {
                _ALUMNOS.DataSource = DataManager.DBConsultas.ALUMNOS();
                dtgvAlumnos.DataSource = _ALUMNOS;
                dtgvAlumnos.AutoGenerateColumns = false;
                lblRegistros.Text = dtgvAlumnos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public AlumnoGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AlumnoEdicion f = new AlumnoEdicion();
            f.ShowDialog();
            CargarDatos();
         
        }

        private void AlumnoGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AlumnoEdicion f = new AlumnoEdicion();
                f.txtIDAlumno.Text = dtgvAlumnos.CurrentRow.Cells["idalumno"].Value.ToString();
                f.txtNie.Text = dtgvAlumnos.CurrentRow.Cells["nie"].Value.ToString();
                f.txtNombres.Text = dtgvAlumnos.CurrentRow.Cells["nombres"].Value.ToString();
                f.txtApellidos.Text = dtgvAlumnos.CurrentRow.Cells["apellidos"].Value.ToString();
                f.dtpFecha.Text = dtgvAlumnos.CurrentRow.Cells["fechanacimiento"].Value.ToString();
                f.txtTelefono.Text = dtgvAlumnos.CurrentRow.Cells["telefono"].Value.ToString();
                f.idReferenciaEst = Int32.Parse(dtgvAlumnos.CurrentRow.Cells["idestado"].Value.ToString());
                f.idReferenciaGen = Int32.Parse(dtgvAlumnos.CurrentRow.Cells["idgenero"].Value.ToString());
                f.lblEstado.Visible = true;
                f.combEstado.Visible = true;

                f.txtIdApoderado.Text = dtgvAlumnos.CurrentRow.Cells["idapoderado"].Value.ToString();
                f.txtApoderado.Text = dtgvAlumnos.CurrentRow.Cells["nombresapoderado"].Value.ToString();
                f.txtIdDireccion.Text = dtgvAlumnos.CurrentRow.Cells["direccion"].Value.ToString();


                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Alumnos oAlumnos = new CLS.Alumnos();
                oAlumnos.IdAlumno = dtgvAlumnos.CurrentRow.Cells["idalumno"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oAlumnos.Eliminar())
                {
                    MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue eliminado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            alumnoEnviar = dtgvAlumnos.CurrentRow.Cells["nombres"].Value.ToString();
            idEnviar = dtgvAlumnos.CurrentRow.Cells["idalumno"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
