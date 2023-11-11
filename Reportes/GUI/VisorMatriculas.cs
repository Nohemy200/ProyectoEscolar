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
    public partial class VisorMatriculas : Form
    {


        private void CargarReporte()
        {
            DataTable Datos = new DataTable();
            Reportes.REP.Matriculas oReporte = new REP.Matriculas();
            Datos = DataManager.DBConsultas.REPORTE_MATRICULAS(1, "2023", 10);
            oReporte.SetDataSource(Datos);
            crvVisor.ReportSource = oReporte;
        }
        public VisorMatriculas()
        {
            InitializeComponent();
        }

        private void VisorMatriculas_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
