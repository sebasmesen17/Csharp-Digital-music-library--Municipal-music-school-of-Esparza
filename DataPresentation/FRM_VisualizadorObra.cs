using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataEntity;
using DataLogic;

namespace DataPresentation
{
    public partial class FRM_VisualizadorObra : Form
    {
        public FRM_VisualizadorObra()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public FRM_VisualizadorObra(tbObrasMusicales obra)
        {
            InitializeComponent();
            cargarPicture(obra);
        }
        public void cargarPicture(tbObrasMusicales obra)
        {
            int ancho, alto;
            tbObrasMusicales obraN = new tbObrasMusicales();
            obraN = DLObra.GetByID(obra);
          //  MessageBox.Show(obraN.ruta);
            PBvisualizadorImagenes.Load(obraN.ruta);
            alto = Int32.Parse(PBvisualizadorImagenes.Image.Height.ToString());
            ancho = Int32.Parse(PBvisualizadorImagenes.Image.Width.ToString());
            if (alto > ancho)
            {
                PBvisualizadorImagenes.Width = 450;
                PBvisualizadorImagenes.Height = 650;
                this.Width = 450 + 41;
                this.Height = 650 + 84;
                PBvisualizadorImagenes.SizeMode = PictureBoxSizeMode.StretchImage;
               
            }
            else
            if (alto < ancho)
            {
                PBvisualizadorImagenes.Width = 750;
                PBvisualizadorImagenes.Height = 550;
                this.Width = 750 + 41;
                this.Height = 550 + 84;
                PBvisualizadorImagenes.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void FRM_Visualizador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            FRM_BuscadorObras buscador = new FRM_BuscadorObras();
            buscador.ShowDialog();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
           
                printDocObras.PrinterSettings = printDialObras.PrinterSettings;
                printDocObras.Print();
            

        }

        private void printObras_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(PBvisualizadorImagenes.Image, 10, 20, 900, 920);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_BuscadorObras buscador = new FRM_BuscadorObras();
            buscador.ShowDialog();
        }

    }
}
