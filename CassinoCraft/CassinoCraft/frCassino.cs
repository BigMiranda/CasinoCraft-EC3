using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CassinoCraft.DadosCompartilhados;

namespace CassinoCraft
{
    public partial class frCassino : Form
    {
        #region Inicialização e Variáveis da tela
        /// <summary>
        /// Lista de roletas (A, B e C) presentes no Forms
        /// </summary>
        List<Roleta> roletas = new List<Roleta>();
        /// <summary>
        /// Gerador int aleatorio
        /// </summary>
        Random gerador = new Random();


        int parar = 0, //int que sinalizara a quantidade de ticks necessaria para parar a roleta
            qntdTics = 0, //int que sinaliza a quantidade de ticks do timer (movimento roleta)
            toca1 = 1, //Limitador de som (orb.mp3) para tocar somente 1 vez após a roleta A parar
            toca2 = 1; //Limitador de som (orb.mp3) para tocar somente 1 vez após a roleta B parar

        public frCassino()
        {
            InitializeComponent();
            roletas.Add(new Roleta(gerador.Next(0, 10)));
            roletas.Add(new Roleta(gerador.Next(0, 10)));
            roletas.Add(new Roleta(gerador.Next(0, 10)));
            EscreveDados(0);
            int x = pRoletaA.Top;
            int tamanho = pRoletaA.Height;
            lbNome.Text = Jogador.atual.Nome;
        }
        private void frCassino_Load(object sender, EventArgs e)
        {
            wmpMusic.settings.volume = volumeMusica;
            wmpSound.settings.volume = volumeSom;
            wmpMusic = TocaMusica(wmpMusic, "Earthbound_Sanctuary_Guardian.mp3");
        }
        #endregion

        #region Movimento Roleta

        /// <summary>
        /// Metodo void que atualizará as imagens da roleta A a partir da posição/ordem do disco
        /// </summary>
        public void AtualizaImagemRA()
        {
            img3A.Image = img2A.Image;
            img2A.Image = img1A.Image;
            if (roletas[0].qntdOrdem == 10)
                roletas[0].qntdOrdem = 0;
            img1A.Image = Roleta.imagens[roletas[0].qntdOrdem].Desenho;
            roletas[0].qntdOrdem++;
        }

        /// <summary>
        /// Metodo void que atualizará as imagens da roleta B a partir da posição/ordem do disco
        /// </summary>
        public void AtualizaImagemRB()
        {
            img3B.Image = img2B.Image;
            img2B.Image = img1B.Image;
            if (roletas[1].qntdOrdem == 10)
                roletas[1].qntdOrdem = 0;
            img1B.Image = Roleta.imagens[roletas[1].qntdOrdem].Desenho;
            roletas[1].qntdOrdem++;
        }

        /// <summary>
        /// Metodo void que atualizará as imagens da roleta C a partir da posição/ordem do disco
        /// </summary>
        public void AtualizaImagemRC()
        {
            img3C.Image = img2C.Image;
            img2C.Image = img1C.Image;
            if (roletas[2].qntdOrdem == 10)
                roletas[2].qntdOrdem = 0;
            img1C.Image = Roleta.imagens[roletas[2].qntdOrdem].Desenho;
            roletas[2].qntdOrdem++;
        }

        private void tMovimento_Tick(object sender, EventArgs e)
        {
            qntdTics++;
            if (qntdTics < parar - 10)//Condição para roleta A rodar
            {
                AtualizaImagemRA();
            }
            else
            {
                if (toca1 == 1)
                { wmpSound = TocaSom(wmpSound, "orb.mp3"); toca1--; }
            }
            if (qntdTics < parar)//Condição para roleta B rodar
            {
                AtualizaImagemRB();
            }
            else
            {
                if (toca2 == 1)
                { wmpSound = TocaSom(wmpSound, "orb.mp3"); toca2--; }
            }
            if (qntdTics < parar + 10)//Condição para roleta C rodar
            {
                AtualizaImagemRC();
            }
            else
            {
                toca1 = 1;
                toca2 = 1;
                tMovimento1.Stop();
                qntdTics = 0; 
                Jogador.atual.Ganho += DevolvePontuacao();
                imgAlavanca.Image = CassinoCraft.Properties.Resources._11;
                EscreveDados();
            }
        }

        #endregion

        #region Pontuação

        /// <summary>
        /// Metodo para devolver a posição no disco da imagem no meio da roleta
        /// </summary>
        /// <param name="r">Roleta a ser analisada</param>
        /// <returns>A posição no disco dessa imagem no meio da roleta</returns>
        private int DevolveMeio(Roleta r)
        {
            if (r.qntdOrdem < 2)
                return 10 - r.qntdOrdem;
            else
                return r.qntdOrdem - 2;
        }

