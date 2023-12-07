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
    public partial class DocentesEdicion : Form
    {
        public int idReferenciaGen;
        public int idReferenciaEst;
        public int idReferenciaEsp;

        public int IdGenero { get; internal set; }
        public int IdEstado { get; internal set; }
        public int IdEspecialidad { get; internal set; }

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

        private void CargarEstado()
        {
            DataTable oEstado = new DataTable();
            try
            {
                oEstado = DataManager.DBConsultas.ESTADO();
                combEstado.DataSource = oEstado;
                combEstado.DisplayMember = "estado";
                combEstado.ValueMember = "idestado";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarEspecialidad()
        {
            DataTable oEspecialidad = new DataTable();
            try
            {
                oEspecialidad = DataManager.DBConsultas.ESPECIALIDAD();
                combEspecialidad.DataSource = oEspecialidad;
                combEspecialidad.DisplayMember = "especialidad";
                combEspecialidad.ValueMember = "idespecialidad";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DocentesEdicion()
        {
            InitializeComponent();
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy/MM/dd";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombresDocente.Text) ||
                string.IsNullOrWhiteSpace(txtApellidosDocente.Text) ||
                string.IsNullOrWhiteSpace(txtDuii.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(dtpFecha.Text) ||
                combGenero.SelectedValue == null ||
                combEstado.SelectedValue == null ||
                combEspecialidad.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtIdDireccion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // No continúes con el proceso de guardar si hay campos vacíos.
            }

            // Creacion del objeto entidad
            CLS.Docentes oDocentes = new CLS.Docentes();

            // Sincronizar la entidad con la interfaz
            oDocentes.NombresDocente = txtNombresDocente.Text.ToUpper();
            oDocentes.ApellidosDocente = txtApellidosDocente.Text.ToUpper();
            oDocentes.Dui = txtDuii.Text;
            oDocentes.Telefono = txtTelefono.Text;
            oDocentes.FechaNacimiento = dtpFecha.Text;
            oDocentes.IdGenero = combGenero.SelectedValue.ToString();
            oDocentes.IdEstado = combEstado.SelectedValue.ToString();
            oDocentes.IdEspecialidad = combEspecialidad.SelectedValue.ToString();
            oDocentes.IdDireccion = txtIdDireccion.Text;

            // Identificar la accion a realizar
            if (txtIdDocente.TextLength > 0)
            {
                // Realizar la operacion de actualizar
                oDocentes.IdDocente = txtIdDocente.Text;
                if (oDocentes.Actualizar())
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
                // Realizar la operacion de insertar
                if (oDocentes.Insertar())
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


        private void DocentesEdicion_Load(object sender, EventArgs e)
        {
            CargarGenero();
            if (idReferenciaGen > 0)
            {
                combGenero.SelectedIndex = idReferenciaGen - 1;
            }
            CargarEstado();
            if (idReferenciaEst > 0)
            {
                combEstado.SelectedIndex = idReferenciaEst - 1;
            }
            CargarEspecialidad();
            if (idReferenciaEsp > 0)
            {
                combEspecialidad.SelectedIndex = idReferenciaEsp - 1;
            }
        }
    }
}
