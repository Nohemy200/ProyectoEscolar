using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class PermisosGestion : Form
    {
        private void CargarRoles()
        {
            DataTable Roles = new DataTable();
            try
            {
                Roles = DataManager.DBConsultas.ROLES();
                combRol.DataSource= Roles;
                combRol.DisplayMember = "rol";
                combRol.ValueMember = "idrol";
            }
            catch (Exception)
            {

            }
        }

        private void CargarPermisos()
        {
            DataTable Permisos=new DataTable();
            String pidRol = combRol.SelectedValue.ToString();
            try
            {
                Permisos = DataManager.DBConsultas.PERMISOS(pidRol);
                dtgvPermisos.AutoGenerateColumns = false;
                dtgvPermisos.DataSource= Permisos;

            }
            catch (Exception)
            {

            }
        }




        public PermisosGestion()
        {
            InitializeComponent();
        }

        private void PermisosGestion_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void cbbRoles_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarPermisos();
        }

        private void dtgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    String ValorActual;
                    ValorActual = dtgvPermisos.CurrentRow.Cells["Asignado"].Value.ToString();
                    if (ValorActual == "0")
                    {
                        CLS.Permisos oPermiso = new CLS.Permisos();
                        oPermiso.IDOpcion = dtgvPermisos.CurrentRow.Cells["idopcion"].Value.ToString();
                        oPermiso.IDRol = combRol.SelectedValue.ToString();
                        if (oPermiso.Insertar())
                        {
                            CargarPermisos();
                        }
                    }
                    else
                    {
                        CLS.Permisos oPermiso = new CLS.Permisos();
                        oPermiso.IDPermiso = dtgvPermisos.CurrentRow.Cells["idpermiso"].Value.ToString();
                        if (oPermiso.Eliminar())
                        {
                            CargarPermisos();
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
