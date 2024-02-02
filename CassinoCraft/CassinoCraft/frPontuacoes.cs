using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CassinoCraft.DadosCompartilhados;

namespace CassinoCraft
{
    public partial class frPontuacoes : Form
    {
        public frPontuacoes()
        {
            InitializeComponent();
            BotaoTransparente(btnVoltar);
        }

        private void frPontuacoes_Load(object sender, EventArgs e) //Le o Jogador atual e a lista de jogadores a apresenta os dados
        {
            txtPontuacoes.Clear();
            txtPontuacoes.Text = "JOGADOR ATUAL:" + Environment.NewLine;
            txtPontuacoes.Text += Jogador.atual.ToString();
            txtPontuacoes.Text += "\n TODOS OS JOGADORES:" + Environment.NewLine;
            foreach(Jogador aux in Jogador.jogadores)
            {
                txtPontuacoes.Text += aux.ToString();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e) //Fecha forms
        {
            Close();
        }
    }
}
