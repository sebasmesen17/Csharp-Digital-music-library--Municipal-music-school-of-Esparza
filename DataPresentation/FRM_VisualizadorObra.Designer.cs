namespace DataPresentation
{
    partial class FRM_VisualizadorObra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_VisualizadorObra));
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.PBvisualizadorImagenes = new System.Windows.Forms.PictureBox();
            this.printDocObras = new System.Drawing.Printing.PrintDocument();
            this.printDialObras = new System.Windows.Forms.PrintDialog();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBvisualizadorImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_imprimir.Location = new System.Drawing.Point(214, 3);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(100, 28);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // PBvisualizadorImagenes
            // 
            this.PBvisualizadorImagenes.Location = new System.Drawing.Point(13, 48);
            this.PBvisualizadorImagenes.Margin = new System.Windows.Forms.Padding(4);
            this.PBvisualizadorImagenes.Name = "PBvisualizadorImagenes";
            this.PBvisualizadorImagenes.Size = new System.Drawing.Size(588, 689);
            this.PBvisualizadorImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBvisualizadorImagenes.TabIndex = 0;
            this.PBvisualizadorImagenes.TabStop = false;
            // 
            // printDocObras
            // 
            this.printDocObras.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printObras_PrintPage);
            // 
            // printDialObras
            // 
            this.printDialObras.UseEXDialog = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalir.Location = new System.Drawing.Point(322, 3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FRM_VisualizadorObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 750);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.PBvisualizadorImagenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_VisualizadorObra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de obras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Visualizador_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PBvisualizadorImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBvisualizadorImagenes;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Drawing.Printing.PrintDocument printDocObras;
        private System.Windows.Forms.PrintDialog printDialObras;
        private System.Windows.Forms.Button btnSalir;
    }
}