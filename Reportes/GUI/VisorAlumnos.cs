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
    public partial class VisorAlumnos : Form

    {
        private void CargarReporte()
        {
            DataTable Datos = new DataTable();
            Reportes.REP.Alumnos oReporte = new REP.Alumnos();
            Datos = DataManager.DBConsultas.REPORTE_ALUMNOS();
            oReporte.SetDataSource(Datos);
            crvVisor.ReportSource = oReporte;
        }

        public VisorAlumnos()
        {
            InitializeComponent();
        }

        private void VisorAlumnos_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
