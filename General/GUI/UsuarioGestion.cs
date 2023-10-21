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
    public partial class UsuarioGestion : Form
    {
        BindingSource _USUARIOS = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _USUARIOS.DataSource = DataManager.DBConsultas.USUARIOS();
                dtgvUsuario.DataSource = _USUARIOS;
                dtgvUsuario.AutoGenerateColumns = false;
                lblRegistros.Text = dtgvUsuario.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public UsuarioGestion()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UsuarioEdicion f = new UsuarioEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void UsuarioGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioEdicion f = new UsuarioEdicion();
                f.txtIdUsuario.Text = dtgvUsuario.CurrentRow.Cells["id"].Value.ToString();
                f.txtUsuario.Text = dtgvUsuario.CurrentRow.Cells["usuario"].Value.ToString();
                f.txtContraseña.Text = dtgvUsuario.CurrentRow.Cells["password"].Value.ToString();
                f.txtIdRol.Text = dtgvUsuario.CurrentRow.Cells["idrol"].Value.ToString();
                f.txtRol.Text = dtgvUsuario.CurrentRow.Cells["rol"].Value.ToString();
                f.txtIdDocente.Text = dtgvUsuario.CurrentRow.Cells["iddocente"].Value.ToString();
                f.txtDocente.Text = dtgvUsuario.CurrentRow.Cells["nombresdocente"].Value.ToString();


                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Usuarios oUsuario = new CLS.Usuarios();
                oUsuario.IdUsuario = dtgvUsuario.CurrentRow.Cells["id"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oUsuario.Eliminar())
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
