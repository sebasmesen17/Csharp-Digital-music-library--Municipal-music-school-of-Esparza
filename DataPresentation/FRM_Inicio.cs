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
    public partial class FRM_Inicio : Form
    {
        String nombreFrame = "";
        public FRM_Inicio()
        {
            InitializeComponent();
            this.MaximizeBox = false;
           
        }

        private void obrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean popup = false;
            Frm_RegistroAutores frm = new Frm_RegistroAutores(popup);
            this.Hide();
            frm.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistroAdministradores frm = new Frm_RegistroAdministradores();
            this.Hide();
            frm.ShowDialog();
        }

        private void agregarObrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   FRM_AgregarObras frm = new FRM_AgregarObras();
            FRM_InicioSesionRegistro frm = new FRM_InicioSesionRegistro();
            this.Hide();
            frm.ShowDialog();
        }

        private void eliminarObrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FRM_InicioSesionEliminar frm = new FRM_InicioSesionEliminar();
            //this.Hide();
            //frm.ShowDialog();
        }

        private void buscarObrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BuscadorObras frm = new FRM_BuscadorObras();
            this.Hide();
            frm.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_AcercaDe frm = new FRM_AcercaDe();
            this.Hide();
            frm.ShowDialog();
        }

        private void FRM_Inicio_Load(object sender, EventArgs e)
        {

        }

        private void obrasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            nombreFrame = "Obras";
            FRM_InicioSesionEliminar frm = new FRM_InicioSesionEliminar(nombreFrame);
            this.Hide();
            frm.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nombreFrame = "Autores";
            FRM_InicioSesionEliminar frm = new FRM_InicioSesionEliminar(nombreFrame);
            this.Hide();
            frm.ShowDialog();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nombreFrame = "Admin";
            FRM_InicioSesionEliminar frm = new FRM_InicioSesionEliminar(nombreFrame);
            this.Hide();
            frm.ShowDialog();
        }

        private void FRM_Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