        /// <summary>
        /// Devolve pontuação (R$) ganho  na rodada
        /// </summary>
        /// <returns> Double valor ganho na rodada</returns>
        private double DevolvePontuacao()
        {
            int A = DevolveMeio(roletas[0]);
            int B = DevolveMeio(roletas[1]);
            int C = DevolveMeio(roletas[2]);
            if (Roleta.imagens[A].Nome == Roleta.Pig.Nome &&
               Roleta.imagens[B].Nome == Roleta.Pig.Nome &&
               Roleta.imagens[C].Nome == Roleta.Pig.Nome)
            {
                wmpSound = TocaSom(wmpSound, "pig.mp3");
                return 1;
            }
            else if (Roleta.imagens[A].Nome == Roleta.Creeper.Nome &&
               Roleta.imagens[B].Nome == Roleta.Creeper.Nome &&
               Roleta.imagens[C].Nome == Roleta.Creeper.Nome)
            {
                wmpSound = TocaSom(wmpSound, "creeper-explosion.mp3");
                return 5;
            }
            else if (Roleta.imagens[A].Nome == Roleta.Enderman.Nome &&
               Roleta.imagens[B].Nome == Roleta.Enderman.Nome &&
               Roleta.imagens[C].Nome == Roleta.Enderman.Nome)
            {
                wmpSound = TocaSom(wmpSound, "enderman.mp3");
                return 3;
            }
            else
            {
                wmpSound = TocaSom(wmpSound, "classic_hurt.mp3");
                return 0;
            }
        }

        /// <summary>
        /// Metodo para atualizar informações dos Label
        /// </summary>
        private void EscreveDados()
        {
            lblRodada.Text = "R$" + DevolvePontuacao().ToString("F2");
            lblLucro.Text = "Lucro: R$" + Jogador.atual.Lucro.ToString("F2");
            lblMoeda.Text = "Moedas: " + Jogador.atual.QntdMoeda;
        }

        /// <summary>
        /// Metodo Sobrescrito para atualizar informações do Label na PRIMEIRA RODADA
        /// </summary>
        /// <param name="a">Int que deve sempre 0</param>
        private void EscreveDados(int a)
        {
            lblRodada.Text = "R$" + a.ToString("F2");
            lblLucro.Text = "Lucro: R$" + Jogador.atual.Lucro.ToString("F2");
            lblMoeda.Text = "Moedas: " + Jogador.atual.QntdMoeda;
        }

        #endregion

        #region Ação
        private void imgAlavanca_Click(object sender, EventArgs e) // Roda Roleta
        {
            RodaRoleta();
        }

        private void TelaCassino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') //Roda Roleta
            {
                RodaRoleta();
            }
            if (e.KeyChar == (char)Keys.Enter) // Add Moeda
            {
                Jogador.atual.QntdMoeda++;
                wmpSound = TocaSom(wmpSound, "smw_coin.wav");
                lblMoeda.Text = "Moedas: " + Jogador.atual.QntdMoeda;
            }
            if(e.KeyChar == (char)Keys.Escape) // Fecha Cassino
            {
                Close();
            }
        }

        /// <summary>
        /// Metodo void para rodar as roletas
        /// </summary>
        private void RodaRoleta()
        {
            if (tMovimento1.Enabled) //Não permite rodar a roleta se já estiver rodando
            {
                return;
            } 
            else if (Jogador.atual.QntdMoeda <= 0) //Não permite rodar a roleta se não houver moedas
            {
                MessageBox.Show("Você não tem moedas o suficiente! \nPegue mais moedas teclando Enter!", "FALTA DE MOEDAS"
                                , MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            Jogador.atual.QntdMoeda--;
            tMovimento1.Start();
            imgAlavanca.Image = CassinoCraft.Properties.Resources._0;
            parar = gerador.Next(20, 30);
            wmpSound = TocaSom(wmpSound, "minecraft_click.mp3");
            Jogador.atual.Gasto += 1;
        }
        #endregion

        #region Finalização (Fechamento do Forms)
        private void TelaCassino_FormClosing(object sender, FormClosingEventArgs e)
        {            
            for(int i = 0; i < Jogador.jogadores.Count; i++) //Registra os dados do Jogador atual na lista de jogadores
            {
                if(Jogador.jogadores[i].Nome == Jogador.atual.Nome)
                {
                    double auxGasto, auxGanho;

                    auxGanho = Jogador.atual.Ganho;
                    auxGasto = Jogador.atual.Gasto;

                    Jogador.jogadores[i].Ganho = auxGanho;
                    Jogador.jogadores[i].Gasto = auxGasto;
                }
            }
            string conteudo = JsonConvert.SerializeObject(Jogador.jogadores); //Atualiza a lista de jogadores por Json
            File.WriteAllText("jogadores.json", conteudo);
        }
        #endregion


    }
}
