
namespace Matriculas.GUI
{
    partial class MatriculaGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatriculaGestion));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApoderado = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvMatricula = new System.Windows.Forms.DataGridView();
            this.idmatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechamatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idapoderado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresapoderado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combTurno = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combGrado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatricula)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(159, 634);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 35);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 634);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 35);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnApoderado);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 134);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Alumno";
            // 
            // btnApoderado
            // 
            this.btnApoderado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApoderado.BackgroundImage")));
            this.btnApoderado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApoderado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApoderado.Location = new System.Drawing.Point(398, 93);
            this.btnApoderado.Name = "btnApoderado";
            this.btnApoderado.Size = new System.Drawing.Size(38, 25);
            this.btnApoderado.TabIndex = 75;
            this.btnApoderado.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(154, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 26);
            this.textBox3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre Alumno";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(57, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 26);
            this.textBox2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "NIE";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(470, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 134);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Encargado";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(178, 59);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(238, 26);
            this.textBox4.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 25);
            this.button1.TabIndex = 76;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre Encargado";
            // 
            // dtgvMatricula
            // 
            this.dtgvMatricula.AllowUserToAddRows = false;
            this.dtgvMatricula.AllowUserToDeleteRows = false;
            this.dtgvMatricula.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMatricula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmatricula,
            this.fechamatricula,
            this.turno,
            this.idgrado,
            this.grado,
            this.idalumno,
            this.nombres,
            this.idapoderado,
            this.nombresapoderado});
            this.dtgvMatricula.Location = new System.Drawing.Point(2, 285);
            this.dtgvMatricula.Name = "dtgvMatricula";
            this.dtgvMatricula.ReadOnly = true;
            this.dtgvMatricula.Size = new System.Drawing.Size(955, 331);
            this.dtgvMatricula.TabIndex = 89;
            // 
            // idmatricula
            // 
            this.idmatricula.HeaderText = "ID Matricula";
            this.idmatricula.Name = "idmatricula";
            this.idmatricula.ReadOnly = true;
            // 
            // fechamatricula
            // 
            this.fechamatricula.DataPropertyName = "fechamatricula";
            this.fechamatricula.HeaderText = "Fecha Matricula";
            this.fechamatricula.Name = "fechamatricula";
            this.fechamatricula.ReadOnly = true;
            this.fechamatricula.Width = 150;
            // 
            // turno
            // 
            this.turno.DataPropertyName = "turno";
            this.turno.HeaderText = "Turno";
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            this.turno.Width = 130;
            // 
            // idgrado
            // 
            this.idgrado.DataPropertyName = "idgrado";
            this.idgrado.HeaderText = "ID Grado";
            this.idgrado.Name = "idgrado";
            this.idgrado.ReadOnly = true;
            this.idgrado.Visible = false;
            // 
            // grado
            // 
            this.grado.HeaderText = "Grado";
            this.grado.Name = "grado";
            this.grado.ReadOnly = true;
            this.grado.Width = 130;
            // 
            // idalumno
            // 
            this.idalumno.DataPropertyName = "idalumno";
            this.idalumno.HeaderText = "ID Alumno";
            this.idalumno.Name = "idalumno";
            this.idalumno.ReadOnly = true;
            this.idalumno.Visible = false;
            // 
            // nombres
            // 
            this.nombres.HeaderText = "Nombres Alumno";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            this.nombres.Width = 190;
            // 
            // idapoderado
            // 
            this.idapoderado.DataPropertyName = "idapoderado";
            this.idapoderado.HeaderText = "ID Apoderado";
            this.idapoderado.Name = "idapoderado";
            this.idapoderado.ReadOnly = true;
            this.idapoderado.Visible = false;
            // 
            // nombresapoderado
            // 
            this.nombresapoderado.HeaderText = "Nom Apoderado";
            this.nombresapoderado.Name = "nombresapoderado";
            this.nombresapoderado.ReadOnly = true;
            this.nombresapoderado.Width = 195;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.combTurno);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.combGrado);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtIdMatricula);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpFecha);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(932, 114);
            this.groupBox3.TabIndex = 90;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Matricula";
            // 
            // combTurno
            // 
            this.combTurno.FormattingEnabled = true;
            this.combTurno.Items.AddRange(new object[] {
            "MATUTINO",
            "VESPERTINO"});
            this.combTurno.Location = new System.Drawing.Point(365, 24);
            this.combTurno.Name = "combTurno";
            this.combTurno.Size = new System.Drawing.Size(329, 32);
            this.combTurno.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 88;
            this.label7.Tag = "";
            this.label7.Text = "Turno";
            // 
            // combGrado
            // 
            this.combGrado.FormattingEnabled = true;
            this.combGrado.Items.AddRange(new object[] {
            "PALVULARIA",
            "1°GRADO",
            "2°GRADO",
            "3°GRADO",
            "4°GRADO",
            "5°GRADO",
            "6°GRADO",
            "7°GRADO",
            "9°GRADO"});
            this.combGrado.Location = new System.Drawing.Point(127, 70);
            this.combGrado.Name = "combGrado";
            this.combGrado.Size = new System.Drawing.Size(130, 32);
            this.combGrado.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 80;
            this.label3.Tag = "";
            this.label3.Text = "Grado";
            // 
            // txtIdMatricula
            // 
            this.txtIdMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMatricula.Location = new System.Drawing.Point(127, 30);
            this.txtIdMatricula.Name = "txtIdMatricula";
            this.txtIdMatricula.ReadOnly = true;
            this.txtIdMatricula.Size = new System.Drawing.Size(130, 26);
            this.txtIdMatricula.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 77;
            this.label1.Tag = "";
            this.label1.Text = "ID Matricula";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(433, 70);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(261, 26);
            this.dtpFecha.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Matricula";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MatriculaGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(956, 681);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtgvMatricula);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatriculaGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatriculaEdicion";
            this.Load += new System.EventHandler(this.MatriculaEdicion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatricula)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnApoderado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvMatricula;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.TextBox txtIdMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox combTurno;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox combGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechamatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn idapoderado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresapoderado;
    }
}