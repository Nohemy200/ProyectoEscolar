using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencia.GUI
{
    public partial class AsistenciaGestion : Form
    {
        public AsistenciaGestion()
        {
            InitializeComponent();
            // Obtén el año actual
            int añoActual = DateTime.Now.Year;
            // Llena el ComboBox con años desde el año actual hacia atrás
            for (int año = añoActual; año >= 1900; año--) // Puedes ajustar el año mínimo según tus necesidades
            {
                combAñoLectivo.Items.Add(año.ToString());
            }
        }

        private void CargarDatos()
        {
            String idPeriodo = combPeriodo.SelectedValue.ToString();
            String idGrado = combGrado.SelectedValue.ToString();
            String idMateria = combMateria.SelectedValue.ToString();
            String idSeccion = combSeccion.SelectedValue.ToString();
            String anio = combAñoLectivo.SelectedItem.ToString();
            try
            {
                //_BUSCAR.DataSource = DataManager.DBConsultas.BUSCAR_ALUMNOS_ASIGNAR_NOTAS(idPeriodo, idGrado, idMateria, idSeccion, anio);
                //dgvDatos.DataSource = _BUSCAR;
                //dgvDatos.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

            }
        }

        private void CargarCiclos()
        {
            DataTable ciclos = new DataTable();
            try
            {
                ciclos = DataManager.DBConsultas.CONSULTA_CICLO();
                combCiclo.DataSource = ciclos;
                combCiclo.DisplayMember = "ciclo";
            }
            catch (Exception)
            {

                //throw;
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
                combGrado.SelectedItem = -1;
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

                //throw;
            }
        }

        private void AsistenciaGestion_Load(object sender, EventArgs e)
        {
            CargarPeriodos();
            CargarCiclos();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combCiclo.SelectedItem != null && combGrado.SelectedItem != null && combPeriodo.SelectedItem != null && combSeccion.SelectedItem != null && combAñoLectivo.SelectedItem != null)
            {
                CargarDatos();
                dgvDatos.Visible = true;
            }
            else
            {
                dgvDatos.Visible = false;
            }
        }


        private void combSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combCiclo.SelectedItem != null && combGrado.SelectedItem != null && combMateria.SelectedItem != null && combPeriodo.SelectedItem != null && combAñoLectivo.SelectedItem != null)
            {
                CargarDatos();
                dgvDatos.Visible = true;
            }
            else
            {
                dgvDatos.Visible = false;
            }
        }

        private void combAñoLectivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combCiclo.SelectedItem != null && combGrado.SelectedItem != null && combMateria.SelectedItem != null && combSeccion.SelectedItem != null && combPeriodo.SelectedItem != null)
            {
                CargarDatos();
                dgvDatos.Visible = true;
            }
            else
            {
                dgvDatos.Visible = false;
            }
        }

        private void combCiclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGradosPorCiclo();
            if (combSeccion.Items != null)
            {
                combMateria.SelectedIndex = -1;
                combSeccion.DataSource = null;
                combSeccion.Items.Clear();
                combMateria.DataSource = null;
                combMateria.Items.Clear();
            }
            if (combPeriodo.SelectedItem != null && combGrado.SelectedItem != null && combMateria.SelectedItem != null && combSeccion.SelectedItem != null && combAñoLectivo.SelectedItem != null)
            {
                CargarDatos();
                dgvDatos.Visible = true;
            }
            else
            {
                dgvDatos.Visible = false;
            }
        }

        private void CargarMateriaPorGrado(string idGrado)
        {
            DataTable materias = new DataTable();
            try
            {
                materias = DataManager.DBConsultas.CONSULTA_MATERIAS_GRADOS(idGrado);
                combMateria.DataSource = materias;
                combMateria.DisplayMember = "materia";
                combMateria.ValueMember = "idmateria";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void combGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSeccionPorGrado();
            CargarMateriaPorGrado(combGrado.SelectedValue.ToString());
            if (combCiclo.SelectedItem != null && combPeriodo.SelectedItem != null && combMateria.SelectedItem != null && combSeccion.SelectedItem != null && combAñoLectivo.SelectedItem != null)
            {
                CargarDatos();
                dgvDatos.Visible = true;
            }
            else
            {
                dgvDatos.Visible = false;
            }
        }

        private void combPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combCiclo.SelectedItem != null && combGrado.SelectedItem != null && combMateria.SelectedItem != null && combSeccion.SelectedItem != null && combAñoLectivo.SelectedItem != null)
            {
                CargarDatos();
                dgvDatos.Visible = true;
            }
            else
            {
                dgvDatos.Visible = false;
            }
        }
    }
}
