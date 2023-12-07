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
    public partial class AlumnoEdicion : Form
    {
        public int idReferenciaEst;
        public int idReferenciaGen;

        public int IdGenero { get; internal set; }
        public int IdEstado { get; internal set; }

        private void CargarGenero()
        {

            DataTable oGenero = new DataTable();
            try
            {
                oGenero = DataManager.DBConsultas.Generos();
                combGenero.DataSource =oGenero;
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
        public AlumnoEdicion()
        {
            InitializeComponent();
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy/MM/dd";
        }

        private void AlumnoEdicion_Load(object sender, EventArgs e)
        {
            CargarEstado();
            if (idReferenciaEst > 0)
            {
                combEstado.SelectedValue = idReferenciaEst;
            }
            CargarGenero();
            if (idReferenciaGen > 0)
            {
                combGenero.SelectedValue = idReferenciaGen;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ApoderadoGestion f = new ApoderadoGestion();
            f.btnSeleccionar.Visible = true;
            var result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtApoderado.Text = f.apoderadoEnviar;
                txtIdApoderado.Text = f.idEnviar;
            }
        }

        private void combGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNie.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(dtpFecha.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                combGenero.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtIdApoderado.Text) ||
                string.IsNullOrWhiteSpace(txtIdDireccion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // No continúes con el proceso de guardar si hay campos vacíos.
            }

            // Creacion del objeto entidad
            CLS.Alumnos oAlumnos = new CLS.Alumnos();

            // Sincronizar la entidad con la interfaz
            oAlumnos.Nie = txtNie.Text.ToUpper();
            oAlumnos.Nombres = txtNombres.Text.ToUpper();
            oAlumnos.Apellidos = txtApellidos.Text.ToUpper();
            oAlumnos.FechaNacimiento = dtpFecha.Text;
            oAlumnos.Telefono = txtTelefono.Text;
            oAlumnos.IdGenero = combGenero.SelectedValue.ToString();
            oAlumnos.IdApoderado = txtIdApoderado.Text;
            oAlumnos.IdDireccion = txtIdDireccion.Text;

            // Identificar la accion a realizar
            if (txtIDAlumno.TextLength > 0)
            {
                // Realizar la operacion de actualizar
                oAlumnos.IdAlumno = txtIDAlumno.Text;
                oAlumnos.IdEstado = combEstado.SelectedValue.ToString();

                if (oAlumnos.Actualizar())
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
                oAlumnos.IdEstado = "2";

                if (oAlumnos.Insertar())
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
    }
}
