using DataEntity;
using DataLogic;
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
    public partial class FRM_EliminarActualizarAutores : Form
    {
        public FRM_EliminarActualizarAutores()
        {
            InitializeComponent();
            deshabilitarEditar();
            this.MaximizeBox = false;
        }

        private void FRM_EliminarActualizarAutores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'consultaAutor.tbAutor' Puede moverla o quitarla según sea necesario.
            this.tbAutorTableAdapter.Fill(this.consultaAutor.tbAutor);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }

        private void FRM_EliminarActualizarAutores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }
        private void deshabilitarEditar()
        {
            txtINombre.Enabled = false;
            rtbInfo.Enabled = false;
            dtFechaNac.Enabled = false;
            btnActualizar.Enabled = false;
            
        }
        private void habilitarEditar()
        {
            txtINombre.Enabled = true;
            rtbInfo.Enabled = true;
            dtFechaNac.Enabled = true;
            btnActualizar.Enabled = true;

        }

        private void clean()
        {
            txtINombre.Text = "";
            rtbInfo.Text = "";
            dtFechaNac.Value = DateTime.Now;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tbAutor autor = new tbAutor();
            if (gvListaAutores.CurrentRow != null)
            {
                DataEntity.tbAutor editar = new DataEntity.tbAutor
                {
                    idAutor = Int32.Parse(gvListaAutores.CurrentRow.Cells[0].Value.ToString())
                };
                autor = DLRegistroAutor.GetByID(editar);

                txtINombre.Text = autor.nombreCompleto;
                rtbInfo.Text = autor.informacion;
                dtFechaNac.Value = autor.fechaNacimiento;
                habilitarEditar();
              }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (gvListaAutores.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Si borra este autor, se eliminaran las obras relacionadas a esta autor \nSeguro que desea borrar este autor ? ", "Borrar Obra", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataEntity.tbAutor eliminar = new DataEntity.tbAutor
                    {
                        idAutor = Int32.Parse(gvListaAutores.CurrentRow.Cells[0].Value.ToString())
                    };
                    DLRegistroAutor.Eliminar(eliminar);
                    MessageBox.Show("Se elimino el autor selecionado", "Listo");
                }
            }
            gvListaAutores.DataSource = DLRegistroAutor.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtINombre.Text) && !String.IsNullOrEmpty(rtbInfo.Text))
            {
                DataEntity.tbAutor autor = new DataEntity.tbAutor()
                {
                    idAutor = Int32.Parse(gvListaAutores.CurrentRow.Cells[0].Value.ToString()),
                    nombreCompleto = txtINombre.Text,
                    informacion = rtbInfo.Text,
                    fechaNacimiento = dtFechaNac.Value.Date,
                };
                DLRegistroAutor.Actualizar(autor);
                MessageBox.Show("Se actualizo la obra sastifactoriamente");
                gvListaAutores.DataSource = DLRegistroAutor.GetAll();
                deshabilitarEditar();
                clean();
            }
            else 
            {
                String msj = "Se encuentran campos vacios";
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
