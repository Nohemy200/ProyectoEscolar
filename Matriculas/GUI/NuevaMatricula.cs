using General.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriculas.GUI
{
    public partial class NuevaMatricula : Form
    {
        public DataGridViewRow DatosAlumno { get; private set; }
        public DataGridViewRow DatosApoderado { get; private set; }

        public NuevaMatricula()
        {
            InitializeComponent();
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy/MM/dd";
            // Obtén el año actual
            int añoActual = DateTime.Now.Year;
            // Llena el ComboBox con años desde el año actual hacia atrás
            for (int año = añoActual; año >= 1900; año--) // Puedes ajustar el año mínimo según tus necesidades
            {
                combAñoLectivo.Items.Add(año.ToString());
            }
        }

        private void CargarGradosPorCiclo()
        {
            DataTable grados = new DataTable();
            try
            {
                grados = DataManager.DBConsultas.CONSULTA_GRADOS_POR_CICLO(combCiclo.Text);
                combGrado.DataSource = grados;
                combGrado.DisplayMember = "grado";
                combGrado.ValueMember = "idgrado";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarSeccionPorGrado()
        {
            DataTable seccion = new DataTable();
            try
            {
                seccion = DataManager.DBConsultas.CONSULTA_SECCION_POR_GRADO(combGrado.SelectedValue.ToString());
                combSeccion.DataSource = seccion;
                combSeccion.DisplayMember = "seccion";
                combSeccion.ValueMember = "idseccion";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarGrados()
        {
            DataTable grados = new DataTable();
            try
            {
                grados = DataManager.DBConsultas.CONSULTA_GRADOS();
                combGrado.DataSource = grados;
                combGrado.DisplayMember = "grado";
                combGrado.ValueMember = "idGrado";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            txtNie.Text = "";
            txtNombre.Text = "";
            txtDui.Text = "";
            txtNombreAp.Text = "";
            FormulariosDeSeleccion.GUI.BuscarAlumno f = new FormulariosDeSeleccion.GUI.BuscarAlumno();
            f.CargarDatos(false);
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
            DatosAlumno = f.datosAlumnoEnviar;
            if (DatosAlumno != null)
            {
                txtNie.Text = DatosAlumno.Cells["nie"].Value.ToString();
                txtNombre.Text = DatosAlumno.Cells["nombres"].Value.ToString();
                int id = Int32.Parse(DatosAlumno.Cells["idAlumno"].Value.ToString());
                CargarApoderado(id);
            }
            //Cargamos los datos del apoderado
            
        }

        private void CargarApoderado(int id)
        {
            DataTable apoderado = new DataTable();
            try
            {
                apoderado = DataManager.DBConsultas.CONSULTA_APODERADO_POR_ALUMNO(id);
                if (apoderado.Rows.Count > 0)
                {
                    foreach (DataRow item in apoderado.Rows)
                    {
                        txtDui.Text = item["dui"].ToString();
                        txtNombreAp.Text = item["nombresapoderado"].ToString();
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void NuevaMatricula_Load(object sender, EventArgs e)
        {
            combGrado.SelectedIndex = -1;
        }

        private void LlenarDataGrid(String id)
        {
            /*if(dgvMaterias.Rows.Count > 0)
            {
                dgvMaterias.Rows.Clear();
            }
            DataTable materias = new DataTable();
            try
            {
                materias = DataManager.DBConsultas.CONSULTA_MATERIAS_GRADOS(id);
                if (materias.Rows.Count > 0)
                {
                    foreach (DataRow materia in materias.Rows)
                    {
                        dgvMaterias.Rows.Add(new object[] {//Llenando el datagrid
                            materia["idmateriasgrados"].ToString(),//asigno el idmateria grado que traje enn la consulta
                            materia["idgrado"].ToString(),
                            materia["idmateria"].ToString(),
                            materia["materia"].ToString(),
                            materia["grado"].ToString()
                        });
                    }

                }
                
            }
            catch (Exception)
            {

                throw;
            }*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (combCiclo.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un ciclo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (combSeccion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una seccion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtNie.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un alumno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (combGrado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un grado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (combAñoLectivo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un anio lectivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            General.CLS.Matriculas matricula = new General.CLS.Matriculas();
            matricula.FechaMatricula = dtpFecha.Text.ToString();
            matricula.IdGrado = combGrado.SelectedValue.ToString();
            matricula.IdAlumno = DatosAlumno.Cells["idalumno"].Value.ToString();
            matricula.IdSeccion = combSeccion.SelectedValue.ToString();
            matricula.Anio = combAñoLectivo.SelectedItem.ToString();
            Console.WriteLine("IdMatricula : " + matricula.IdMatricula);
            if (matricula.Insertar())
            {
                List<General.CLS.MateriasAlumnos> oLista = new List<General.CLS.MateriasAlumnos>();//Creamos una lista
                
                //Cambiar el estado del alumno
                General.CLS.Alumnos alumno = new General.CLS.Alumnos();
                alumno.IdAlumno = DatosAlumno.Cells["idalumno"].Value.ToString();
                alumno.IdEstado = "1";
                if (!alumno.ActualizarEstado())
                {
                    MessageBox.Show("Fallo al actualizar estado del alumno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Proceso para asignar notas al que se matricula
                DataTable materiasPorGrado = DataManager.DBConsultas.CONSULTA_MATERIAS_GRADOS(combGrado.SelectedValue.ToString());

                DataTable periodos = DataManager.DBConsultas.CONSULTA_PERIODOS();

                DataTable ultimaMatricula = DataManager.DBConsultas.CONSULTA_ULTIMA_MATRICULA();
                String um = "";

                // Crear una lista para almacenar objetos Notas
                List<Notas> listaNotas = new List<Notas>();

                foreach  (DataRow uMatricula in ultimaMatricula.Rows)
                {
                    um = uMatricula["idmatricula"].ToString();
                }

                Notas notas1 = null;

                foreach (DataRow materia in materiasPorGrado.Rows)
                {
                    foreach (DataRow periodo in periodos.Rows)
                    {
                        notas1 = new Notas();
                        notas1.IdMatricula = um;
                        notas1.Nota = "0";
                        notas1.IDMateria = materia["idmateria"].ToString();
                        notas1.IdPeriodo = periodo["idperiodo"].ToString();
                        listaNotas.Add(notas1);
                        notas1 = new Notas();
                    }
                }

                foreach (var notas in listaNotas)
                {
                    if (!notas.Insertar())
                    {
                        MessageBox.Show("Error al insertar notas, contacte el programador.");
                    }
                    // Aquí puedes trabajar con cada objeto Notas
                    Console.WriteLine($"IdMatricula: {notas.IdMatricula}, IDMateria: {notas.IDMateria}, IdPeriodo: {notas.IdPeriodo}, Nota: {notas.Nota}");
                }

                MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Fallo en insertar matriculas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void Limpiar()
        {
            txtNombreAp.Text = "";
            txtNombre.Text = "";
            txtNie.Text = "";
            txtDui.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDui.Text = "";
            txtNombreAp.Text = "";
            FormulariosDeSeleccion.GUI.BuscarApoderado f = new FormulariosDeSeleccion.GUI.BuscarApoderado();
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
            DatosApoderado = f.datosApoderadoEnviar;
            if (DatosApoderado != null)
            {
                txtDui.Text = DatosApoderado.Cells["dui"].Value.ToString();
                txtNombreAp.Text = DatosApoderado.Cells["nombresapoderado"].Value.ToString();
            }
        }

        private void combCiclo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarGradosPorCiclo();
            if (combSeccion.Items != null)
            {
                combSeccion.DataSource = null;
                combSeccion.Items.Clear();
            }
        }

        private void combGrado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarSeccionPorGrado();
        }
    }
}
