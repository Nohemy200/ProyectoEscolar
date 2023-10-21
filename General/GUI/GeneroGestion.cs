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
    public partial class GeneroGestion : Form
    {
        BindingSource _GENERO = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _GENERO.DataSource = DataManager.DBConsultas.GENERO();
                dtgvGenero.DataSource = _GENERO;
                dtgvGenero.AutoGenerateColumns = false;
                lblRegistros.Text = dtgvGenero.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public GeneroGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GeneroEdicion f = new GeneroEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GeneroEdicion f = new GeneroEdicion();
                f.txtIDGenero.Text = dtgvGenero.CurrentRow.Cells["idgenero"].Value.ToString();
                f.combGenero.Text = dtgvGenero.CurrentRow.Cells["genero"].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Genero oGenero = new CLS.Genero();
                oGenero.IDGenero = dtgvGenero.CurrentRow.Cells["IDGenero"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oGenero.Eliminar())
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

        private void GeneroGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
