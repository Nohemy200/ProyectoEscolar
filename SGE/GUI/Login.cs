using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.GUI
{
    public partial class Login : Form
    {
        Boolean autorizado = false;
        SessionManager.Session oSesion = SessionManager.Session.Instancia;
        public bool Autorizado{get =>autorizado;}


        public Login()
        {
            InitializeComponent();
            // Asociar el evento Click del botón btnMostrarContra al método btnMostrarContra_Click
            btnMostrarContra.Click += btnMostrarContra_Click;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "noemi";
            txtClave.Text = "123";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validacion = false;
            if (txtClave.Text.Length == 0)
            {
                validacion = true;
            }
            if (txtUsuario.Text.Length == 0)
            {
                validacion = true;
            }

            if (!validacion)
            {
                if (oSesion.IniciarSesion(txtUsuario.Text, txtClave.Text))
                {
                    autorizado = true;
                    Close();
                }
                else
                {
                    autorizado = false;
                    MessageBox.Show("Datos incorrectos");
                    txtClave.Focus();
                    txtClave.SelectAll();
                }

            }
            else
            {
                MessageBox.Show("Debe llenar los campos Usuario y Contraseña");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void btnMostrarContra_Click(object sender, EventArgs e)
        {
            // Cambiar el carácter de contraseña a texto normal y viceversa
            if (txtClave.PasswordChar == '\0')
            {
                // La contraseña se está mostrando, así que la ocultamos
                txtClave.PasswordChar = '*'; // o cualquier carácter que prefieras para ocultar la contraseña
            }
            else
            {
                // La contraseña está oculta, así que la mostramos
                txtClave.PasswordChar = '\0'; // '\0' indica que no se mostrará ningún carácter especial
            }
        }


    }

    /*private void LimpiarCampos()
    {
        txtUsuario.Text = string.Empty;
        txtClave.Text = string.Empty;
        // Coloca el foco en el primer TextBox después de limpiar los campos
        txtUsuario.Focus();
    }
    */
}

