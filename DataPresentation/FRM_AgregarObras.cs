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
    public partial class FRM_AgregarObras : Form
    {
        public FRM_AgregarObras()
        {
            InitializeComponent();
            Cargarcbox();
            fillCboxAutor();
            this.MaximizeBox = false;
        }

        public void Cargarcbox()
        {

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
            listaGeneros.Insert(13, "Música de Cámara");
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

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ofdSelecionarImagen.ShowDialog();
                if (this.ofdSelecionarImagen.FileName.Equals("") == false)
                {
                    visualizadorImagenes.Load(this.ofdSelecionarImagen.FileName);
                    visualizadorImagenes.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtRuta.Text = this.ofdSelecionarImagen.FileName.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void fillCboxAutor()
        {
            List<tbAutor> autores = DLRegistroAutor.GetAll();
            autores.Insert(0, new tbAutor { idAutor = 0, nombreCompleto = "Seleccione un autor." });
            autores.Insert(1, new tbAutor { idAutor = 0, nombreCompleto = "Agregar un nuevo autor." });
            cboxAutor.DataSource = autores;
            cboxAutor.DisplayMember = "nombreCompleto";
            cboxAutor.ValueMember = "idAutor";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idAutor = Int32.Parse(cboxAutor.SelectedValue.ToString());
            if (!String.IsNullOrEmpty(txtIdentificador.Text) && !String.IsNullOrEmpty(txtTituloObra.Text) 
                && !String.IsNullOrEmpty(txtRuta.Text) && cboxAutor.SelectedIndex !=0 && cboxAutor.SelectedIndex != 1)
            {
                DataEntity.tbObrasMusicales obra = new DataEntity.tbObrasMusicales()
                {

                    codigoObra = txtIdentificador.Text,
                    nombre = txtTituloObra.Text,
                    idAutor = idAutor,
                    genero = cboxGenero.SelectedItem.ToString(),
                    instrumento = cboxIntrumento.SelectedItem.ToString(),
                    ruta = txtRuta.Text
                };
                DataLogic.DLObra.Agregar(obra);
                string msj = "La obra se ha guardado correctamente";
                MessageBox.Show(msj, "Listo");
                clean();
            }
            else
            {

                string msj = "Hay campos en blanco que deben estar llenos o no seleccionó la ruta de la imagen a guardar";
                MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clean()
        {
            txtIdentificador.Text = "";
            txtRuta.Text = "";
            txtTituloObra.Text = "";
            cboxAutor.SelectedIndex = 0;
            cboxGenero.SelectedIndex = 0;
            cboxIntrumento.SelectedIndex = 0;
            visualizadorImagenes.Image = null;
        }
    

        private void FRM_AgregarObras_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }

        private void cboxAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboxAutor.SelectedIndex==1)
            {
                Boolean popup = true;
                Hide();
                Frm_RegistroAutores registroAutor = new Frm_RegistroAutores(popup);
                registroAutor.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }
    }
}
