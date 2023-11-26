using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE.GUI
{
    public partial class Main : Form
    {
        SessionManager.Session oUsuario = SessionManager.Session.Instancia;
        public Main()
        {
            InitializeComponent();
        }


      

        private void opcionHijaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                General.GUI.RolesGestion f = new General.GUI.RolesGestion();
                f.MdiParent = this;
                f.Show();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void gestionDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.PermisosGestion f = new General.GUI.PermisosGestion();
                f.MdiParent = this;
                f.Show();

            }
            catch (Exception)
            {
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblConConexion.Visible = true;
            lblUsuario.Text = oUsuario.Usuario.ToUpper();
            lblRol.Text = oUsuario.Rol.ToUpper();
        }

        private void gestionDeAulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.AulasGestion f = new General.GUI.AulasGestion();
                f.MdiParent = this;
                f.Show();

            }
            catch (Exception)
            {
            }
        }

        private void gestionEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.EstadoGestion f = new General.GUI.EstadoGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception)
            {
            }
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.MateriaGestion f = new General.GUI.MateriaGestion();
                f.MdiParent = this;
                f.Show();

            }
            catch (Exception)
            {
            }
        }

        private void gestionEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.EspecialidadGestion f = new General.GUI.EspecialidadGestion();
                f.MdiParent = this;
                f.Show();

            }
            catch (Exception)
            {
            }
        }

        private void gestionDeGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.GeneroGestion f = new General.GUI.GeneroGestion();
                f.MdiParent = this;
                f.Show();

            }
            catch (Exception)
            {
            }
        }

        private void gestionDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.AlumnoGestion f = new General.GUI.AlumnoGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeEncargadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.ApoderadoGestion f = new General.GUI.ApoderadoGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.DocentesGestion f = new General.GUI.DocentesGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeGradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.GradosGestion f = new General.GUI.GradosGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void nuevaMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matriculas.GUI.NuevaMatricula f = new Matriculas.GUI.NuevaMatricula();
            f.MdiParent = this;
            f.Show();

        }

        

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Esta seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Cerrar la aplicación
                Application.Exit();
            }
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!bgwConexion.IsBusy)
            {
                // Inicia el BackgroundWorker si no está ocupado
                bgwConexion.RunWorkerAsync();
            }
        }

        private void bgwConexion_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DataManager.DBConexion cn = new DataManager.DBConexion();
                if (cn.Conectar())
                {
                    e.Result = true;
                    cn.Desconectar();
                }
                else
                {
                    e.Result = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void bgwConexion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                lblSinConexion.Visible = false;
                lblConConexion.Visible = true;
            }
            else
            {
                lblConConexion.Visible = false;
                lblSinConexion.Visible = true;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void gestionDeMateriasYGradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.MateriasGradosGestion f = new General.GUI.MateriasGradosGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.UsuarioGestion f = new General.GUI.UsuarioGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void buscarMateriasPorAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matriculas.GUI.BuscarMatricula f = new Matriculas.GUI.BuscarMatricula();
            f.MdiParent = this;
            f.Show();
        }

        private void reporteMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.GUI.VisorMatriculas f = new Reportes.GUI.VisorMatriculas();
            f.ShowDialog();
        }

        private void asignarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calificasiones.AsignarNotas f = new Calificasiones.AsignarNotas();
            f.ShowDialog();
        }

        private void verAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asistencia.GUI.AsistenciaGestion asistencia = new Asistencia.GUI.AsistenciaGestion();
            asistencia.ShowDialog();
        }

        private void reporteNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.GUI.VisorNotas f = new Reportes.GUI.VisorNotas();
            f.ShowDialog();
        }

        private void reporteDeNotasPorGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matriculas.GUI.ReporteDeNotasPorGrado f = new Matriculas.GUI.ReporteDeNotasPorGrado();
            f.ShowDialog();
        }
    }
}
