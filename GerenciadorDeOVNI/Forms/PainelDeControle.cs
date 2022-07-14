using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaOVNI;

namespace GerenciadorDeOVNI.Forms
{
    public partial class PainelDeControle : Form
    {
        // Ovni global:
        private OVNI _ovni;

        private void AtualizarTudo()
        {
            //lblSituacao.Text = 
        }

        public PainelDeControle(OVNI ovni)
        {
            InitializeComponent();
            _ovni = ovni;
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {

        }
    }
}
