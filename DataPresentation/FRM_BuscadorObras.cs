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
    public partial class FRM_BuscadorObras : Form
    {
        public FRM_BuscadorObras()
        {
            InitializeComponent();
            Cargarcbox();
            Bloquearcbox();
            this.MaximizeBox = false;
        }

        private void FRM_VisualizarObras_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }
        public void Bloquearcbox()
        {
            cboxAutor.Enabled = false;
            cboxGenero.Enabled = false;
        }
        public void Cargarcbox()
        {
            List<tbAutor> autores = DLRegistroAutor.GetAll();
            autores.Insert(0, new tbAutor { idAutor = 0, nombreCompleto = "Seleccione un autor..." });
            cboxAutor.DataSource = autores;
            cboxAutor.DisplayMember = "nombreCompleto";
            cboxAutor.ValueMember = "idAutor";

            List<string> listaGeneros = new List<string>();
            listaGeneros.Insert(0, "Seleccione un género...");
            listaGeneros.Insert(1, "Obertura");
            listaGeneros.Insert(2, "Marha militar");
            listaGeneros.Insert(3, "Marcha fúnebre");
            listaGeneros.Insert(4, "Paso doble");
            listaGeneros.Insert(5, "Pasillo");
            listaGeneros.Insert(6, "Himnos");
            listaGeneros.Insert(7, "Bolero");
            listaGeneros.Insert(8, "Cumbia");
            listaGeneros.Insert(9, "Chachachá");
            listaGeneros.Insert(10, "Salsa");
            listaGeneros.Insert(11, "Merengue");
            listaGeneros.Insert(12, "Balada");
            listaGeneros.Insert(13, "Obra sinfónica");
            listaGeneros.Insert(14, "Música de Cámara");
            listaGeneros.Insert(15, "Instrumento solo");
            listaGeneros.Insert(16, "Banda de concierto");
            cboxGenero.DataSource = listaGeneros;
        }

        private void FRM_VisualizarObras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'consultaObrasConAutorVisualizar.VP_CNS_ConsultaObrasConAutor' Puede moverla o quitarla según sea necesario.
            this.vP_CNS_ConsultaObrasConAutorTableAdapter1.Fill(this.consultaObrasConAutorVisualizar.VP_CNS_ConsultaObrasConAutor);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaVirtualEMDataSet1.VP_CNS_ConsultaObrasConAutor' Puede moverla o quitarla según sea necesario.
            this.vP_CNS_ConsultaObrasConAutorTableAdapter.Fill(this.bibliotecaVirtualEMDataSet1.VP_CNS_ConsultaObrasConAutor);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaVirtualEMDataSet.tbObrasMusicales' Puede moverla o quitarla según sea necesario.
            this.tbObrasMusicalesTableAdapter.Fill(this.bibliotecaVirtualEMDataSet.tbObrasMusicales);

        }

        private void checkBoxGenero_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxGenero.Checked == true)
            {
                cboxGenero.Enabled = true;
            }
            else
            if (checkBoxGenero.Checked == false)
            {
                cboxGenero.SelectedIndex = 0;
                cboxGenero.Enabled = false;
            }

            if ((checkBoxGenero.Checked == false) && (checkBoxAutor.Checked == false))
            {
                gvBuscadorObras.DataSource = DLObra.GetVistaConsultaObrasConAutor();
            }
        }

        private void checkBoxAutor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutor.Checked == true)
            {
                cboxAutor.Enabled = true;
            }
            else
            if (checkBoxAutor.Checked == false)
            {
                cboxAutor.SelectedIndex = 0;
                cboxAutor.Enabled = false;
            }

            if ((checkBoxGenero.Checked == false) && (checkBoxAutor.Checked == false))
            {
                gvBuscadorObras.DataSource = DLObra.GetVistaConsultaObrasConAutor();
            }
        } 

        private void cboxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((checkBoxGenero.Checked == true) && (checkBoxAutor.Checked == true))
            {
                int idAutor = Int32.Parse(cboxAutor.SelectedValue.ToString());
                DataEntity.tbObrasMusicales obra = new DataEntity.tbObrasMusicales()
                {
                    idAutor = idAutor,
                    genero = cboxGenero.SelectedItem.ToString(),
                };
                gvBuscadorObras.DataSource = DLObra.FilterByBoth(obra);
            }
            else
            if (checkBoxGenero.Checked == true)
            {
                if (cboxGenero.SelectedIndex != 0)
                {
                    DataEntity.tbObrasMusicales obra = new DataEntity.tbObrasMusicales()
                    {
                        genero = cboxGenero.SelectedItem.ToString(),
                    };
                    gvBuscadorObras.DataSource = DLObra.FilterByGenero(obra);
                }
                else
                if (cboxGenero.SelectedIndex == 0)
                {
                    gvBuscadorObras.DataSource = DLObra.GetVistaConsultaObrasConAutor();
                }   
            }  
        }
        private void cboxAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((checkBoxGenero.Checked == true) && (checkBoxAutor.Checked == true))
            {
                int idAutor = Int32.Parse(cboxAutor.SelectedValue.ToString());
                DataEntity.tbObrasMusicales obra = new DataEntity.tbObrasMusicales()
                {
                    idAutor = idAutor,
                    genero = cboxGenero.SelectedItem.ToString(),
                };
                gvBuscadorObras.DataSource = DLObra.FilterByBoth(obra);
            }
            else
            if (checkBoxAutor.Checked == true)
            {
                if (cboxAutor.SelectedIndex != 0)
                {
                    int idAutor = Int32.Parse(cboxAutor.SelectedValue.ToString());
                    DataEntity.tbObrasMusicales obra = new DataEntity.tbObrasMusicales()
                    {
                        idAutor = idAutor,
                    };
                    gvBuscadorObras.DataSource = DLObra.FilterByAutor(obra);
                }
                else
                if (cboxGenero.SelectedIndex == 0)
                {
                    gvBuscadorObras.DataSource = DLObra.GetVistaConsultaObrasConAutor();
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gvBuscadorObras.CurrentRow != null)
            {
                DataEntity.tbObrasMusicales obra = new DataEntity.tbObrasMusicales
                {
                    idObra = Int32.Parse(gvBuscadorObras.CurrentRow.Cells[0].Value.ToString())
                };
                FRM_VisualizadorObra frm = new FRM_VisualizadorObra(obra);
                this.Hide();
                frm.ShowDialog();
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
