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
    public partial class Aulas : Form
    {
        private void CargarReporte()
        {
            DataTable datos = new DataTable();
            Reportes.REP.Aulas oReporte = new REP.Aulas();
            datos = DataManager.DBConsultas.REPORTAULAS();
            oReporte.SetDataSource(datos);
            crvVisor.ReportSource = oReporte;
        }

        public Aulas()
        {
            InitializeComponent();
        }

        private void Aulas_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }

        
    }
}
