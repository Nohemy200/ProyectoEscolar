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
    public partial class GradosGestion : Form
    {
        BindingSource _GRADOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _GRADOS.DataSource = DataManager.DBConsultas.CONSULTA_GRADOS();
                dtgvGrado.DataSource = _GRADOS;
                dtgvGrado.AutoGenerateColumns = false;
                lblRegistros.Text = dtgvGrado.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public GradosGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GradosEdicion f = new GradosEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void GradosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GradosEdicion f = new GradosEdicion();
                f.txtIdGrado.Text = dtgvGrado.CurrentRow.Cells["idgrado"].Value.ToString();
                f.combGrado.Text = dtgvGrado.CurrentRow.Cells["grado"].Value.ToString();
                f.txtIdAula.Text = dtgvGrado.CurrentRow.Cells["idaula"].Value.ToString();
                f.txtAula.Text = dtgvGrado.CurrentRow.Cells["numeroaula"].Value.ToString();
                f.txtIdDocente.Text = dtgvGrado.CurrentRow.Cells["iddocente"].Value.ToString();
                f.txtDocente.Text = dtgvGrado.CurrentRow.Cells["nombresdocente"].Value.ToString();


                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Grados oGrado = new CLS.Grados();
                oGrado.IdGrado = dtgvGrado.CurrentRow.Cells["idgrado"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oGrado.Eliminar())
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
    }
}
