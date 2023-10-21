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
    public partial class MateriasGradosEdicion : Form
    {
        public int idReferenciaMat;
        public int idReferenciaGra;

        public MateriasGradosEdicion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CargarGrados()
        {
            DataTable oGrado = new DataTable();
            try
            {
                oGrado = DataManager.DBConsultas.CONSULTA_GRADOS();
                combGrados.DataSource = oGrado;
                combGrados.DisplayMember = "grado";
                combGrados.ValueMember = "idgrado";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarMaterias()
        {
            DataTable oMateria = new DataTable();
            try
            {
                oMateria = DataManager.DBConsultas.MATERIAS();
                combMaterias.DataSource = oMateria;
                combMaterias.DisplayMember = "materia";
                combMaterias.ValueMember = "idmateria";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.MateriasGrados oMateriaGrado = new CLS.MateriasGrados();
            //Sincronizar la entidad con la interfaz
            oMateriaGrado.IdGrado = combGrados.SelectedValue.ToString();
            oMateriaGrado.IdMateria = combMaterias.SelectedValue.ToString();
            //Identificar la accion a realizar
            DataTable existe = DataManager.DBConsultas.REGISTRO_MATERIA_GRADO(combMaterias.SelectedValue.ToString(), combGrados.SelectedValue.ToString());
            if (txtIDMateriaGrado.TextLength > 0)
            {
                oMateriaGrado.IdMateriaGrado = txtIDMateriaGrado.Text;
                    if (existe.Rows.Count <= 0)
                    {
                        //Realizar la operacion de actualizar
                        if (oMateriaGrado.Actualizar())
                    {
                        MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("¡El registro no fue actualizado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("¡El registro no fue insertado! el grado ya contiene la materia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (existe.Rows.Count<=0)
                {
                    //Realizar la operacion de insertar
                    if (oMateriaGrado.Insertar())
                    {
                        MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("¡El registro no fue insertado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("¡El registro no fue insertado! el grado ya contiene la materia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void MateriasGradosEdicion_Load(object sender, EventArgs e)
        {
            CargarMaterias();
            if (idReferenciaMat > 0)
            {
                combMaterias.SelectedValue = idReferenciaMat;
            }
            CargarGrados();
            if (idReferenciaGra > 0)
            {
                combGrados.SelectedValue = idReferenciaGra;
            }
        }
    }
}
