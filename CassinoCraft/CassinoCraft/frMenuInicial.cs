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
using System.IO;

namespace CassinoCraft
{
    public partial class frMenuInicial : Form
    {
        #region Inicialização do Programa
        public frMenuInicial()
        {
            InitializeComponent();
            if (File.Exists("opcoes.txt"))  //Verifica se existe o arquivo de opcoes.txt
            {
                string conteudo = File.ReadAllText("opcoes.txt");//Retira as informaçoes de opcoes.txt
                string[] valores = conteudo.Split('|');
                volumeMusica = int.Parse(valores[0]);
                volumeSom = int.Parse(valores[1]);
            }
            else //Se nao ouver, ele cria um opcoes.txt
            {
                File.WriteAllText("opcoes.txt", "80|80");
            }
            FechaTudo = false;
            BotaoTransparente(btnJogar);
            BotaoTransparente(btnCalculos);
            BotaoTransparente(btnOpcoes);
            BotaoTransparente(btnPontuacoes);
            BotaoTransparente(btnSair);
            BotaoTransparente(btnSobre);
            BotaoTransparente(btnTutorial);

        }

        private void Form1_Load(object sender, EventArgs e) //Ao iniciar o programa, ele abre o forms de Login e esconde o MenuPrincipal
        {
            frLogin telaJogador = new frLogin();
            Visible = false;
            telaJogador.ShowDialog();
            telaJogador.Close();
            if (FechaTudo) //Se a pessoa quis sair do programa direto do forms de Login
                System.Windows.Forms.Application.Exit();
            else //Se não, mostra o forms MenuPrincipal e toca a musica inicial
            {
                Visible = true;
                wmpMusic = TocaMusica(wmpMusic, "Earthbound_Onett_Night_1.mp3");
            }
        }
        #endregion

        #region Ações
        private void button1_Click(object sender, EventArgs e) //Abre o forms de Tutorial
        {
            frTutorial telaTutorial = new frTutorial();
            Visible = false;
            telaTutorial.ShowDialog();
            telaTutorial.Close();
            Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e) //Sai do programa
        {
            Close();
        }

        private void btnJogar_Click(object sender, EventArgs e) //Abre o forms do Cassino
        {
            wmpMusic.Ctlcontrols.pause();
            Visible = false;
            frCassino telaCassino = new frCassino();
            telaCassino.ShowDialog();
            telaCassino.Close();
            Visible = true;
            wmpMusic.Ctlcontrols.play();
        }

        private void btnSobre_Click(object sender, EventArgs e)//Abre o forms do Sobre
        {
            Visible = false;
            frSobre telaSobre = new frSobre();
            telaSobre.ShowDialog();
            telaSobre.Close();
            Visible = true;
            
        }

        private void btnPontuacoes_Click(object sender, EventArgs e)//Abre o forms de Pontuações
        {
            Visible = false;
            frPontuacoes telaPontuacoes = new frPontuacoes();
            telaPontuacoes.ShowDialog();
            telaPontuacoes.Close();
            Visible = true;
        }

        private void btnOpcoes_Click(object sender, EventArgs e)//Abre o forms de Opções
        {
            Visible = false;
            frOpcoes telaOpcoes = new frOpcoes();
            telaOpcoes.ShowDialog();
            telaOpcoes.Close();
            wmpSound.settings.volume = volumeSom;
            wmpMusic.settings.volume = volumeMusica;
            Visible = true;
        }

        private void btnCalculos_Click(object sender, EventArgs e)//Abre o forms de Calculos
        {
            Visible = false;
            frCalculos telaCalculo = new frCalculos();
            telaCalculo.ShowDialog();
            telaCalculo.Close();
            Visible = true;
        }
        #endregion
    }
}
