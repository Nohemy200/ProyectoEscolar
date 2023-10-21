
namespace FormulariosDeSeleccion.GUI
{
    partial class BuscarApoderado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarApoderado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dtgvApoderado = new System.Windows.Forms.DataGridView();
            this.idapoderado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiporelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresapoderado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvApoderado)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(852, 22);
            this.statusStrip1.TabIndex = 69;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BackColor = System.Drawing.SystemColors.Control;
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(133, 17);
            this.lblRegistros.Text = "0 Registros Encontrados";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(257, 20);
            this.label12.TabIndex = 68;
            this.label12.Text = "Buscar Apoderado Por Nombre";
            // 
            // txtDui
            // 
            this.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDui.Location = new System.Drawing.Point(275, 17);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(315, 26);
            this.txtDui.TabIndex = 67;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(745, 9);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(106, 42);
            this.btnSeleccionar.TabIndex = 66;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dtgvApoderado
            // 
            this.dtgvApoderado.AllowUserToAddRows = false;
            this.dtgvApoderado.AllowUserToDeleteRows = false;
            this.dtgvApoderado.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvApoderado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvApoderado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvApoderado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvApoderado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvApoderado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idapoderado,
            this.dui,
            this.fechanacimiento,
            this.tiporelacion,
            this.nombresapoderado,
            this.apellidos,
            this.telefono,
            this.iddireccion,
            this.direccion,
            this.idgenero,
            this.genero});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvApoderado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvApoderado.Location = new System.Drawing.Point(0, 59);
            this.dtgvApoderado.MultiSelect = false;
            this.dtgvApoderado.Name = "dtgvApoderado";
            this.dtgvApoderado.ReadOnly = true;
            this.dtgvApoderado.RowHeadersVisible = false;
            this.dtgvApoderado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvApoderado.Size = new System.Drawing.Size(851, 326);
            this.dtgvApoderado.TabIndex = 70;
            // 
            // idapoderado
            // 
            this.idapoderado.DataPropertyName = "idapoderado";
            this.idapoderado.HeaderText = "ID";
            this.idapoderado.Name = "idapoderado";
            this.idapoderado.ReadOnly = true;
            this.idapoderado.Width = 50;
            // 
            // dui
            // 
            this.dui.DataPropertyName = "dui";
            this.dui.HeaderText = "Dui";
            this.dui.Name = "dui";
            this.dui.ReadOnly = true;
            this.dui.Visible = false;
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.DataPropertyName = "fechanacimiento";
            this.fechanacimiento.HeaderText = "Fecha Nacimiento";
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.ReadOnly = true;
            this.fechanacimiento.Visible = false;
            // 
            // tiporelacion
            // 
            this.tiporelacion.DataPropertyName = "tiporelacion";
            this.tiporelacion.HeaderText = "Encargado";
            this.tiporelacion.Name = "tiporelacion";
            this.tiporelacion.ReadOnly = true;
            // 
            // nombresapoderado
            // 
            this.nombresapoderado.DataPropertyName = "nombresapoderado";
            this.nombresapoderado.HeaderText = "Nombres Apoderado";
            this.nombresapoderado.Name = "nombresapoderado";
            this.nombresapoderado.ReadOnly = true;
            this.nombresapoderado.Width = 200;
            // 
            // apellidos
            // 
            this.apellidos.DataPropertyName = "apellidos";
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            this.apellidos.Width = 200;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // iddireccion
            // 
            this.iddireccion.DataPropertyName = "iddireccion";
            this.iddireccion.HeaderText = "ID Direccion";
            this.iddireccion.Name = "iddireccion";
            this.iddireccion.ReadOnly = true;
            this.iddireccion.Visible = false;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // idgenero
            // 
            this.idgenero.DataPropertyName = "idgenero";
            this.idgenero.HeaderText = "ID Genero";
            this.idgenero.Name = "idgenero";
            this.idgenero.ReadOnly = true;
            this.idgenero.Visible = false;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // BuscarApoderado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 422);
            this.Controls.Add(this.dtgvApoderado);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.btnSeleccionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarApoderado";
            this.Text = "BuscarApoderado";
            this.Load += new System.EventHandler(this.BuscarApoderado_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvApoderado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistros;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtDui;
        public System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dtgvApoderado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idapoderado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiporelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresapoderado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
    }
}