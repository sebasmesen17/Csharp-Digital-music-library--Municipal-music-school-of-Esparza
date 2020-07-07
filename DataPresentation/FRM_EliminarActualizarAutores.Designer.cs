namespace DataPresentation
{
    partial class FRM_EliminarActualizarAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EliminarActualizarAutores));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gvListaAutores = new System.Windows.Forms.DataGridView();
            this.idAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaAutor = new DataPresentation.ConsultaAutor();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtINombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbAutorTableAdapter = new DataPresentation.ConsultaAutorTableAdapters.tbAutorTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEliminar.Location = new System.Drawing.Point(124, 364);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 39);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEditar.Location = new System.Drawing.Point(16, 364);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 39);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.BurlyWood;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "Lista de Autores";
            // 
            // gvListaAutores
            // 
            this.gvListaAutores.AllowUserToAddRows = false;
            this.gvListaAutores.AutoGenerateColumns = false;
            this.gvListaAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAutorDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.informacionDataGridViewTextBoxColumn});
            this.gvListaAutores.DataSource = this.tbAutorBindingSource;
            this.gvListaAutores.Location = new System.Drawing.Point(16, 34);
            this.gvListaAutores.Margin = new System.Windows.Forms.Padding(4);
            this.gvListaAutores.Name = "gvListaAutores";
            this.gvListaAutores.ReadOnly = true;
            this.gvListaAutores.RowHeadersWidth = 51;
            this.gvListaAutores.Size = new System.Drawing.Size(472, 321);
            this.gvListaAutores.TabIndex = 26;
            // 
            // idAutorDataGridViewTextBoxColumn
            // 
            this.idAutorDataGridViewTextBoxColumn.DataPropertyName = "idAutor";
            this.idAutorDataGridViewTextBoxColumn.HeaderText = "idAutor";
            this.idAutorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAutorDataGridViewTextBoxColumn.Name = "idAutorDataGridViewTextBoxColumn";
            this.idAutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAutorDataGridViewTextBoxColumn.Visible = false;
            this.idAutorDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "nombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.nombreCompletoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCompletoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nombreCompletoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaNacimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // informacionDataGridViewTextBoxColumn
            // 
            this.informacionDataGridViewTextBoxColumn.DataPropertyName = "informacion";
            this.informacionDataGridViewTextBoxColumn.HeaderText = "Información";
            this.informacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.informacionDataGridViewTextBoxColumn.Name = "informacionDataGridViewTextBoxColumn";
            this.informacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.informacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbAutorBindingSource
            // 
            this.tbAutorBindingSource.DataMember = "tbAutor";
            this.tbAutorBindingSource.DataSource = this.consultaAutor;
            // 
            // consultaAutor
            // 
            this.consultaAutor.DataSetName = "ConsultaAutor";
            this.consultaAutor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnActualizar.Location = new System.Drawing.Point(908, 363);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 39);
            this.btnActualizar.TabIndex = 51;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(547, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(547, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // txtINombre
            // 
            this.txtINombre.Location = new System.Drawing.Point(585, 71);
            this.txtINombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtINombre.Name = "txtINombre";
            this.txtINombre.Size = new System.Drawing.Size(299, 22);
            this.txtINombre.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(545, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre Completo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(545, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mantenimiento Autor";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(513, -23);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(20, 444);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // tbAutorTableAdapter
            // 
            this.tbAutorTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalir.Location = new System.Drawing.Point(383, 363);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 39);
            this.btnSalir.TabIndex = 55;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaNac.Location = new System.Drawing.Point(585, 138);
            this.dtFechaNac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(115, 22);
            this.dtFechaNac.TabIndex = 57;
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(585, 206);
            this.rtbInfo.Margin = new System.Windows.Forms.Padding(4);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(391, 132);
            this.rtbInfo.TabIndex = 56;
            this.rtbInfo.Text = "";
            // 
            // FRM_EliminarActualizarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 409);
            this.Controls.Add(this.dtFechaNac);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtINombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gvListaAutores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_EliminarActualizarAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar y actualizar autores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_EliminarActualizarAutores_FormClosed);
            this.Load += new System.EventHandler(this.FRM_EliminarActualizarAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListaAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gvListaAutores;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtINombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ConsultaAutor consultaAutor;
        private System.Windows.Forms.BindingSource tbAutorBindingSource;
        private ConsultaAutorTableAdapters.tbAutorTableAdapter tbAutorTableAdapter;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.RichTextBox rtbInfo;
    }
}