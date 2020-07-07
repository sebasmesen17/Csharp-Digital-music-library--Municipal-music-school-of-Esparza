namespace DataPresentation
{
    partial class FRM_EliminarActualizarObras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EliminarActualizarObras));
            this.gvListaObras = new System.Windows.Forms.DataGridView();
            this.idObra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoObra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPCNSConsultaObrasConAutorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaVirtualEMDataSet21 = new DataPresentation.BibliotecaVirtualEMDataSet2();
            this.tbObrasMusicalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaVirtualEMDataSet = new DataPresentation.BibliotecaVirtualEMDataSet();
            this.tbObrasMusicalesTableAdapter = new DataPresentation.BibliotecaVirtualEMDataSetTableAdapters.tbObrasMusicalesTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.txtTituloObra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cboxAutor = new System.Windows.Forms.ComboBox();
            this.cboxGenero = new System.Windows.Forms.ComboBox();
            this.cboxIntrumento = new System.Windows.Forms.ComboBox();
            this.bibliotecaVirtualEMDataSet2 = new DataPresentation.BibliotecaVirtualEMDataSet2();
            this.vPCNSConsultaObrasConAutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vP_CNS_ConsultaObrasConAutorTableAdapter = new DataPresentation.BibliotecaVirtualEMDataSet2TableAdapters.VP_CNS_ConsultaObrasConAutorTableAdapter();
            this.vPCNSConsultaObrasConAutorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.consultaObrasConAutor = new DataPresentation.ConsultaObrasConAutor();
            this.vP_CNS_ConsultaObrasConAutorTableAdapter1 = new DataPresentation.ConsultaObrasConAutorTableAdapters.VP_CNS_ConsultaObrasConAutorTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaObras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPCNSConsultaObrasConAutorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaVirtualEMDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbObrasMusicalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaVirtualEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaVirtualEMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPCNSConsultaObrasConAutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPCNSConsultaObrasConAutorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaObrasConAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListaObras
            // 
            this.gvListaObras.AllowUserToAddRows = false;
            this.gvListaObras.AutoGenerateColumns = false;
            this.gvListaObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaObras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObra,
            this.codigoObra,
            this.Titulo,
            this.Autor,
            this.Genero,
            this.instrumentoDataGridViewTextBoxColumn});
            this.gvListaObras.DataSource = this.vPCNSConsultaObrasConAutorBindingSource2;
            this.gvListaObras.Location = new System.Drawing.Point(12, 31);
            this.gvListaObras.Name = "gvListaObras";
            this.gvListaObras.ReadOnly = true;
            this.gvListaObras.RowHeadersWidth = 51;
            this.gvListaObras.Size = new System.Drawing.Size(630, 261);
            this.gvListaObras.TabIndex = 0;
            // 
            // idObra
            // 
            this.idObra.DataPropertyName = "idObra";
            this.idObra.HeaderText = "ID Obra";
            this.idObra.MinimumWidth = 6;
            this.idObra.Name = "idObra";
            this.idObra.ReadOnly = true;
            this.idObra.Visible = false;
            this.idObra.Width = 125;
            // 
            // codigoObra
            // 
            this.codigoObra.DataPropertyName = "codigoObra";
            this.codigoObra.HeaderText = "Codigo Obra";
            this.codigoObra.MinimumWidth = 6;
            this.codigoObra.Name = "codigoObra";
            this.codigoObra.ReadOnly = true;
            this.codigoObra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codigoObra.Width = 125;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "nombre";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 125;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "nombreCompleto";
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 125;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 125;
            // 
            // instrumentoDataGridViewTextBoxColumn
            // 
            this.instrumentoDataGridViewTextBoxColumn.DataPropertyName = "instrumento";
            this.instrumentoDataGridViewTextBoxColumn.HeaderText = "Instrumento";
            this.instrumentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instrumentoDataGridViewTextBoxColumn.Name = "instrumentoDataGridViewTextBoxColumn";
            this.instrumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.instrumentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // vPCNSConsultaObrasConAutorBindingSource2
            // 
            this.vPCNSConsultaObrasConAutorBindingSource2.DataMember = "VP_CNS_ConsultaObrasConAutor";
            this.vPCNSConsultaObrasConAutorBindingSource2.DataSource = this.bibliotecaVirtualEMDataSet21;
            // 
            // bibliotecaVirtualEMDataSet21
            // 
            this.bibliotecaVirtualEMDataSet21.DataSetName = "BibliotecaVirtualEMDataSet2";
            this.bibliotecaVirtualEMDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbObrasMusicalesBindingSource
            // 
            this.tbObrasMusicalesBindingSource.DataMember = "tbObrasMusicales";
            this.tbObrasMusicalesBindingSource.DataSource = this.bibliotecaVirtualEMDataSet;
            // 
            // bibliotecaVirtualEMDataSet
            // 
            this.bibliotecaVirtualEMDataSet.DataSetName = "BibliotecaVirtualEMDataSet";
            this.bibliotecaVirtualEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbObrasMusicalesTableAdapter
            // 
            this.tbObrasMusicalesTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.BurlyWood;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(15, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Lista de Obras";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEditar.Location = new System.Drawing.Point(12, 299);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 32);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEliminar.Location = new System.Drawing.Point(93, 299);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 32);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(660, -16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(13, 361);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(681, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mantenimiento Obras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(681, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Codigo Obra:";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(711, 61);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(225, 20);
            this.txtIdentificador.TabIndex = 29;
            // 
            // txtTituloObra
            // 
            this.txtTituloObra.Location = new System.Drawing.Point(712, 116);
            this.txtTituloObra.Name = "txtTituloObra";
            this.txtTituloObra.Size = new System.Drawing.Size(225, 20);
            this.txtTituloObra.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(682, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(682, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Autor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(682, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Genero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(681, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Instrumento:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnActualizar.Location = new System.Drawing.Point(954, 299);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 32);
            this.btnActualizar.TabIndex = 38;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cboxAutor
            // 
            this.cboxAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAutor.FormattingEnabled = true;
            this.cboxAutor.Location = new System.Drawing.Point(710, 170);
            this.cboxAutor.Name = "cboxAutor";
            this.cboxAutor.Size = new System.Drawing.Size(226, 21);
            this.cboxAutor.TabIndex = 39;
            // 
            // cboxGenero
            // 
            this.cboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGenero.FormattingEnabled = true;
            this.cboxGenero.Location = new System.Drawing.Point(712, 225);
            this.cboxGenero.Name = "cboxGenero";
            this.cboxGenero.Size = new System.Drawing.Size(224, 21);
            this.cboxGenero.TabIndex = 40;
            // 
            // cboxIntrumento
            // 
            this.cboxIntrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxIntrumento.FormattingEnabled = true;
            this.cboxIntrumento.Location = new System.Drawing.Point(711, 277);
            this.cboxIntrumento.Name = "cboxIntrumento";
            this.cboxIntrumento.Size = new System.Drawing.Size(226, 21);
            this.cboxIntrumento.TabIndex = 41;
            // 
            // bibliotecaVirtualEMDataSet2
            // 
            this.bibliotecaVirtualEMDataSet2.DataSetName = "BibliotecaVirtualEMDataSet2";
            this.bibliotecaVirtualEMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vPCNSConsultaObrasConAutorBindingSource
            // 
            this.vPCNSConsultaObrasConAutorBindingSource.DataMember = "VP_CNS_ConsultaObrasConAutor";
            this.vPCNSConsultaObrasConAutorBindingSource.DataSource = this.bibliotecaVirtualEMDataSet2;
            // 
            // vP_CNS_ConsultaObrasConAutorTableAdapter
            // 
            this.vP_CNS_ConsultaObrasConAutorTableAdapter.ClearBeforeFill = true;
            // 
            // vPCNSConsultaObrasConAutorBindingSource1
            // 
            this.vPCNSConsultaObrasConAutorBindingSource1.DataMember = "VP_CNS_ConsultaObrasConAutor";
            this.vPCNSConsultaObrasConAutorBindingSource1.DataSource = this.consultaObrasConAutor;
            // 
            // consultaObrasConAutor
            // 
            this.consultaObrasConAutor.DataSetName = "ConsultaObrasConAutor";
            this.consultaObrasConAutor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vP_CNS_ConsultaObrasConAutorTableAdapter1
            // 
            this.vP_CNS_ConsultaObrasConAutorTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalir.Location = new System.Drawing.Point(563, 299);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 32);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FRM_EliminarActualizarObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 334);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cboxIntrumento);
            this.Controls.Add(this.cboxGenero);
            this.Controls.Add(this.cboxAutor);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTituloObra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gvListaObras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_EliminarActualizarObras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar y Actualizar obras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Eliminar_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Eliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListaObras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPCNSConsultaObrasConAutorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaVirtualEMDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbObrasMusicalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaVirtualEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaVirtualEMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPCNSConsultaObrasConAutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPCNSConsultaObrasConAutorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaObrasConAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListaObras;
        private BibliotecaVirtualEMDataSet bibliotecaVirtualEMDataSet;
        private System.Windows.Forms.BindingSource tbObrasMusicalesBindingSource;
        private BibliotecaVirtualEMDataSetTableAdapters.tbObrasMusicalesTableAdapter tbObrasMusicalesTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.TextBox txtTituloObra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cboxAutor;
        private System.Windows.Forms.ComboBox cboxGenero;
        private System.Windows.Forms.ComboBox cboxIntrumento;
        private BibliotecaVirtualEMDataSet2 bibliotecaVirtualEMDataSet2;
        private System.Windows.Forms.BindingSource vPCNSConsultaObrasConAutorBindingSource;
        private BibliotecaVirtualEMDataSet2TableAdapters.VP_CNS_ConsultaObrasConAutorTableAdapter vP_CNS_ConsultaObrasConAutorTableAdapter;
        private ConsultaObrasConAutor consultaObrasConAutor;
        private System.Windows.Forms.BindingSource vPCNSConsultaObrasConAutorBindingSource1;
        private ConsultaObrasConAutorTableAdapters.VP_CNS_ConsultaObrasConAutorTableAdapter vP_CNS_ConsultaObrasConAutorTableAdapter1;
        private BibliotecaVirtualEMDataSet2 bibliotecaVirtualEMDataSet21;
        private System.Windows.Forms.BindingSource vPCNSConsultaObrasConAutorBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSalir;
    }
}