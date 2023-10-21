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
    public partial class MateriaGestion : Form
    {
        BindingSource _MATERIAS = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _MATERIAS.DataSource = DataManager.DBConsultas.MATERIAS();
                dtgvMateria.DataSource = _MATERIAS;
                dtgvMateria.AutoGenerateColumns = false;
                lblRegistros.Text = dtgvMateria.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public MateriaGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MateriaEdicion f = new MateriaEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MateriaEdicion f = new MateriaEdicion();
                f.txtIDMateria.Text = dtgvMateria.CurrentRow.Cells["idmateria"].Value.ToString();
                f.txtMateria.Text = dtgvMateria.CurrentRow.Cells["materia"].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Materias oMateria = new CLS.Materias();
                oMateria.IDMateria = dtgvMateria.CurrentRow.Cells["IDMateria"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oMateria.Eliminar())
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

        private void MateriaGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
