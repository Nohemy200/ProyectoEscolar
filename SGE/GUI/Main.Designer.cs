
namespace SGE.GUI
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.opcionPadreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionHijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeAulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEncargadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeGradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeMateriasYGradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteAulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteAlumnosActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMateriasPorAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSinConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bgwConexion = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.asignarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Azure;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(55, 55);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionPadreToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.matriculasToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1035, 63);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "MenuStrip";
            // 
            // opcionPadreToolStripMenuItem
            // 
            this.opcionPadreToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.opcionPadreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeUsuariosToolStripMenuItem,
            this.opcionHijaToolStripMenuItem,
            this.gestionDePermisosToolStripMenuItem,
            this.gestionDeAulasToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.gestionEspecialidadesToolStripMenuItem,
            this.gestionDeAlumnosToolStripMenuItem,
            this.gestionDeEncargadosToolStripMenuItem,
            this.gestionDeDocentesToolStripMenuItem,
            this.gestionDeGradosToolStripMenuItem,
            this.gestionDeMateriasYGradosToolStripMenuItem});
            this.opcionPadreToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionPadreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionPadreToolStripMenuItem.Image")));
            this.opcionPadreToolStripMenuItem.Name = "opcionPadreToolStripMenuItem";
            this.opcionPadreToolStripMenuItem.Size = new System.Drawing.Size(139, 59);
            this.opcionPadreToolStripMenuItem.Text = "General";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            this.gestionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // opcionHijaToolStripMenuItem
            // 
            this.opcionHijaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.opcionHijaToolStripMenuItem.Name = "opcionHijaToolStripMenuItem";
            this.opcionHijaToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.opcionHijaToolStripMenuItem.Text = "Gestión de Roles";
            this.opcionHijaToolStripMenuItem.Click += new System.EventHandler(this.opcionHijaToolStripMenuItem_Click_1);
            // 
            // gestionDePermisosToolStripMenuItem
            // 
            this.gestionDePermisosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.gestionDePermisosToolStripMenuItem.Name = "gestionDePermisosToolStripMenuItem";
            this.gestionDePermisosToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.gestionDePermisosToolStripMenuItem.Text = "Gestión de Permisos";
            this.gestionDePermisosToolStripMenuItem.Click += new System.EventHandler(this.gestionDePermisosToolStripMenuItem_Click);
            // 
            // gestionDeAulasToolStripMenuItem
            // 
            this.gestionDeAulasToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.gestionDeAulasToolStripMenuItem.Name = "gestionDeAulasToolStripMenuItem";
            this.gestionDeAulasToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.gestionDeAulasToolStripMenuItem.Text = "Gestion de Aulas";
            this.gestionDeAulasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeAulasToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.gestionToolStripMenuItem.Text = "Gestion Materias";
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // gestionEspecialidadesToolStripMenuItem
            // 
            this.gestionEspecialidadesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.gestionEspecialidadesToolStripMenuItem.Name = "gestionEspecialidadesToolStripMenuItem";
            this.gestionEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.gestionEspecialidadesToolStripMenuItem.Text = "Gestion Especialidades";
            this.gestionEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.gestionEspecialidadesToolStripMenuItem_Click);
            // 
            // gestionDeAlumnosToolStripMenuItem
            // 
            this.gestionDeAlumnosToolStripMenuItem.Name = "gestionDeAlumnosToolStripMenuItem";
            this.gestionDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.gestionDeAlumnosToolStripMenuItem.Text = "Gestion de Alumnos";
            this.gestionDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeAlumnosToolStripMenuItem_Click);
            // 
            // gestionDeEncargadosToolStripMenuItem
            // 
            this.gestionDeEncargadosToolStripMenuItem.Name = "gestionDeEncargadosToolStripMenuItem";
            this.gestionDeEncargadosToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.gestionDeEncargadosToolStripMenuItem.Text = "Gestion de Encargados";
            this.gestionDeEncargadosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeEncargadosToolStripMenuItem_Click);
            // 
            // gestionDeDocentesToolStripMenuItem
            // 
            this.gestionDeDocentesToolStripMenuItem.Name = "gestionDeDocentesToolStripMenuItem";
            this.gestionDeDocentesToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.gestionDeDocentesToolStripMenuItem.Text = "Gestion de Docentes";
            this.gestionDeDocentesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeDocentesToolStripMenuItem_Click);
            // 
            // gestionDeGradosToolStripMenuItem
            // 
            this.gestionDeGradosToolStripMenuItem.Name = "gestionDeGradosToolStripMenuItem";
            this.gestionDeGradosToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.gestionDeGradosToolStripMenuItem.Text = "Gestion de Grados";
            this.gestionDeGradosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeGradosToolStripMenuItem_Click);
            // 
            // gestionDeMateriasYGradosToolStripMenuItem
            // 
            this.gestionDeMateriasYGradosToolStripMenuItem.Name = "gestionDeMateriasYGradosToolStripMenuItem";
            this.gestionDeMateriasYGradosToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.gestionDeMateriasYGradosToolStripMenuItem.Text = "Gestion de Materias y Grados";
            this.gestionDeMateriasYGradosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeMateriasYGradosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteAulasToolStripMenuItem,
            this.reporteAlumnosToolStripMenuItem,
            this.reporteAlumnosActivosToolStripMenuItem,
            this.reporteMatriculaToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(149, 59);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteAulasToolStripMenuItem
            // 
            this.reporteAulasToolStripMenuItem.Name = "reporteAulasToolStripMenuItem";
            this.reporteAulasToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.reporteAulasToolStripMenuItem.Text = "Reporte Aulas";
            this.reporteAulasToolStripMenuItem.Click += new System.EventHandler(this.reporteAulasToolStripMenuItem_Click);
            // 
            // reporteAlumnosToolStripMenuItem
            // 
            this.reporteAlumnosToolStripMenuItem.Name = "reporteAlumnosToolStripMenuItem";
            this.reporteAlumnosToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.reporteAlumnosToolStripMenuItem.Text = "Reporte alumnos";
            this.reporteAlumnosToolStripMenuItem.Click += new System.EventHandler(this.reporteAlumnosToolStripMenuItem_Click);
            // 
            // reporteAlumnosActivosToolStripMenuItem
            // 
            this.reporteAlumnosActivosToolStripMenuItem.Name = "reporteAlumnosActivosToolStripMenuItem";
            this.reporteAlumnosActivosToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.reporteAlumnosActivosToolStripMenuItem.Text = "Reporte Alumnos Activos";
            this.reporteAlumnosActivosToolStripMenuItem.Click += new System.EventHandler(this.reporteAlumnosActivosToolStripMenuItem_Click);
            // 
            // reporteMatriculaToolStripMenuItem
            // 
            this.reporteMatriculaToolStripMenuItem.Name = "reporteMatriculaToolStripMenuItem";
            this.reporteMatriculaToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.reporteMatriculaToolStripMenuItem.Text = "Reporte Matriculas";
            this.reporteMatriculaToolStripMenuItem.Click += new System.EventHandler(this.reporteMatriculaToolStripMenuItem_Click);
            // 
            // matriculasToolStripMenuItem
            // 
            this.matriculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaMatriculaToolStripMenuItem,
            this.buscarMateriasPorAlumnoToolStripMenuItem});
            this.matriculasToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("matriculasToolStripMenuItem.Image")));
            this.matriculasToolStripMenuItem.Name = "matriculasToolStripMenuItem";
            this.matriculasToolStripMenuItem.Size = new System.Drawing.Size(158, 59);
            this.matriculasToolStripMenuItem.Text = "Matriculas";
            // 
            // nuevaMatriculaToolStripMenuItem
            // 
            this.nuevaMatriculaToolStripMenuItem.Name = "nuevaMatriculaToolStripMenuItem";
            this.nuevaMatriculaToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.nuevaMatriculaToolStripMenuItem.Text = "Nueva Matricula";
            this.nuevaMatriculaToolStripMenuItem.Click += new System.EventHandler(this.nuevaMatriculaToolStripMenuItem_Click);
            // 
            // buscarMateriasPorAlumnoToolStripMenuItem
            // 
            this.buscarMateriasPorAlumnoToolStripMenuItem.Name = "buscarMateriasPorAlumnoToolStripMenuItem";
            this.buscarMateriasPorAlumnoToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.buscarMateriasPorAlumnoToolStripMenuItem.Text = "Buscar Materias Por Alumno";
            this.buscarMateriasPorAlumnoToolStripMenuItem.Click += new System.EventHandler(this.buscarMateriasPorAlumnoToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarNotaToolStripMenuItem,
            this.modificarNotasToolStripMenuItem,
            this.asignarNotasToolStripMenuItem});
            this.notasToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notasToolStripMenuItem.Image")));
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(122, 59);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // asignarNotaToolStripMenuItem
            // 
            this.asignarNotaToolStripMenuItem.Name = "asignarNotaToolStripMenuItem";
            this.asignarNotaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.asignarNotaToolStripMenuItem.Text = "Asignar Nota";
            this.asignarNotaToolStripMenuItem.Click += new System.EventHandler(this.asignarNotaToolStripMenuItem_Click);
            // 
            // modificarNotasToolStripMenuItem
            // 
            this.modificarNotasToolStripMenuItem.Name = "modificarNotasToolStripMenuItem";
            this.modificarNotasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.modificarNotasToolStripMenuItem.Text = "Modificar Notas";
            this.modificarNotasToolStripMenuItem.Click += new System.EventHandler(this.modificarNotasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(111, 59);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblRol,
            this.lblConConexion,
            this.lblSinConexion});
            this.statusStrip.Location = new System.Drawing.Point(0, 482);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 18, 0);
            this.statusStrip.Size = new System.Drawing.Size(1035, 44);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(124, 39);
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblRol
            // 
            this.lblRol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRol.Image = ((System.Drawing.Image)(resources.GetObject("lblRol.Image")));
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(78, 39);
            this.lblRol.Text = "ROL";
            // 
            // lblConConexion
            // 
            this.lblConConexion.Image = ((System.Drawing.Image)(resources.GetObject("lblConConexion.Image")));
            this.lblConConexion.Name = "lblConConexion";
            this.lblConConexion.Size = new System.Drawing.Size(172, 39);
            this.lblConConexion.Text = "CON CONEXION";
            this.lblConConexion.Visible = false;
            // 
            // lblSinConexion
            // 
            this.lblSinConexion.Image = ((System.Drawing.Image)(resources.GetObject("lblSinConexion.Image")));
            this.lblSinConexion.Name = "lblSinConexion";
            this.lblSinConexion.Size = new System.Drawing.Size(163, 39);
            this.lblSinConexion.Text = "SIN CONEXION";
            this.lblSinConexion.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bgwConexion
            // 
            this.bgwConexion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConexion_DoWork);
            this.bgwConexion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConexion_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // asignarNotasToolStripMenuItem
            // 
            this.asignarNotasToolStripMenuItem.Name = "asignarNotasToolStripMenuItem";
            this.asignarNotasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.asignarNotasToolStripMenuItem.Text = "Calificasiones";
            this.asignarNotasToolStripMenuItem.Click += new System.EventHandler(this.asignarNotasToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 526);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem opcionPadreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionHijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDePermisosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
        private System.Windows.Forms.ToolStripMenuItem gestionDeAulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteAulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEncargadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeGradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarNotaToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarNotasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgwConexion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblConConexion;
        private System.Windows.Forms.ToolStripStatusLabel lblSinConexion;
        private System.Windows.Forms.ToolStripMenuItem gestionDeMateriasYGradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMateriasPorAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteAlumnosActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarNotasToolStripMenuItem;
    }
}



