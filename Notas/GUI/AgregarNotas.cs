using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas.GUI
{
    public partial class AgregarNotas : Form
    {
        public DataGridViewRow DatosAlumno { get; private set; }
        public AgregarNotas()
        {
            InitializeComponent();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro que desea cambiar el alumno? Los datos ya establecidos se perderan", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvMaterias.Rows.Clear();
                    txtNie.Text = "";
                    txtNombre.Text = "";
                    FormulariosDeSeleccion.GUI.BuscarAlumno f = new FormulariosDeSeleccion.GUI.BuscarAlumno();
                    f.CargarDatos(true);
                    f.btnSeleccionar.Visible = true;
                    f.ShowDialog();
                    DatosAlumno = f.datosAlumnoEnviar;
                    if (DatosAlumno != null)
                    {
                        txtNie.Text = DatosAlumno.Cells["nie"].Value.ToString();
                        txtNombre.Text = DatosAlumno.Cells["nombres"].Value.ToString();
                        CargarMaterias(DatosAlumno.Cells["idalumno"].Value.ToString(), "1");
                        CargarPeriodos();
                    }
                }
            }
            else
            {
                txtNie.Text = "";
                txtNombre.Text = "";
                FormulariosDeSeleccion.GUI.BuscarAlumno f = new FormulariosDeSeleccion.GUI.BuscarAlumno();
                f.CargarDatos(true);
                f.btnSeleccionar.Visible = true;
                f.ShowDialog();
                DatosAlumno = f.datosAlumnoEnviar;
                if (DatosAlumno != null)
                {
                    txtNie.Text = DatosAlumno.Cells["nie"].Value.ToString();
                    txtNombre.Text = DatosAlumno.Cells["nombres"].Value.ToString();
                    CargarMaterias(DatosAlumno.Cells["idalumno"].Value.ToString(), "1");
                    CargarPeriodos();
                }
            }
        }

        private void CargarPeriodos()
        {
            DataTable periodos = new DataTable();
            try
            {
                periodos = DataManager.DBConsultas.CONSULTA_PERIODOS();
                combPeriodo.DataSource = periodos;
                combPeriodo.DisplayMember = "periodo";
                combPeriodo.ValueMember = "idperiodo";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CargarMaterias(String id, String pe)
        {
            DataTable materias = new DataTable();
            try
            {
                materias = DataManager.DBConsultas.CONSULTA_MATERIAS(id, pe);
                combMaterias.DataSource = materias;
                combMaterias.DisplayMember = "materia";
                combMaterias.ValueMember = "idmateria";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AgregarNotas_Load(object sender, EventArgs e)
        {
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignorar la tecla presionada
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true; // Ignorar la tecla presionada si ya hay un punto decimal
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (txtNie.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un alumno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtNota.Text.Equals(""))
            {
                MessageBox.Show("Debe escribir la nota a asignar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (combMaterias.Items.Count<=0)
            {
                MessageBox.Show("No hay materias para asignar nota", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string materiaAbuscar = combMaterias.SelectedValue.ToString();
            string periodoAbuscar = combPeriodo.SelectedValue.ToString();
            bool existeMateria = false;

            foreach (DataGridViewRow row in dgvMaterias.Rows)
            {
                if ((row.Cells["idmateria"].Value != null && row.Cells["idmateria"].Value.ToString() == materiaAbuscar) && (row.Cells["idperiodo"].Value != null && row.Cells["idperiodo"].Value.ToString() == periodoAbuscar))
                {
                    existeMateria = true;
                    break;
                }
            }

            if (existeMateria)
            {
                MessageBox.Show("No puede agregar la materia dos veces en el mismo periodo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Console.WriteLine("El producto no existe en el DataGridView.");
            }


            dgvMaterias.Rows.Add(new object[] {//datosProducto es un datagrid que traigo con los datos del producto
                combMaterias.SelectedValue,
                combMaterias.Text,
                combPeriodo.SelectedValue,
                combPeriodo.Text,
                txtNota.Text
            });
            txtNota.Text = "";
            btnEliminar.Visible = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvMaterias.Rows.RemoveAt(dgvMaterias.CurrentRow.Index);
                    MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dgvMaterias.Rows.Count < 1)
                    {
                        btnEliminar.Visible = false;
                    }
                }
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNie.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un alumno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<General.CLS.Notas> oLista = new List<General.CLS.Notas>();//Creamos una lista

            foreach (DataGridViewRow row in dgvMaterias.Rows)//Guardamos los objetos en la lista
            {
                oLista.Add(new General.CLS.Notas()
                {
                    //IdAlumno = DatosAlumno.Cells["idalumno"].Value.ToString(),
                    IDMateria = row.Cells["idmateria"].Value.ToString(),
                    IdPeriodo = row.Cells["idperiodo"].Value.ToString(),
                    Nota = row.Cells["nota"].Value.ToString(),
     

                });
            }
            //Insertamos las materias al alumno
            bool error = false;
            foreach (var nota in oLista)
            {
                if (!nota.Insertar())
                {
                    error = true;
                }
            }
            if (error)
            {
                MessageBox.Show("Fallo al insertar notas a la materia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvMaterias.Rows.Clear();
            btnEliminar.Visible = false;
            txtNie.Text = "";
            txtNombre.Text = "";
        }

        private void combPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias(DatosAlumno.Cells["idalumno"].Value.ToString(), combPeriodo.SelectedValue.ToString());
        }
    }
}
