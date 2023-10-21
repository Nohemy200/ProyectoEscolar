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
    public partial class EspecialidadGestion : Form
    {
        BindingSource _ESPECIALIDAD = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _ESPECIALIDAD.DataSource = DataManager.DBConsultas.ESPECIALIDAD();
                dtgvEspecialidad.DataSource = _ESPECIALIDAD;
                dtgvEspecialidad.AutoGenerateColumns = false;
                lblRegistros.Text = dtgvEspecialidad.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public EspecialidadGestion()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EspecialidadEdicion f = new EspecialidadEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EspecialidadEdicion f = new EspecialidadEdicion();
                f.txtIDEspecialidad.Text = dtgvEspecialidad.CurrentRow.Cells["idespecialidad"].Value.ToString();
                f.combEspecialidad.Text = dtgvEspecialidad.CurrentRow.Cells["especialidad"].Value.ToString();
                f.ShowDialog();
                CargarDatos();
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Especialidad oEspecialidad = new CLS.Especialidad();
                oEspecialidad.IDEspecialidad = dtgvEspecialidad.CurrentRow.Cells["IDEspecialidad"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oEspecialidad.Eliminar())
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

        private void EspecialidadGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
