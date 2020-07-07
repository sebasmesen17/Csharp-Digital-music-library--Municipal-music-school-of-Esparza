using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLogic;

namespace DataPresentation
{
    public partial class FRM_InicioSesionEliminar : Form
    {
        String frame="";
        public FRM_InicioSesionEliminar(String nombreFrame)
        {
            frame = nombreFrame;
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public void FrameObras()
        {
            this.Dispose();
            FRM_EliminarActualizarObras frm = new FRM_EliminarActualizarObras();
            frm.ShowDialog();
        }
        public void FrameAutores()
        {
            this.Dispose();
            FRM_EliminarActualizarAutores frm = new FRM_EliminarActualizarAutores();
            frm.ShowDialog();
        }
        public void FrameAdmin()
        {
            this.Dispose();
            FRM_EliminarAdministrativos frm = new FRM_EliminarAdministrativos();
            frm.ShowDialog();
        }

        private void btniniciarSesion_Click(object sender, EventArgs e)
        {
            DataEntity.tbAdministrador buscarAutor = new DataEntity.tbAdministrador()
            {
                cedula = tbCedula.Text,
                contrasenia = tbContrasenia.Text,
            };
            if (DLRegistroAdmin.Login(buscarAutor) == true)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Listo");
                if(frame== "Obras")
                {
                    FrameObras();
                }
                else
                if(frame == "Autores")
                {
                    FrameAutores();
                }
                else
                if(frame == "Admin")
                {
                    FrameAdmin();
                }
            }
            else
            {
                string msj = "Datos incorrectos, verifique de nuevo.";
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Frm_RegistroAdministradores frm = new Frm_RegistroAdministradores();
            this.Hide();
            frm.ShowDialog();
        }

        private void FRM_InicioSesionEliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }
    }

   
}
