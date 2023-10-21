
namespace Asistencia.GUI
{
    partial class AsistenciaGestion
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
            this.btnGuardar = new System.Windows.Forms.Button();
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
            this.combMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combGrado = new System.Windows.Forms.ComboBox();
            this.combPeriodo = new System.Windows.Forms.ComboBox();
            this.combCiclo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combSeccion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combAñoLectivo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(894, 649);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 122;
            this.btnGuardar.Tag = "";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
//            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
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
            this.dgvDatos.Location = new System.Drawing.Point(25, 346);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(944, 294);
            this.dgvDatos.TabIndex = 121;
            this.dgvDatos.Visible = false;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
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
            // combMateria
            // 
            this.combMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combMateria.FormattingEnabled = true;
            this.combMateria.Location = new System.Drawing.Point(428, 158);
            this.combMateria.Name = "combMateria";
            this.combMateria.Size = new System.Drawing.Size(248, 32);
            this.combMateria.TabIndex = 120;
            this.combMateria.SelectedIndexChanged += new System.EventHandler(this.combMateria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 119;
            this.label1.Text = "Materia";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // combGrado
            // 
            this.combGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combGrado.FormattingEnabled = true;
            this.combGrado.Location = new System.Drawing.Point(428, 106);
            this.combGrado.Name = "combGrado";
            this.combGrado.Size = new System.Drawing.Size(248, 32);
            this.combGrado.TabIndex = 118;
            this.combGrado.SelectedIndexChanged += new System.EventHandler(this.combGrado_SelectedIndexChanged);
            // 
            // combPeriodo
            // 
            this.combPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combPeriodo.FormattingEnabled = true;
            this.combPeriodo.Location = new System.Drawing.Point(428, 7);
            this.combPeriodo.Name = "combPeriodo";
            this.combPeriodo.Size = new System.Drawing.Size(248, 32);
            this.combPeriodo.TabIndex = 117;
            this.combPeriodo.SelectedIndexChanged += new System.EventHandler(this.combPeriodo_SelectedIndexChanged);
            // 
            // combCiclo
            // 
            this.combCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combCiclo.FormattingEnabled = true;
            this.combCiclo.Location = new System.Drawing.Point(428, 62);
            this.combCiclo.Name = "combCiclo";
            this.combCiclo.Size = new System.Drawing.Size(248, 28);
            this.combCiclo.TabIndex = 116;
            this.combCiclo.SelectedIndexChanged += new System.EventHandler(this.combCiclo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 115;
            this.label6.Text = "ciclo";
            //this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // combSeccion
            // 
            this.combSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combSeccion.FormattingEnabled = true;
            this.combSeccion.Location = new System.Drawing.Point(428, 211);
            this.combSeccion.Name = "combSeccion";
            this.combSeccion.Size = new System.Drawing.Size(248, 28);
            this.combSeccion.TabIndex = 114;
            this.combSeccion.Text = "Seleccione";
            this.combSeccion.SelectedIndexChanged += new System.EventHandler(this.combSeccion_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(314, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 113;
            this.label10.Text = "Seccion";
            //this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // combAñoLectivo
            // 
            this.combAñoLectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combAñoLectivo.FormattingEnabled = true;
            this.combAñoLectivo.Location = new System.Drawing.Point(428, 259);
            this.combAñoLectivo.Name = "combAñoLectivo";
            this.combAñoLectivo.Size = new System.Drawing.Size(248, 28);
            this.combAñoLectivo.TabIndex = 112;
            this.combAñoLectivo.Text = "Seleccione";
            this.combAñoLectivo.SelectedIndexChanged += new System.EventHandler(this.combAñoLectivo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(314, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 111;
            this.label9.Text = "año lectivo";
            //this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(314, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 110;
            this.label8.Text = "grado";
            //this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 109;
            this.label7.Text = "periodo";
            //this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 123;
            this.label2.Text = "año lectivo";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy/MM/dd";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(428, 305);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(248, 26);
            this.dtpFecha.TabIndex = 124;
            // 
            // AsistenciaGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 680);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
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
            this.Name = "AsistenciaGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsistenciaGestion";
            this.Load += new System.EventHandler(this.AsistenciaGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
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
        public System.Windows.Forms.ComboBox combMateria;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox combGrado;
        public System.Windows.Forms.ComboBox combPeriodo;
        public System.Windows.Forms.ComboBox combCiclo;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox combSeccion;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox combAñoLectivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}