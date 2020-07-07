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
    public partial class Frm_RegistroAutores : Form
    {
        Boolean popup = false;
        public Frm_RegistroAutores(Boolean popup)
        {
            this.popup = popup;
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Frm_RegistroAutores_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(popup==false)
            {
                Hide();
                FRM_Inicio inicio = new FRM_Inicio();
                inicio.ShowDialog();
            }
            else 
            {
                Hide();
                FRM_AgregarObras agregarObras = new FRM_AgregarObras();
                agregarObras.ShowDialog();
            }
            
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNombre.Text)
               && !String.IsNullOrEmpty(rtbInfo.Text))
            {
                DataEntity.tbAutor autor = new DataEntity.tbAutor()
                {
                
                    nombreCompleto = tbNombre.Text,
                    fechaNacimiento = dtFechaNac.Value.Date,
                    informacion = rtbInfo.Text,
                };
                DataLogic.DLRegistroAutor.Agregar(autor);
                string msj = "Autor registrado de forma correcta";
                MessageBox.Show(msj, "Listo");
                clean();
            }
            else
            {

                string msj = "Hay campos en blanco que deben estar llenos";
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if(popup)
            {
                Hide();
                FRM_AgregarObras agregarObras = new FRM_AgregarObras();
                agregarObras.ShowDialog();
            }
        }

        private void clean()
        {
            tbNombre.Text = "";
            rtbInfo.Text = "";
        }
    }
}
