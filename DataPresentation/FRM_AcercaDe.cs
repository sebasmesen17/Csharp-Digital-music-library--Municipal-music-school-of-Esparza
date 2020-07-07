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
    public partial class FRM_AcercaDe : Form
    {
        public FRM_AcercaDe()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void FRM_AcercaDe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            FRM_Inicio inicio = new FRM_Inicio();
            inicio.ShowDialog();
        }
    }
}
