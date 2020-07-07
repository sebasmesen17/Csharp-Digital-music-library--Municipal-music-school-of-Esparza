using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace DataPresentation
{
    public partial class Frm_RegistroAdministradores : Form
    {
        public Frm_RegistroAdministradores()
        {
            InitializeComponent();
            Fillcbox();
            this.MaximizeBox = false;
            string msj = "Permitido el registro solo para trabajadores de la Escuela de música";
            MessageBox.Show(msj, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

       

        public void Fillcbox()
        {
            List<string> lista = new List<string>();
            lista.Insert(0,"Director");
            lista.Insert(1, "Coordinador");
            lista.Insert(2, "Profesor");
            cboxCargo.DataSource = lista;
        }



        private void Frm_Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }

    

        private void btnregistrar_Click_1(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbCedula.Text)&& !String.IsNullOrEmpty(tbContrasenia.Text)
               && !String.IsNullOrEmpty(tbNombre.Text))
           {
           DataEntity.tbAdministrador administrador = new DataEntity.tbAdministrador()
            {
               
                nombreCompleto = tbNombre.Text,
                cedula = tbCedula.Text,
                cargo = cboxCargo.SelectedItem.ToString(),
                contrasenia = tbContrasenia.Text

            };
            DataLogic.DLRegistroAdmin.Agregar(administrador);
                clean();
            }
            else {

                string msj = "Hay campos en blanco que deben estar llenos";
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clean()
        {
            tbCedula.Text = "";
            tbContrasenia.Text = "";
            tbNombre.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msj = "Permitido el registro solo para trabajadores de la Escuela de música";
            MessageBox.Show(msj, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }
    }
}
