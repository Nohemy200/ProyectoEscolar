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
    public partial class MateriasGradosGestion : Form
    {
        BindingSource _MATERIAS_GRADOS = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _MATERIAS_GRADOS.DataSource = DataManager.DBConsultas.MATERIAS_GRADOS();
                dtgvMateriaGrado.DataSource = _MATERIAS_GRADOS;
                dtgvMateriaGrado.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

            }
        }
        public MateriasGradosGestion()
        {
            InitializeComponent();
        }

        private void MateriasGradosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MateriasGradosEdicion f = new MateriasGradosEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MateriasGradosEdicion f = new MateriasGradosEdicion();
                f.txtIDMateriaGrado.Text = dtgvMateriaGrado.CurrentRow.Cells["idmateriasgrados"].Value.ToString();
                f.idReferenciaGra = Int32.Parse(dtgvMateriaGrado.CurrentRow.Cells["idgrado"].Value.ToString());
                f.idReferenciaMat = Int32.Parse(dtgvMateriaGrado.CurrentRow.Cells["idmateria"].Value.ToString());
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.MateriasGrados oMG = new CLS.MateriasGrados();
                oMG.IdMateriaGrado = dtgvMateriaGrado.CurrentRow.Cells["idmateriasgrados"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oMG.Eliminar())
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
