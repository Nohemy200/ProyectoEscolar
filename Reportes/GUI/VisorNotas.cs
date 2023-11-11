using CrystalDecisions.CrystalReports.Engine;
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
    public partial class VisorNotas : Form
    {
        public VisorNotas()
        {
            InitializeComponent();
        }

        private void CargarReporte()
        {
            // Crear el DataTable y cargar datos para el primer informe
            DataTable Datos1 = new DataTable();
            REP.Notas oReporte1 = new REP.Notas();
            Datos1 = DataManager.DBConsultas.REPORTE_NOTAS(10, 1, "2023");
            oReporte1.SetDataSource(Datos1);

            // Crear el DataTable y cargar datos para el segundo informe
            DataTable Datos2 = new DataTable();
            REP.Notas oReporte2 = new REP.Notas();
            Datos2 = DataManager.DBConsultas.REPORTE_NOTAS(10, 1, "2023");
            oReporte1.SetDataSource(Datos2);

            // Agregar los informes individuales al informe combinado
            oReporte1.Subreports["Subreport1"].SetDataSource(Datos1);
            oReporte1.Subreports["Subreport2"].SetDataSource(Datos2);

            // Asignar el informe combinado al visor de informes
            crvVisor.ReportSource = oReporte1;

        }





        private void VisorNotas_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
