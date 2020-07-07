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
    public partial class FRM_EliminarAdministrativos : Form
    {
        public FRM_EliminarAdministrativos()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void FRM_EliminarAdministrativos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'consultaAdministrador.tbAdministrador' Puede moverla o quitarla según sea necesario.
            this.tbAdministradorTableAdapter.Fill(this.consultaAdministrador.tbAdministrador);

        }

        private void FRM_EliminarAdministrativos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gvListaAdministradores.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Seguro que desea borrar este administrativo?", "Borrar Obra", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataEntity.tbAdministrador eliminar = new DataEntity.tbAdministrador
                    {
                        cedula = gvListaAdministradores.CurrentRow.Cells[0].Value.ToString()
                    };
                    DLRegistroAdmin.Eliminar(eliminar);
                    MessageBox.Show("Se elimino el autor selecionado", "Listo");
                    gvListaAdministradores.DataSource = DLRegistroAdmin.GetAll();
                }
            }
        }
    }
}
