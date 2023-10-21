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
    public partial class GradosEdicion : Form
    {
        

        public GradosEdicion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Grados oGrados = new CLS.Grados();
            //Sincronizar la entidad con la interfaz
            oGrados.Grado = combGrado.Text;
            oGrados.IdAula = txtIdAula.Text;
            oGrados.IdDocente = txtIdDocente.Text;



            //Identificar la accion a realizar
            if (txtIdGrado.TextLength > 0)
            {
                oGrados.IdGrado = txtIdGrado.Text;
                //Realizar la operacion de actualizar
                if (oGrados.Actualizar())
                {
                    MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue actualizado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Realizar la operacion de insertar
                if (oGrados.Insertar())
                {
                    MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue insertado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            AulasGestion f = new AulasGestion();
            f.btnSeleccionar.Visible = true;
            var result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtAula.Text = f.AulaEnviar;
                txtIdAula.Text = f.idEnviar;
            }
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

        private void GradosEdicion_Load(object sender, EventArgs e)
        {
            
        }
    }
}
