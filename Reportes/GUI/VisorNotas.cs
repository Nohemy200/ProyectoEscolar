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
            DataTable Datos = new DataTable();
            REP.Notas oReporte = new REP.Notas();
            Datos = DataManager.DBConsultas.REPORTE_NOTAS(10, 1, "2023");
            oReporte.SetDataSource(Datos);


            // Asignar el informe combinado al visor de informes
            crvVisor.ReportSource = oReporte;

        }





        private void VisorNotas_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void crvVisor_Load(object sender, EventArgs e)
        {

        }
    }
}
