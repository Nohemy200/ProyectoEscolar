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
    public partial class RolesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        public string RolEnviar { get; private set; }
        public string IdEnviar { get; private set; }

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.ROLES();
                dtgvDatos.DataSource = _DATOS;
                dtgvDatos.AutoGenerateColumns = false;
                lblRegistros.Text=dtgvDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public RolesGestion()
        {
            InitializeComponent();
        }

        private void RolesGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RolesEdicion f=new RolesEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?","Pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                RolesEdicion f=new RolesEdicion();
                f.txbIDRol.Text = dtgvDatos.CurrentRow.Cells["IDRol"].Value.ToString();
                f.txbRol.Text = dtgvDatos.CurrentRow.Cells["Rol"].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Roles oRoles= new CLS.Roles();
                oRoles.IDRol = dtgvDatos.CurrentRow.Cells["IDRol"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oRoles.Eliminar())
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

        private void dtgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            RolEnviar = dtgvDatos.CurrentRow.Cells["rol"].Value.ToString();
            IdEnviar = dtgvDatos.CurrentRow.Cells["idrol"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
