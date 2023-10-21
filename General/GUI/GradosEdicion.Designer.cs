
namespace General.GUI
{
    partial class GradosEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradosEdicion));
            this.txtIdGrado = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdAula = new System.Windows.Forms.TextBox();
            this.btnAula = new System.Windows.Forms.Button();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdDocente = new System.Windows.Forms.TextBox();
            this.btnDocente = new System.Windows.Forms.Button();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combGrado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtIdGrado
            // 
            this.txtIdGrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGrado.Location = new System.Drawing.Point(138, 39);
            this.txtIdGrado.Name = "txtIdGrado";
            this.txtIdGrado.ReadOnly = true;
            this.txtIdGrado.Size = new System.Drawing.Size(130, 26);
            this.txtIdGrado.TabIndex = 22;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(176, 173);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 35);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(29, 173);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 35);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Grado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Grado";
            // 
            // txtIdAula
            // 
            this.txtIdAula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAula.Location = new System.Drawing.Point(437, 38);
            this.txtIdAula.Name = "txtIdAula";
            this.txtIdAula.ReadOnly = true;
            this.txtIdAula.Size = new System.Drawing.Size(100, 26);
            this.txtIdAula.TabIndex = 81;
            this.txtIdAula.Visible = false;
            // 
            // btnAula
            // 
            this.btnAula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAula.BackgroundImage")));
            this.btnAula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAula.Location = new System.Drawing.Point(631, 38);
            this.btnAula.Name = "btnAula";
            this.btnAula.Size = new System.Drawing.Size(33, 26);
            this.btnAula.TabIndex = 80;
            this.btnAula.UseVisualStyleBackColor = true;
            this.btnAula.Click += new System.EventHandler(this.btnAula_Click);
            // 
            // txtAula
            // 
            this.txtAula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAula.Location = new System.Drawing.Point(437, 39);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(187, 26);
            this.txtAula.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "Aula";
            // 
            // txtIdDocente
            // 
            this.txtIdDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDocente.Location = new System.Drawing.Point(437, 87);
            this.txtIdDocente.Name = "txtIdDocente";
            this.txtIdDocente.ReadOnly = true;
            this.txtIdDocente.Size = new System.Drawing.Size(100, 26);
            this.txtIdDocente.TabIndex = 85;
            this.txtIdDocente.Visible = false;
            // 
            // btnDocente
            // 
            this.btnDocente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDocente.BackgroundImage")));
            this.btnDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDocente.Location = new System.Drawing.Point(631, 87);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.Size = new System.Drawing.Size(33, 26);
            this.btnDocente.TabIndex = 84;
            this.btnDocente.UseVisualStyleBackColor = true;
            this.btnDocente.Click += new System.EventHandler(this.btnDocente_Click);
            // 
            // txtDocente
            // 
            this.txtDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocente.Location = new System.Drawing.Point(437, 88);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(187, 26);
            this.txtDocente.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 82;
            this.label3.Text = "Docente";
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
            this.combGrado.Location = new System.Drawing.Point(138, 96);
            this.combGrado.Name = "combGrado";
            this.combGrado.Size = new System.Drawing.Size(130, 21);
            this.combGrado.TabIndex = 86;
            // 
            // GradosEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(691, 242);
            this.Controls.Add(this.combGrado);
            this.Controls.Add(this.txtIdDocente);
            this.Controls.Add(this.btnDocente);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdAula);
            this.Controls.Add(this.btnAula);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdGrado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GradosEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GradosEdicion";
            this.Load += new System.EventHandler(this.GradosEdicion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtIdGrado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtIdAula;
        private System.Windows.Forms.Button btnAula;
        public System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtIdDocente;
        private System.Windows.Forms.Button btnDocente;
        public System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox combGrado;
    }
}