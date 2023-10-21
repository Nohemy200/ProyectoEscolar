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
    public partial class ApoderadoEdicion : Form
    {
        public int IdReferencia { get; internal set; }

        private void CargarGenero()
        {
            DataTable oGenero = new DataTable();
            try
            {
                oGenero = DataManager.DBConsultas.Generos();
                combGenero.DataSource = oGenero;
                combGenero.DisplayMember = "genero";
                combGenero.ValueMember = "idgenero";
            }
            catch (Exception)
            {

                throw;
            }
        }



        public ApoderadoEdicion()
        {
            InitializeComponent();
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy/MM/dd";
        }

        private void ApoderadoEdicion_Load(object sender, EventArgs e)
        {
            CargarGenero();
            if (IdReferencia > 0)
            {
                combGenero.SelectedIndex = IdReferencia - 1;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Apoderados oApoderado = new CLS.Apoderados();
            //Sincronizar la entidad con la interfaz
            oApoderado.TipoRelacion = txtTipo.Text.ToUpper();
            oApoderado.Dui = txtDui.Text;
            oApoderado.NombresApoderado = txtNombreApoderado.Text.ToUpper();
            oApoderado.Apellidos = txtApellidos.Text.ToUpper();
            oApoderado.Telefono = txtTelefono.Text;
            oApoderado.FechaNacimiento = dtpFecha.Text;
            oApoderado.IdDireccion = txtIdDireccion.Text;
            oApoderado.IdGenero = combGenero.SelectedValue.ToString();
            //Identificar la accion a realizar
            if (txtIDApoderado.TextLength > 0)
            {
                oApoderado.IdApoderado = txtIDApoderado.Text;
                //Realizar la operacion de actualizar
                if (oApoderado.Actualizar())
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
                if (oApoderado.Insertar())
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

        private void combGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
