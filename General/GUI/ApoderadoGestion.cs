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
    
    public partial class ApoderadoGestion : Form
    {
        BindingSource _APODERADOS = new BindingSource();
    
        public string apoderadoEnviar { get; set; }
        public string idEnviar { get; set; }

        private void CargarDatos()
        {
            try
            {
                _APODERADOS.DataSource = DataManager.DBConsultas.APODERADOS();
                dtgvApoderado.DataSource = _APODERADOS;
                dtgvApoderado.AutoGenerateColumns = false;
                lblRegistros.Text = dtgvApoderado.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public ApoderadoGestion()
        {
            InitializeComponent();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ApoderadoEdicion f = new ApoderadoEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void ApoderadoGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            apoderadoEnviar = dtgvApoderado.CurrentRow.Cells["nombresapoderado"].Value.ToString();
            idEnviar = dtgvApoderado.CurrentRow.Cells["idapoderado"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ApoderadoEdicion f = new ApoderadoEdicion();
                f.txtIDApoderado.Text = dtgvApoderado.CurrentRow.Cells["idapoderado"].Value.ToString();
                f.txtDui.Text=dtgvApoderado.CurrentRow.Cells["dui"].Value.ToString();
                f.txtTipo.Text = dtgvApoderado.CurrentRow.Cells["tiporelacion"].Value.ToString();
                f.txtNombreApoderado.Text = dtgvApoderado.CurrentRow.Cells["nombresapoderado"].Value.ToString();
                f.txtApellidos.Text = dtgvApoderado.CurrentRow.Cells["apellidos"].Value.ToString();
                f.txtTelefono.Text = dtgvApoderado.CurrentRow.Cells["telefono"].Value.ToString();
                f.dtpFecha.Text = dtgvApoderado.CurrentRow.Cells["fechanacimiento"].Value.ToString();
                f.txtIdDireccion.Text = dtgvApoderado.CurrentRow.Cells["direccion"].Value.ToString();
                f.IdReferencia = Int32.Parse(dtgvApoderado.CurrentRow.Cells["idgenero"].Value.ToString());
                
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Apoderados oApoderado = new CLS.Apoderados();
                oApoderado.IdApoderado = dtgvApoderado.CurrentRow.Cells["idapoderado"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oApoderado.Eliminar())
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
    }
}
