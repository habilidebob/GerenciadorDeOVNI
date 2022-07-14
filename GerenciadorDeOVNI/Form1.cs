using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // Instanciar a nova janela:
            var telaInicial = new Forms.TelaInicial();
            // Exibir a janela:
            telaInicial.ShowDialog();

            // Sair do programa:
            Application.Exit();
        }
    }
}
