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
    public partial class ReporteDeMatriculasPorGrado : Form
    {
        BindingSource _BUSCAR = new BindingSource();
        public ReporteDeMatriculasPorGrado()
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

        private void CargarReporte(int idSeccion, String anio, int idGrado)
        {

            // Crear el DataTable y cargar datos para el primer informe
            DataTable Datos = new DataTable();
            Reportes.REP.Matriculas oReporte = new Reportes.REP.Matriculas();
            Datos = DataManager.DBConsultas.REPORTE_MATRICULAS(idSeccion, anio, idGrado);
            oReporte.SetDataSource(Datos);


            // Asignar el informe combinado al visor de informes
            Reportes.GUI.VisorMatriculas f = new Reportes.GUI.VisorMatriculas();
            f.crvVisor.ReportSource = oReporte;
            f.ShowDialog();


        }




        private void ReporteDeMatriculasPorGrado_Load(object sender, EventArgs e)
        {
            CargarCiclos();
        }

        private void CargarDatos()
        {
            int idGrado = Int32.Parse(combGrado.SelectedValue.ToString());
            int idSeccion = Int32.Parse(combSeccion.SelectedValue.ToString());
            String anio = combAñoLectivo.SelectedItem.ToString();
            try
            {
                _BUSCAR.DataSource = DataManager.DBConsultas.REPORTE_MATRICULAS(idSeccion, anio, idGrado);
                dgvMatriculas.DataSource = _BUSCAR;
                dgvMatriculas.AutoGenerateColumns = false;
            }
            catch (Exception)
            {

            }
        }


        private void combCiclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGradosPorCiclo();
            if (combSeccion.Items != null)
            {
                combSeccion.DataSource = null;
                combSeccion.Items.Clear();

            }
            if (combGrado.SelectedItem != null && combSeccion.SelectedItem != null && combAñoLectivo.SelectedItem != null)
            {
                CargarDatos();
                dgvMatriculas.Visible = true;
            }
            else
            {
                dgvMatriculas.Visible = false;
            }
        }

        private void combGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSeccionPorGrado();
            if (combCiclo.SelectedItem != null && combSeccion.SelectedItem != null && combAñoLectivo.SelectedItem != null)
            {
                CargarDatos();
                dgvMatriculas.Visible = true;
            }
            else
            {
                dgvMatriculas.Visible = false;
            }
        }

        private void combAñoLectivo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (combCiclo.SelectedItem != null && combGrado.SelectedItem != null && combSeccion.SelectedItem != null)
            {
                CargarDatos();
                dgvMatriculas.Visible = true;
            }
            else
            {
                dgvMatriculas.Visible = false;
            }
        }

        private void combSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combCiclo.SelectedItem != null && combGrado.SelectedItem != null && combAñoLectivo.SelectedItem != null)
            {
                CargarDatos();
                dgvMatriculas.Visible = true;
            }
            else
            {
                dgvMatriculas.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (combAñoLectivo.SelectedIndex < 0)
            {
                return;
            }
            if (combGrado.SelectedIndex < 0)
            {
                return;
            }
            if (combSeccion.SelectedIndex < 0)
            {
                return;
            }
            CargarReporte(Int32.Parse(combGrado.SelectedValue.ToString()), combSeccion.SelectedValue.ToString(), Int32.Parse(combAñoLectivo.SelectedItem.ToString()));
        }
    }
}
