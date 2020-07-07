using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataLogic;

namespace DataPresentation
{
    public partial class FRM_InicioSesionRegistro : Form
    {
        public FRM_InicioSesionRegistro()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public void Frames()
        {
            this.Dispose();
            FRM_AgregarObras frm = new FRM_AgregarObras();
            frm.ShowDialog();
            
        }

        private void FRM_InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Frm_RegistroAdministradores frm = new Frm_RegistroAdministradores();
            this.Hide();
            frm.ShowDialog();
        }

        private void btniniciarSesion_Click(object sender, EventArgs e)
        {
            DataEntity.tbAdministrador buscarAutor = new DataEntity.tbAdministrador()
            {
                cedula = tbCedula.Text,
                contrasenia = tbContrasenia.Text,
            };
            if(DLRegistroAdmin.Login(buscarAutor) == true)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Listo");
                Frames();
            }
            else
            {
                string msj = "Datos incorrectos, verifique de nuevo.";
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
