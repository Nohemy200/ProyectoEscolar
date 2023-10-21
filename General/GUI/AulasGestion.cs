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
    public partial class AulasGestion : Form
    {
        BindingSource _AULAS = new BindingSource();

        public string AulaEnviar { get; private set; }

        public string idEnviar { get; private set; }

        private void CargarDatos()
        {
            try
            {
                _AULAS.DataSource = DataManager.DBConsultas.AULAS();
                dtgvAulas.DataSource = _AULAS;
                dtgvAulas.AutoGenerateColumns = false;
                lblRegistros.Text = dtgvAulas.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public AulasGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AulasEdicion f = new AulasEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AulasEdicion f = new AulasEdicion();
                f.txtIDAula.Text = dtgvAulas.CurrentRow.Cells["idaula"].Value.ToString();
                f.txtNumAula.Text = dtgvAulas.CurrentRow.Cells["numeroaula"].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void AulasGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Aulas oAulas = new CLS.Aulas();
                oAulas.IDAula = dtgvAulas.CurrentRow.Cells["IDAula"].Value.ToString().ToUpper(); ;
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

        private void dtgvAulas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            AulaEnviar = dtgvAulas.CurrentRow.Cells["numeroaula"].Value.ToString();
            idEnviar = dtgvAulas.CurrentRow.Cells["idaula"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
