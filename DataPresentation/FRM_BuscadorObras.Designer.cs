namespace DataPresentation
{
    partial class FRM_BuscadorObras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BuscadorObras));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxGenero = new System.Windows.Forms.ComboBox();
            this.cboxAutor = new System.Windows.Forms.ComboBox();
            this.gvBuscadorObras = new System.Windows.Forms.DataGridView();
            this.idObra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPCNSConsultaObrasConAutorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.consultaObrasConAutorVisualizar = new DataPresentation.ConsultaObrasConAutorVisualizar();
            this.vPCNSConsultaObrasConAutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaVirtualEMDataSet1 = new DataPresentation.BibliotecaVirtualEMDataSet1();
            this.bibliotecaVirtualEMDataSet = new DataPresentation.BibliotecaVirtualEMDataSet();
            this.bibliotecaVirtualEMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbObrasMusicalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbObrasMusicalesTableAdapter = new DataPresentation.BibliotecaVirtualEMDataSetTableAdapters.tbObrasMusicalesTableAdapter();
            this.vP_CNS_ConsultaObrasConAutorTableAdapter = new DataPresentation.BibliotecaVirtualEMDataSet1TableAdapters.VP_CNS_ConsultaObrasConAutorTableAdapter();
            this.checkBoxGenero = new System.Windows.Forms.CheckBox();
            this.checkBoxAutor = new System.Windows.Forms.CheckBox();
            this.vP_CNS_ConsultaObrasConAutorTableAdapter1 = new DataPresentation.ConsultaObrasConAutorVisualizarTableAdapters.VP_CNS_ConsultaObrasConAutorTableAdapter();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvBuscadorObras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPCNSConsultaObrasConAutorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaObrasConAutorVisualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPCNSConsultaObrasConAutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaVirtualEMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaVirtualEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaVirtualEMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbObrasMusicalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(278, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Buscador de obras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Género";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BurlyWood;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(419, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Autor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(224, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 19);
            this.label9.TabIndex = 30;
            // 
            // cboxGenero
            // 
            this.cboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGenero.FormattingEnabled = true;
            this.cboxGenero.Location = new System.Drawing.Point(94, 87);
            this.cboxGenero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxGenero.Name = "cboxGenero";
            this.cboxGenero.Size = new System.Drawing.Size(198, 21);
            this.cboxGenero.TabIndex = 31;
            this.cboxGenero.SelectedIndexChanged += new System.EventHandler(this.cboxGenero_SelectedIndexChanged);
            // 
            // cboxAutor
            // 
            this.cboxAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAutor.FormattingEnabled = true;
            this.cboxAutor.Location = new System.Drawing.Point(481, 90);
            this.cboxAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxAutor.Name = "cboxAutor";
            this.cboxAutor.Size = new System.Drawing.Size(198, 21);
            this.cboxAutor.TabIndex = 32;
            this.cboxAutor.SelectedIndexChanged += new System.EventHandler(this.cboxAutor_SelectedIndexChanged);
            // 
            // gvBuscadorObras
            // 
            this.gvBuscadorObras.AllowUserToAddRows = false;
            this.gvBuscadorObras.AutoGenerateColumns = false;
            this.gvBuscadorObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBuscadorObras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObra,
            this.codigoObraDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.instrumentoDataGridViewTextBoxColumn,
            this.nombreCompleto,
            this.Genero});
            this.gvBuscadorObras.DataSource = this.vPCNSConsultaObrasConAutorBindingSource1;
            this.gvBuscadorObras.Location = new System.Drawing.Point(24, 150);
            this.gvBuscadorObras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvBuscadorObras.Name = "gvBuscadorObras";
            this.gvBuscadorObras.RowHeadersWidth = 51;
            this.gvBuscadorObras.RowTemplate.Height = 24;
            this.gvBuscadorObras.Size = new System.Drawing.Size(655, 188);
            this.gvBuscadorObras.TabIndex = 33;
            // 
            // idObra
            // 
            this.idObra.DataPropertyName = "idObra";
            this.idObra.HeaderText = "idObra";
            this.idObra.MinimumWidth = 6;
            this.idObra.Name = "idObra";
            this.idObra.Visible = false;
            this.idObra.Width = 125;
            // 
            // codigoObraDataGridViewTextBoxColumn
            // 
            this.codigoObraDataGridViewTextBoxColumn.DataPropertyName = "codigoObra";
            this.codigoObraDataGridViewTextBoxColumn.HeaderText = "Codigo Obra";
            this.codigoObraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoObraDataGridViewTextBoxColumn.Name = "codigoObraDataGridViewTextBoxColumn";
            this.codigoObraDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoObraDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
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
            // nombreCompleto
            // 
            this.nombreCompleto.DataPropertyName = "nombreCompleto";
            this.nombreCompleto.HeaderText = "Autor";
            this.nombreCompleto.MinimumWidth = 6;
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.Width = 125;
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
            // vPCNSConsultaObrasConAutorBindingSource1
            // 
            this.vPCNSConsultaObrasConAutorBindingSource1.DataMember = "VP_CNS_ConsultaObrasConAutor";
            this.vPCNSConsultaObrasConAutorBindingSource1.DataSource = this.consultaObrasConAutorVisualizar;
            // 
            // consultaObrasConAutorVisualizar
            // 
            this.consultaObrasConAutorVisualizar.DataSetName = "ConsultaObrasConAutorVisualizar";
            this.consultaObrasConAutorVisualizar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vPCNSConsultaObrasConAutorBindingSource
            // 
            this.vPCNSConsultaObrasConAutorBindingSource.DataMember = "VP_CNS_ConsultaObrasConAutor";
            this.vPCNSConsultaObrasConAutorBindingSource.DataSource = this.bibliotecaVirtualEMDataSet1;
            // 
            // bibliotecaVirtualEMDataSet1
            // 
            this.bibliotecaVirtualEMDataSet1.DataSetName = "BibliotecaVirtualEMDataSet1";
            this.bibliotecaVirtualEMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliotecaVirtualEMDataSet
            // 
            this.bibliotecaVirtualEMDataSet.DataSetName = "BibliotecaVirtualEMDataSet";
            this.bibliotecaVirtualEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliotecaVirtualEMDataSetBindingSource
            // 
            this.bibliotecaVirtualEMDataSetBindingSource.DataSource = this.bibliotecaVirtualEMDataSet;
            this.bibliotecaVirtualEMDataSetBindingSource.Position = 0;
            // 
            // tbObrasMusicalesBindingSource
            // 
            this.tbObrasMusicalesBindingSource.DataMember = "tbObrasMusicales";
            this.tbObrasMusicalesBindingSource.DataSource = this.bibliotecaVirtualEMDataSetBindingSource;
            // 
            // tbObrasMusicalesTableAdapter
            // 
            this.tbObrasMusicalesTableAdapter.ClearBeforeFill = true;
            // 
            // vP_CNS_ConsultaObrasConAutorTableAdapter
            // 
            this.vP_CNS_ConsultaObrasConAutorTableAdapter.ClearBeforeFill = true;
            // 
            // checkBoxGenero
            // 
            this.checkBoxGenero.AutoSize = true;
            this.checkBoxGenero.Location = new System.Drawing.Point(94, 113);
            this.checkBoxGenero.Name = "checkBoxGenero";
            this.checkBoxGenero.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGenero.TabIndex = 34;
            this.checkBoxGenero.UseVisualStyleBackColor = true;
            this.checkBoxGenero.CheckedChanged += new System.EventHandler(this.checkBoxGenero_CheckedChanged);
            // 
            // checkBoxAutor
            // 
            this.checkBoxAutor.AutoSize = true;
            this.checkBoxAutor.Location = new System.Drawing.Point(481, 113);
            this.checkBoxAutor.Name = "checkBoxAutor";
            this.checkBoxAutor.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAutor.TabIndex = 35;
            this.checkBoxAutor.UseVisualStyleBackColor = true;
            this.checkBoxAutor.CheckedChanged += new System.EventHandler(this.checkBoxAutor_CheckedChanged);
            // 
            // vP_CNS_ConsultaObrasConAutorTableAdapter1
            // 
            this.vP_CNS_ConsultaObrasConAutorTableAdapter1.ClearBeforeFill = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnVisualizar.Location = new System.Drawing.Point(515, 343);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(79, 32);
            this.btnVisualizar.TabIndex = 39;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalir.Location = new System.Drawing.Point(600, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 32);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FRM_BuscadorObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 380);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.checkBoxAutor);
            this.Controls.Add(this.checkBoxGenero);
            this.Controls.Add(this.gvBuscadorObras);
            this.Controls.Add(this.cboxAutor);
            this.Controls.Add(this.cboxGenero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_BuscadorObras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de obras músicales";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_VisualizarObras_FormClosed);
            this.Load += new System.EventHandler(this.FRM_VisualizarObras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBuscadorObras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPCNSConsultaObrasConAutorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaObrasConAutorVisualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPCNSConsultaObrasConAutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaVirtualEMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaVirtualEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaVirtualEMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbObrasMusicalesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboxGenero;
        private System.Windows.Forms.ComboBox cboxAutor;
        private System.Windows.Forms.DataGridView gvBuscadorObras;
        private System.Windows.Forms.BindingSource bibliotecaVirtualEMDataSetBindingSource;
        private BibliotecaVirtualEMDataSet bibliotecaVirtualEMDataSet;
        private System.Windows.Forms.BindingSource tbObrasMusicalesBindingSource;
        private BibliotecaVirtualEMDataSetTableAdapters.tbObrasMusicalesTableAdapter tbObrasMusicalesTableAdapter;
        private BibliotecaVirtualEMDataSet1 bibliotecaVirtualEMDataSet1;
        private System.Windows.Forms.BindingSource vPCNSConsultaObrasConAutorBindingSource;
        private BibliotecaVirtualEMDataSet1TableAdapters.VP_CNS_ConsultaObrasConAutorTableAdapter vP_CNS_ConsultaObrasConAutorTableAdapter;
        private System.Windows.Forms.CheckBox checkBoxGenero;
        private System.Windows.Forms.CheckBox checkBoxAutor;
        private ConsultaObrasConAutorVisualizar consultaObrasConAutorVisualizar;
        private System.Windows.Forms.BindingSource vPCNSConsultaObrasConAutorBindingSource1;
        private ConsultaObrasConAutorVisualizarTableAdapters.VP_CNS_ConsultaObrasConAutorTableAdapter vP_CNS_ConsultaObrasConAutorTableAdapter1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.Button btnSalir;
    }
}