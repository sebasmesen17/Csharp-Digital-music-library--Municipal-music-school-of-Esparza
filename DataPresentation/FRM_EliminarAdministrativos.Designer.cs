namespace DataPresentation
{
    partial class FRM_EliminarAdministrativos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EliminarAdministrativos));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gvListaAdministradores = new System.Windows.Forms.DataGridView();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAdministradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaAdministrador = new DataPresentation.ConsultaAdministrador();
            this.tbAdministradorTableAdapter = new DataPresentation.ConsultaAdministradorTableAdapters.tbAdministradorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaAdministradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAdministradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaAdministrador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalir.Location = new System.Drawing.Point(383, 367);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 39);
            this.btnSalir.TabIndex = 60;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEliminar.Location = new System.Drawing.Point(16, 367);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 39);
            this.btnEliminar.TabIndex = 59;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.BurlyWood;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 23);
            this.label9.TabIndex = 57;
            this.label9.Text = "Lista de Administradores";
            // 
            // gvListaAdministradores
            // 
            this.gvListaAdministradores.AllowUserToAddRows = false;
            this.gvListaAdministradores.AutoGenerateColumns = false;
            this.gvListaAdministradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaAdministradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn});
            this.gvListaAdministradores.DataSource = this.tbAdministradorBindingSource;
            this.gvListaAdministradores.Location = new System.Drawing.Point(16, 38);
            this.gvListaAdministradores.Margin = new System.Windows.Forms.Padding(4);
            this.gvListaAdministradores.Name = "gvListaAdministradores";
            this.gvListaAdministradores.ReadOnly = true;
            this.gvListaAdministradores.RowHeadersWidth = 51;
            this.gvListaAdministradores.Size = new System.Drawing.Size(472, 321);
            this.gvListaAdministradores.TabIndex = 56;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cedulaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "nombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.nombreCompletoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCompletoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbAdministradorBindingSource
            // 
            this.tbAdministradorBindingSource.DataMember = "tbAdministrador";
            this.tbAdministradorBindingSource.DataSource = this.consultaAdministrador;
            // 
            // consultaAdministrador
            // 
            this.consultaAdministrador.DataSetName = "ConsultaAdministrador";
            this.consultaAdministrador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAdministradorTableAdapter
            // 
            this.tbAdministradorTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_EliminarAdministrativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 415);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gvListaAdministradores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_EliminarAdministrativos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Administrativos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_EliminarAdministrativos_FormClosed);
            this.Load += new System.EventHandler(this.FRM_EliminarAdministrativos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListaAdministradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAdministradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaAdministrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gvListaAdministradores;
        private ConsultaAdministrador consultaAdministrador;
        private System.Windows.Forms.BindingSource tbAdministradorBindingSource;
        private ConsultaAdministradorTableAdapters.tbAdministradorTableAdapter tbAdministradorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
    }
}