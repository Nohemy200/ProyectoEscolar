﻿using System;
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
    }
}
