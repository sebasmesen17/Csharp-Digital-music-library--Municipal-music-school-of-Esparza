namespace DataPresentation
{
    partial class FRM_InicioSesionEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_InicioSesionEliminar));
            this.label6 = new System.Windows.Forms.Label();
            this.btniniciarSesion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 23);
            this.label6.TabIndex = 26;
            // 
            // btniniciarSesion
            // 
            this.btniniciarSesion.BackColor = System.Drawing.Color.BurlyWood;
            this.btniniciarSesion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.btniniciarSesion.Location = new System.Drawing.Point(237, 181);
            this.btniniciarSesion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btniniciarSesion.Name = "btniniciarSesion";
            this.btniniciarSesion.Size = new System.Drawing.Size(205, 32);
            this.btniniciarSesion.TabIndex = 25;
            this.btniniciarSesion.Text = "Iniciar sesión";
            this.btniniciarSesion.UseVisualStyleBackColor = false;
            this.btniniciarSesion.Click += new System.EventHandler(this.btniniciarSesion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(233, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Inicio de sesión";
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(289, 131);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.PasswordChar = '*';
            this.tbContrasenia.Size = new System.Drawing.Size(178, 22);
            this.tbContrasenia.TabIndex = 23;
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(289, 81);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(178, 22);
            this.tbCedula.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(122, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(166, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cédula:";
            // 
            // FRM_InicioSesionEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 225);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btniniciarSesion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_InicioSesionEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión de administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_InicioSesionEliminar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btniniciarSesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}