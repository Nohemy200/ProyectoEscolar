
namespace General.GUI
{
    partial class GradosGestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradosGestion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dtgvGenero = new System.Windows.Forms.DataGridView();
            this.idgenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgvGrado = new System.Windows.Forms.DataGridView();
            this.idgrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idaula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroaula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenero)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrado)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnEliminar,
            this.toolStripSeparator1,
            this.btnEditar,
            this.toolStripSeparator3,
            this.btnAgregar,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(453, 42);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 39);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 39);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 39);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 42);
            // 
            // dtgvGenero
            // 
            this.dtgvGenero.AllowUserToAddRows = false;
            this.dtgvGenero.AllowUserToDeleteRows = false;
            this.dtgvGenero.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvGenero.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvGenero.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvGenero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvGenero.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGenero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgenero,
            this.genero});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvGenero.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvGenero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvGenero.Location = new System.Drawing.Point(0, 0);
            this.dtgvGenero.MultiSelect = false;
            this.dtgvGenero.Name = "dtgvGenero";
            this.dtgvGenero.ReadOnly = true;
            this.dtgvGenero.RowHeadersVisible = false;
            this.dtgvGenero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvGenero.Size = new System.Drawing.Size(453, 355);
            this.dtgvGenero.TabIndex = 11;
            // 
            // idgenero
            // 
            this.idgenero.DataPropertyName = "idgenero";
            this.idgenero.HeaderText = "ID";
            this.idgenero.Name = "idgenero";
            this.idgenero.ReadOnly = true;
            // 
            // genero
            // 
            this.genero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(453, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BackColor = System.Drawing.SystemColors.Control;
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(133, 17);
            this.lblRegistros.Text = "0 Registros Encontrados";
            // 
            // dtgvGrado
            // 
            this.dtgvGrado.AllowUserToAddRows = false;
            this.dtgvGrado.AllowUserToDeleteRows = false;
            this.dtgvGrado.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvGrado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvGrado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvGrado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvGrado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvGrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgrado,
            this.grado,
            this.idaula,
            this.numeroaula,
            this.iddocente,
            this.nombresDocente});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvGrado.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvGrado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvGrado.Location = new System.Drawing.Point(0, 42);
            this.dtgvGrado.MultiSelect = false;
            this.dtgvGrado.Name = "dtgvGrado";
            this.dtgvGrado.ReadOnly = true;
            this.dtgvGrado.RowHeadersVisible = false;
            this.dtgvGrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvGrado.Size = new System.Drawing.Size(453, 313);
            this.dtgvGrado.TabIndex = 12;
            // 
            // idgrado
            // 
            this.idgrado.DataPropertyName = "idgrado";
            this.idgrado.HeaderText = "ID";
            this.idgrado.Name = "idgrado";
            this.idgrado.ReadOnly = true;
            this.idgrado.Width = 50;
            // 
            // grado
            // 
            this.grado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grado.DataPropertyName = "grado";
            this.grado.HeaderText = "Grado";
            this.grado.Name = "grado";
            this.grado.ReadOnly = true;
            // 
            // idaula
            // 
            this.idaula.DataPropertyName = "idaula";
            this.idaula.HeaderText = "ID Aula";
            this.idaula.Name = "idaula";
            this.idaula.ReadOnly = true;
            this.idaula.Visible = false;
            // 
            // numeroaula
            // 
            this.numeroaula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroaula.DataPropertyName = "numeroaula";
            this.numeroaula.HeaderText = "Num Aula";
            this.numeroaula.Name = "numeroaula";
            this.numeroaula.ReadOnly = true;
            // 
            // iddocente
            // 
            this.iddocente.DataPropertyName = "iddocente";
            this.iddocente.HeaderText = "ID Docente";
            this.iddocente.Name = "iddocente";
            this.iddocente.ReadOnly = true;
            this.iddocente.Visible = false;
            // 
            // nombresDocente
            // 
            this.nombresDocente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombresDocente.DataPropertyName = "nombresDocente";
            this.nombresDocente.HeaderText = "Nombres Docente";
            this.nombresDocente.Name = "nombresDocente";
            this.nombresDocente.ReadOnly = true;
            // 
            // GradosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 377);
            this.Controls.Add(this.dtgvGrado);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtgvGenero);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GradosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GradosGestion";
            this.Load += new System.EventHandler(this.GradosGestion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenero)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridView dtgvGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistros;
        private System.Windows.Forms.DataGridView dtgvGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaula;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroaula;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDocente;
    }
}