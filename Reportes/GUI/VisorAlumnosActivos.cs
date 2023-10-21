using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes.GUI
{
    public partial class VisorAlumnosActivos : Form
    {

        private void CargarReporte()
        {
            DataTable Datos = new DataTable();
            Reportes.REP.AlumnosActivos oReporte = new REP.AlumnosActivos();
            Datos = DataManager.DBConsultas.REPORTE_ALUMNOS_ACTIVOS();
            oReporte.SetDataSource(Datos);
            crvVisor.ReportSource = oReporte;
        }
        public VisorAlumnosActivos()
        {
            InitializeComponent();
        }

        private void VisorAlumnosActivos_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
