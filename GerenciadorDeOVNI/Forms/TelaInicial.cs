using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVNI.Forms
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            // Popular o comboBox com os planetas validos:
            cmbPlanetas.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int maxTripulantes = int.Parse(nudTripulantes.Value.ToString());
            int maxAbduzidos = int.Parse(nudAbduzidos.Value.ToString());

            if(maxTripulantes >= 1 && maxAbduzidos >= 1)
            {
                // Instanciar o OVNI:
                var veiculo = new BibliotecaOVNI.OVNI(maxTripulantes,
                    maxAbduzidos, cmbPlanetas.Text);
                // chamar o painel de controle:
                var painel = new PainelDeControle(veiculo);
                // mostrar o painel de controle:
                painel.ShowDialog();

            }
            else
            {
                MessageBox.Show("Insira informações válidas!",
                    "Erro",MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void llblSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
