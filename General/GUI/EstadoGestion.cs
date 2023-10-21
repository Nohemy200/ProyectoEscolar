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
    public partial class EstadoGestion : Form
    {
        BindingSource _ESTADO = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _ESTADO.DataSource = DataManager.DBConsultas.ESTADO();
                dtgvEstado.DataSource = _ESTADO;
                dtgvEstado.AutoGenerateColumns = false;
                lblRegistros.Text = dtgvEstado.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public EstadoGestion()
        {
            InitializeComponent();
        }

        private void EstadoGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EstadoEdicion f = new EstadoEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EstadoEdicion f = new EstadoEdicion();
                f.txtIDEstado.Text = dtgvEstado.CurrentRow.Cells["idestado"].Value.ToString();
                f.combEstado.Text = dtgvEstado.CurrentRow.Cells["estado"].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Estado oAulas = new CLS.Estado();
                oAulas.IDEstado = dtgvEstado.CurrentRow.Cells["IDEstado"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oAulas.Eliminar())
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

        private void dtgvEstado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
