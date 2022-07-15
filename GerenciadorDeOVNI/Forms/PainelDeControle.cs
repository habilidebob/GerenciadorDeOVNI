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
            // Atualizar os labels:
            lblAbduzidos.Text = "Abduzidos: " + _ovni.QtdAbduzidos;
            lblTripulantes.Text = "Tripulantes: " + _ovni.QtdTripulantes;
            // Verificar se o OVNI está ligado ou não:
            if (_ovni.Situacao == true)
            {
                lblSituacao.Text = "Situação: Ligado";
            }
            else
            {
                lblSituacao.Text = "Situação: Desligado";
            }
            lblPlanetaAtual.Text = "Planeta Atual: "+ _ovni.PlanetaAtual;

            // Atualizar botões de abdução de acordo com a situação:
            btnAbduzir.Enabled = _ovni.Situacao;
            btnDesabduzir.Enabled = _ovni.Situacao;
            cmbPlanetas.Enabled = _ovni.Situacao;
            btnMudarPlaneta.Enabled = _ovni.Situacao;
        }

        public PainelDeControle(OVNI ovni)
        {
            InitializeComponent();
            _ovni = ovni;
            // Preencher o combobox com os planetas válidos:
            cmbPlanetas.DataSource = OVNI.PlanetasValidos;
            AtualizarTudo();
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            // Verificar se o OVNI está ligado ou desligado:
            if(_ovni.Situacao == false)
            {
                _ovni.Ligar();
                btnLigar.Text = "Desligar";
            }
            else
            {
                _ovni.Desligar();
                btnLigar.Text = "Ligar";
            }
            AtualizarTudo();
        }

        private void btnAddTripulante_Click(object sender, EventArgs e)
        {
            // Verificar se não foi possível adicionar um tripulante:
            if(_ovni.AdicionarTripulante() == false)
            {
                MessageBox.Show("Máximo de tripulantes atingido!");
            }
            AtualizarTudo();
        }
    }
}
