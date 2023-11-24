
namespace Calificasiones
{
    partial class AsignarNotas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarNotas));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combAñoLectivo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combSeccion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combCiclo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combPeriodo = new System.Windows.Forms.ComboBox();
            this.combGrado = new System.Windows.Forms.ComboBox();
            this.combMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.idalumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idperiodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "periodo";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "grado";
            // 
            // combAñoLectivo
            // 
            this.combAñoLectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combAñoLectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combAñoLectivo.FormattingEnabled = true;
            this.combAñoLectivo.Location = new System.Drawing.Point(425, 293);
            this.combAñoLectivo.Name = "combAñoLectivo";
            this.combAñoLectivo.Size = new System.Drawing.Size(248, 28);
            this.combAñoLectivo.TabIndex = 25;
            this.combAñoLectivo.Text = "Seleccione";
            this.combAñoLectivo.SelectionChangeCommitted += new System.EventHandler(this.combAñoLectivo_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(311, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "año lectivo";
            // 
            // combSeccion
            // 
            this.combSeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combSeccion.FormattingEnabled = true;
            this.combSeccion.Location = new System.Drawing.Point(425, 245);
            this.combSeccion.Name = "combSeccion";
            this.combSeccion.Size = new System.Drawing.Size(248, 28);
            this.combSeccion.TabIndex = 27;
            this.combSeccion.Text = "Seleccione";
            this.combSeccion.SelectedIndexChanged += new System.EventHandler(this.combSeccion_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(311, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Seccion";
            // 
            // combCiclo
            // 
            this.combCiclo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combCiclo.FormattingEnabled = true;
            this.combCiclo.Location = new System.Drawing.Point(425, 96);
            this.combCiclo.Name = "combCiclo";
            this.combCiclo.Size = new System.Drawing.Size(248, 28);
            this.combCiclo.TabIndex = 29;
            this.combCiclo.SelectedIndexChanged += new System.EventHandler(this.combCiclo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "ciclo";
            // 
            // combPeriodo
            // 
            this.combPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combPeriodo.FormattingEnabled = true;
            this.combPeriodo.Location = new System.Drawing.Point(425, 41);
            this.combPeriodo.Name = "combPeriodo";
            this.combPeriodo.Size = new System.Drawing.Size(248, 32);
            this.combPeriodo.TabIndex = 102;
            this.combPeriodo.SelectionChangeCommitted += new System.EventHandler(this.combPeriodo_SelectionChangeCommitted);
            // 
            // combGrado
            // 
            this.combGrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combGrado.FormattingEnabled = true;
            this.combGrado.Location = new System.Drawing.Point(425, 140);
            this.combGrado.Name = "combGrado";
            this.combGrado.Size = new System.Drawing.Size(248, 32);
            this.combGrado.TabIndex = 103;
            this.combGrado.SelectionChangeCommitted += new System.EventHandler(this.combGrado_SelectionChangeCommitted);
            // 
            // combMateria
            // 
            this.combMateria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combMateria.FormattingEnabled = true;
            this.combMateria.Location = new System.Drawing.Point(425, 192);
            this.combMateria.Name = "combMateria";
            this.combMateria.Size = new System.Drawing.Size(248, 32);
            this.combMateria.TabIndex = 105;
            this.combMateria.SelectionChangeCommitted += new System.EventHandler(this.combMateria_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "Materia";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalumno,
            this.nombres,
            this.idmateria,
            this.materia,
            this.idmatricula,
            this.anio,
            this.idnota,
            this.nota,
            this.idperiodo,
            this.periodo});
            this.dgvDatos.Location = new System.Drawing.Point(1, 346);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(968, 347);
            this.dgvDatos.TabIndex = 106;
            this.dgvDatos.Visible = false;
            // 
            // idalumno
            // 
            this.idalumno.DataPropertyName = "idalumno";
            this.idalumno.HeaderText = "IdAlumno";
            this.idalumno.Name = "idalumno";
            this.idalumno.ReadOnly = true;
            this.idalumno.Visible = false;
            // 
            // nombres
            // 
            this.nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombres.DataPropertyName = "nombres";
            this.nombres.HeaderText = "Alumno";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // idmateria
            // 
            this.idmateria.DataPropertyName = "idmateria";
            this.idmateria.HeaderText = "IdMateria";
            this.idmateria.Name = "idmateria";
            this.idmateria.ReadOnly = true;
            this.idmateria.Visible = false;
            // 
            // materia
            // 
            this.materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materia.DataPropertyName = "materia";
            this.materia.HeaderText = "Materia";
            this.materia.Name = "materia";
            this.materia.ReadOnly = true;
            // 
            // idmatricula
            // 
            this.idmatricula.DataPropertyName = "idmatricula";
            this.idmatricula.HeaderText = "ID";
            this.idmatricula.Name = "idmatricula";
            this.idmatricula.ReadOnly = true;
            this.idmatricula.Visible = false;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            // 
            // idnota
            // 
            this.idnota.DataPropertyName = "idnota";
            this.idnota.HeaderText = "IdNota";
            this.idnota.Name = "idnota";
            this.idnota.ReadOnly = true;
            this.idnota.Visible = false;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "nota";
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            // 
            // idperiodo
            // 
            this.idperiodo.DataPropertyName = "idperiodo";
            this.idperiodo.HeaderText = "IdPeriodo";
            this.idperiodo.Name = "idperiodo";
            this.idperiodo.ReadOnly = true;
            this.idperiodo.Visible = false;
            // 
            // periodo
            // 
            this.periodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.periodo.DataPropertyName = "periodo";
            this.periodo.HeaderText = "Periodo";
            this.periodo.Name = "periodo";
            this.periodo.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(853, 702);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 36);
            this.btnGuardar.TabIndex = 108;
            this.btnGuardar.Tag = "";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // AsignarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 743);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.combMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combGrado);
            this.Controls.Add(this.combPeriodo);
            this.Controls.Add(this.combCiclo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combSeccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combAñoLectivo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AsignarNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AsignarNotas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AsignarNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox combAñoLectivo;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox combSeccion;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox combCiclo;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox combPeriodo;
        public System.Windows.Forms.ComboBox combGrado;
        public System.Windows.Forms.ComboBox combMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnota;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn idperiodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.Button btnGuardar;
    }
}