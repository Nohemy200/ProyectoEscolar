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
    public partial class DocentesGestion : Form
    {
        BindingSource _DOCENTES = new BindingSource();


        public string DocenteEnviar { get; internal set; }
        public string IdEnviar { get; internal set; }

        private void CargarDatos()
        {
            try
            {
                _DOCENTES.DataSource = DataManager.DBConsultas.DOCENTES();
                dtgvDocentes.DataSource = _DOCENTES;
                dtgvDocentes.AutoGenerateColumns = false;
                lblRegistros.Text = dtgvDocentes.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public DocentesGestion()
        {
            InitializeComponent();
        }

        private void DocentesGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DocentesEdicion f = new DocentesEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DocentesEdicion f = new DocentesEdicion();
                f.txtIdDocente.Text = dtgvDocentes.CurrentRow.Cells["iddocente"].Value.ToString();
                f.txtNombresDocente.Text = dtgvDocentes.CurrentRow.Cells["nombresdocente"].Value.ToString();
                f.txtApellidosDocente.Text = dtgvDocentes.CurrentRow.Cells["apellidosdocente"].Value.ToString();
                f.txtDuii.Text = dtgvDocentes.CurrentRow.Cells["dui"].Value.ToString();
                f.txtTelefono.Text = dtgvDocentes.CurrentRow.Cells["telefono"].Value.ToString();
                f.dtpFecha.Text = dtgvDocentes.CurrentRow.Cells["fechanacimiento"].Value.ToString();
                f.idReferenciaEsp = Int32.Parse(dtgvDocentes.CurrentRow.Cells["idespecialidad"].Value.ToString());
                f.idReferenciaEst = Int32.Parse(dtgvDocentes.CurrentRow.Cells["idestado"].Value.ToString());
                f.idReferenciaGen = Int32.Parse(dtgvDocentes.CurrentRow.Cells["idgenero"].Value.ToString());
                f.txtIdDireccion.Text = dtgvDocentes.CurrentRow.Cells["direccion"].Value.ToString();
                

                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Docentes oDocentes = new CLS.Docentes();
                oDocentes.IdDocente = dtgvDocentes.CurrentRow.Cells["iddocente"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oDocentes.Eliminar())
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DocenteEnviar = dtgvDocentes.CurrentRow.Cells["nombresdocente"].Value.ToString();
            IdEnviar = dtgvDocentes.CurrentRow.Cells["iddocente"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
