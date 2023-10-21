namespace General.GUI
{
    partial class PermisosGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermisosGestion));
            this.combRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvPermisos = new System.Windows.Forms.DataGridView();
            this.Asignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDOpcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDClasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // combRol
            // 
            this.combRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combRol.FormattingEnabled = true;
            this.combRol.Items.AddRange(new object[] {
            "Administrador",
            "Docente"});
            this.combRol.Location = new System.Drawing.Point(12, 34);
            this.combRol.Name = "combRol";
            this.combRol.Size = new System.Drawing.Size(310, 21);
            this.combRol.TabIndex = 0;
            this.combRol.SelectedValueChanged += new System.EventHandler(this.cbbRoles_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el rol";
            // 
            // dtgvPermisos
            // 
            this.dtgvPermisos.AllowUserToAddRows = false;
            this.dtgvPermisos.AllowUserToDeleteRows = false;
            this.dtgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignado,
            this.IDOpcion,
            this.Opcion,
            this.IDClasificacion,
            this.Clasificacion,
            this.IDPermiso});
            this.dtgvPermisos.Location = new System.Drawing.Point(12, 71);
            this.dtgvPermisos.Name = "dtgvPermisos";
            this.dtgvPermisos.ReadOnly = true;
            this.dtgvPermisos.RowHeadersVisible = false;
            this.dtgvPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPermisos.Size = new System.Drawing.Size(492, 292);
            this.dtgvPermisos.TabIndex = 2;
            this.dtgvPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPermisos_CellContentClick);
            // 
            // Asignado
            // 
            this.Asignado.DataPropertyName = "Asignado";
            this.Asignado.HeaderText = "";
            this.Asignado.Name = "Asignado";
            this.Asignado.ReadOnly = true;
            this.Asignado.Width = 40;
            // 
            // IDOpcion
            // 
            this.IDOpcion.DataPropertyName = "IDOpcion";
            this.IDOpcion.HeaderText = "ID";
            this.IDOpcion.Name = "IDOpcion";
            this.IDOpcion.ReadOnly = true;
            this.IDOpcion.Width = 60;
            // 
            // Opcion
            // 
            this.Opcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opcion.DataPropertyName = "Opcion";
            this.Opcion.HeaderText = "Opcion";
            this.Opcion.Name = "Opcion";
            this.Opcion.ReadOnly = true;
            // 
            // IDClasificacion
            // 
            this.IDClasificacion.DataPropertyName = "IDClasificacion";
            this.IDClasificacion.HeaderText = "IDClasificacion";
            this.IDClasificacion.Name = "IDClasificacion";
            this.IDClasificacion.ReadOnly = true;
            this.IDClasificacion.Visible = false;
            // 
            // Clasificacion
            // 
            this.Clasificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Clasificacion.DataPropertyName = "Clasificacion";
            this.Clasificacion.HeaderText = "Clasificacion";
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.ReadOnly = true;
            // 
            // IDPermiso
            // 
            this.IDPermiso.DataPropertyName = "IDPermiso";
            this.IDPermiso.HeaderText = "IDPermiso";
            this.IDPermiso.Name = "IDPermiso";
            this.IDPermiso.ReadOnly = true;
            this.IDPermiso.Visible = false;
            // 
            // PermisosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 498);
            this.Controls.Add(this.dtgvPermisos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combRol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PermisosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PermisosGestion";
            this.Load += new System.EventHandler(this.PermisosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvPermisos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOpcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDClasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPermiso;
    }
}