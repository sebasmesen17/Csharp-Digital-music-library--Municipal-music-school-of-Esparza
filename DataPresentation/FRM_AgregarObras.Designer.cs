namespace DataPresentation
{
    partial class FRM_AgregarObras
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AgregarObras));
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ofdSelecionarImagen = new System.Windows.Forms.OpenFileDialog();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTituloObra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxIntrumento = new System.Windows.Forms.ComboBox();
            this.cboxGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.visualizadorImagenes = new System.Windows.Forms.PictureBox();
            this.cboxAutor = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visualizadorImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSelecionar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.ForeColor = System.Drawing.Color.Black;
            this.btnSelecionar.Location = new System.Drawing.Point(80, 234);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(166, 29);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "Seleccionar Imagen";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnGuardar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(62, 445);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 47);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Obra";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Enabled = false;
            this.txtRuta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(21, 202);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(314, 26);
            this.txtRuta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(134, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ruta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(107, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Identificador";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificador.Location = new System.Drawing.Point(21, 28);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(314, 26);
            this.txtIdentificador.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(107, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre Autor";
            // 
            // txtTituloObra
            // 
            this.txtTituloObra.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloObra.Location = new System.Drawing.Point(21, 140);
            this.txtTituloObra.Name = "txtTituloObra";
            this.txtTituloObra.Size = new System.Drawing.Size(314, 26);
            this.txtTituloObra.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(107, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Titulo Obra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(107, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Instrumento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BurlyWood;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(134, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Genero";
            // 
            // cboxIntrumento
            // 
            this.cboxIntrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxIntrumento.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxIntrumento.FormattingEnabled = true;
            this.cboxIntrumento.Location = new System.Drawing.Point(38, 323);
            this.cboxIntrumento.Name = "cboxIntrumento";
            this.cboxIntrumento.Size = new System.Drawing.Size(239, 27);
            this.cboxIntrumento.TabIndex = 16;
            // 
            // cboxGenero
            // 
            this.cboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGenero.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxGenero.FormattingEnabled = true;
            this.cboxGenero.Location = new System.Drawing.Point(38, 378);
            this.cboxGenero.Name = "cboxGenero";
            this.cboxGenero.Size = new System.Drawing.Size(239, 27);
            this.cboxGenero.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(482, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Previsualización de la obra";
            // 
            // visualizadorImagenes
            // 
            this.visualizadorImagenes.BackColor = System.Drawing.Color.Transparent;
            this.visualizadorImagenes.Location = new System.Drawing.Point(404, 37);
            this.visualizadorImagenes.Name = "visualizadorImagenes";
            this.visualizadorImagenes.Size = new System.Drawing.Size(392, 476);
            this.visualizadorImagenes.TabIndex = 0;
            this.visualizadorImagenes.TabStop = false;
            // 
            // cboxAutor
            // 
            this.cboxAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAutor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxAutor.FormattingEnabled = true;
            this.cboxAutor.Location = new System.Drawing.Point(21, 85);
            this.cboxAutor.Name = "cboxAutor";
            this.cboxAutor.Size = new System.Drawing.Size(314, 27);
            this.cboxAutor.TabIndex = 19;
            this.cboxAutor.SelectedIndexChanged += new System.EventHandler(this.cboxAutor_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(194, 461);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 31);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FRM_AgregarObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 524);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cboxAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxGenero);
            this.Controls.Add(this.cboxIntrumento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTituloObra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.visualizadorImagenes);
            this.ForeColor = System.Drawing.Color.Peru;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_AgregarObras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de obras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_AgregarObras_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.visualizadorImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox visualizadorImagenes;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.OpenFileDialog ofdSelecionarImagen;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTituloObra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxIntrumento;
        private System.Windows.Forms.ComboBox cboxGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxAutor;
        private System.Windows.Forms.Button btnSalir;
    }
}

