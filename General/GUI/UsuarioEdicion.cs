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
    public partial class UsuarioEdicion : Form
    {
        public UsuarioEdicion()
        {
            InitializeComponent();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            DocentesGestion f = new DocentesGestion();
            f.btnSeleccionar.Visible = true;
            var result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDocente.Text = f.DocenteEnviar;
                txtIdDocente.Text = f.IdEnviar;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Usuarios oUsuario = new CLS.Usuarios();

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("¡El usuario no puede quedar vacio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtContraseña.Text == "")
            {
                MessageBox.Show("¡Porfavor, debe establecer una clave!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtContraseña.Text.Length <= 2)
            {
                MessageBox.Show("¡La clave debe tener mas caracteres!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtIdRol.Text == "")
            {
                MessageBox.Show("Por favor, debe seleccionar un empleado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtIdDocente.Text == "")
            {
                MessageBox.Show("Por favor, debe seleccionar un rol!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                oUsuario.Usuario = txtUsuario.Text;
                oUsuario.Contraseña = txtContraseña.Text;
                oUsuario.IdRol = txtIdRol.Text;
                oUsuario.IdDocente = txtIdDocente.Text;

                if (txtIdUsuario.TextLength > 0)
                {
                    oUsuario.IdUsuario = txtIdUsuario.Text;
                    if (oUsuario.Actualizar())
                    {
                        MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("¡El registro no se actualizo correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    (bool resultadoBusqueda, bool resultadoInsercion) = oUsuario.Insertar();
                    if (resultadoBusqueda == false && resultadoInsercion == true)
                    {
                        MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else if (resultadoBusqueda == true && resultadoInsercion == false)
                    {
                        MessageBox.Show("¡Registro no se ha podido ingresar, el empleado ya tiene una cuenta!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("¡El registro no fue insertado correctamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            RolesGestion f = new RolesGestion();
            f.btnSeleccionar.Visible = true;
            var result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRol.Text = f.RolEnviar;
                txtIdRol.Text = f.IdEnviar;
            }
        }

    }
}
