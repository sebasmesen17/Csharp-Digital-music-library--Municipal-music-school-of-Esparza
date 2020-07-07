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
    public partial class FRM_EliminarActualizarObras : Form
    {
        public FRM_EliminarActualizarObras()
        {
            InitializeComponent();
            Cargarcbox();
            deshabilitarEditar();
            this.MaximizeBox = false;
        }

        public void Cargarcbox()
        {
            List<tbAutor> autores = DLRegistroAutor.GetAll();
            cboxAutor.DataSource = autores;
            cboxAutor.DisplayMember = "nombreCompleto";
            cboxAutor.ValueMember = "idAutor";

            List<string> listaGeneros = new List<string>();
            // listaGeneros.Insert(78, "Seleccione un género");
            listaGeneros.Insert(0, "Obertura");
            listaGeneros.Insert(1, "Marha militar");
            listaGeneros.Insert(2, "Marcha fúnebre");
            listaGeneros.Insert(3, "Paso doble");
            listaGeneros.Insert(4, "Pasillo");
            listaGeneros.Insert(5, "Himnos");
            listaGeneros.Insert(6, "Bolero");
            listaGeneros.Insert(7, "Cumbia");
            listaGeneros.Insert(8, "Chachachá");
            listaGeneros.Insert(9, "Salsa");
            listaGeneros.Insert(10, "Merengue");
            listaGeneros.Insert(11, "Balada");
            listaGeneros.Insert(12, "Obra sinfónica");
            listaGeneros.Insert(13, "Música de cámara");
            listaGeneros.Insert(14, "Instrumento solo");
            listaGeneros.Insert(15, "Banda de concierto");
            cboxGenero.DataSource = listaGeneros;

            List<string> listaInstrumentos = new List<string>();
            //listaInstrumentos.Insert(-1, "Seleccione un instrumento");
            listaInstrumentos.Insert(0, "Guitarra");
            listaInstrumentos.Insert(1, "Saxofón");
            listaInstrumentos.Insert(2, "Saxofón Soprano");
            listaInstrumentos.Insert(3, "Saxofón alto");
            listaInstrumentos.Insert(4, "Saxofón menor");
            listaInstrumentos.Insert(5, "Clarinete simebol");
            listaInstrumentos.Insert(6, "Clarinete bajo");
            listaInstrumentos.Insert(7, "Flauta traversa");
            listaInstrumentos.Insert(8, "Tuba");
            listaInstrumentos.Insert(9, "Trombón");
            listaInstrumentos.Insert(10, "Trombón barítono");
            listaInstrumentos.Insert(11, "Marimba");
            listaInstrumentos.Insert(12, "Corno en Fa");
            listaInstrumentos.Insert(13, "Trompeta");
            listaInstrumentos.Insert(14, "Requinta");
            listaInstrumentos.Insert(15, "Piano");
            listaInstrumentos.Insert(16, "Violín");
            listaInstrumentos.Insert(17, "Percusión");
            cboxIntrumento.DataSource = listaInstrumentos;
        }

        private void FRM_Eliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }

        private void FRM_Eliminar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaVirtualEMDataSet21.VP_CNS_ConsultaObrasConAutor' Puede moverla o quitarla según sea necesario.
            this.vP_CNS_ConsultaObrasConAutorTableAdapter.Fill(this.bibliotecaVirtualEMDataSet21.VP_CNS_ConsultaObrasConAutor);
            // TODO: esta línea de código carga datos en la tabla 'consultaObrasConAutor.VP_CNS_ConsultaObrasConAutor' Puede moverla o quitarla según sea necesario.
            //this.vP_CNS_ConsultaObrasConAutorTableAdapter1.Fill(this.consultaObrasConAutor.VP_CNS_ConsultaObrasConAutor);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaVirtualEMDataSet2.VP_CNS_ConsultaObrasConAutor' Puede moverla o quitarla según sea necesario.
            //this.vP_CNS_ConsultaObrasConAutorTableAdapter.Fill(this.bibliotecaVirtualEMDataSet2.VP_CNS_ConsultaObrasConAutor);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaVirtualEMDataSet.tbObrasMusicales' Puede moverla o quitarla según sea necesario.
            //this.tbObrasMusicalesTableAdapter.Fill(this.bibliotecaVirtualEMDataSet.tbObrasMusicales);

        }

        private void nombreAutorToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbObrasMusicalesTableAdapter.NombreAutor(this.bibliotecaVirtualEMDataSet.tbObrasMusicales);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gvListaObras.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Seguro que desea borrar esta obra?", "Borrar Obra", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataEntity.tbObrasMusicales eliminar = new DataEntity.tbObrasMusicales
                    {
                        idObra = Int32.Parse(gvListaObras.CurrentRow.Cells[0].Value.ToString())
                    };
                    DLObra.Eliminar(eliminar);
                    MessageBox.Show("Se elimino la obra sastifactoriamente", "Listo");
                }
            }

            gvListaObras.DataSource = DLObra.GetVistaConsultaObrasConAutor();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tbObrasMusicales obra = new tbObrasMusicales();
            if (gvListaObras.CurrentRow != null)
            {
                DataEntity.tbObrasMusicales editar = new DataEntity.tbObrasMusicales
                {
                    idObra = Int32.Parse(gvListaObras.CurrentRow.Cells[0].Value.ToString())
                };
                obra=DLObra.GetByID(editar);

                txtIdentificador.Text = obra.codigoObra;
                txtTituloObra.Text = obra.nombre;
                cboxAutor.SelectedValue = obra.idAutor;
                cboxGenero.SelectedIndex = cboxGenero.FindStringExact(obra.genero);
                cboxIntrumento.SelectedIndex = cboxIntrumento.FindStringExact(obra.instrumento);

                //cboxIntrumento.SelectedValue = obra.instrumento;
                habilitarEditar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            int idAutor = Int32.Parse(cboxAutor.SelectedValue.ToString());
            if (!String.IsNullOrEmpty(txtIdentificador.Text) && !String.IsNullOrEmpty(txtTituloObra.Text))
            {
                DataEntity.tbObrasMusicales obra = new DataEntity.tbObrasMusicales()
                {
                    idObra = Int32.Parse(gvListaObras.CurrentRow.Cells[0].Value.ToString()),
                    codigoObra = txtIdentificador.Text,
                    nombre = txtTituloObra.Text,
                    idAutor = idAutor,
                    genero = cboxGenero.SelectedItem.ToString(),
                    instrumento = cboxIntrumento.SelectedItem.ToString(),
                };
                //DLObra.Agregar(obra);
                DLObra.Actualizar(obra);
                MessageBox.Show("Se actualizo la obra sastifactoriamente");
                gvListaObras.DataSource = DLObra.GetVistaConsultaObrasConAutor();
                deshabilitarEditar();
                clean();
            }
            else 
            {
                String msj = "Se encuentran campos vacios";
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void habilitarEditar()
        {
            txtIdentificador.Enabled = true;
            txtTituloObra.Enabled = true;
            cboxAutor.Enabled = true;
            cboxGenero.Enabled = true;
            cboxIntrumento.Enabled = true;
            btnActualizar.Enabled = true;
        }

        private void deshabilitarEditar()
        {
            txtIdentificador.Enabled = false;
            txtTituloObra.Enabled = false;
            cboxAutor.Enabled = false;
            cboxGenero.Enabled = false;
            cboxIntrumento.Enabled = false;
            btnActualizar.Enabled = false;
        }

        private void clean()
        {
            txtIdentificador.Text = "";
            txtTituloObra.Text = "";
            cboxAutor.SelectedIndex = 0;
            cboxGenero.SelectedIndex = 0;
            cboxIntrumento.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }
    }
}
