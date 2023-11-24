
namespace Matriculas.GUI
{
    partial class FormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.combAñoLectivo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combCiclo = new System.Windows.Forms.ComboBox();
            this.combGrado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combSeccion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combAñoLectivo
            // 
            this.combAñoLectivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combAñoLectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combAñoLectivo.FormattingEnabled = true;
            this.combAñoLectivo.Location = new System.Drawing.Point(131, 17);
            this.combAñoLectivo.Name = "combAñoLectivo";
            this.combAñoLectivo.Size = new System.Drawing.Size(160, 32);
            this.combAñoLectivo.TabIndex = 109;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 108;
            this.label9.Text = "Año lectivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 112;
            this.label6.Text = "ciclo";
            // 
            // combCiclo
            // 
            this.combCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combCiclo.FormattingEnabled = true;
            this.combCiclo.Location = new System.Drawing.Point(131, 69);
            this.combCiclo.Name = "combCiclo";
            this.combCiclo.Size = new System.Drawing.Size(160, 32);
            this.combCiclo.TabIndex = 113;
            // 
            // combGrado
            // 
            this.combGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combGrado.FormattingEnabled = true;
            this.combGrado.Location = new System.Drawing.Point(424, 17);
            this.combGrado.Name = "combGrado";
            this.combGrado.Size = new System.Drawing.Size(207, 32);
            this.combGrado.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(337, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 114;
            this.label8.Text = "grado";
            // 
            // combSeccion
            // 
            this.combSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combSeccion.FormattingEnabled = true;
            this.combSeccion.Location = new System.Drawing.Point(424, 69);
            this.combSeccion.Name = "combSeccion";
            this.combSeccion.Size = new System.Drawing.Size(207, 32);
            this.combSeccion.TabIndex = 117;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(337, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 116;
            this.label10.Text = "Seccion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(517, 127);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 35);
            this.btnBuscar.TabIndex = 118;
            this.btnBuscar.Text = "Imprimir";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 262);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.combSeccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combGrado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combCiclo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combAñoLectivo);
            this.Controls.Add(this.label9);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox combAñoLectivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox combCiclo;
        public System.Windows.Forms.ComboBox combGrado;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox combSeccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscar;
    }
}