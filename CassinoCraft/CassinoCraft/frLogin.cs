using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static CassinoCraft.DadosCompartilhados;

namespace CassinoCraft
{
    public partial class frLogin : Form
    {
        
        public frLogin()
        {
            InitializeComponent();
            if(File.Exists("jogadores.json"))
            {
                string conteudo = File.ReadAllText("jogadores.json");
                Jogador.jogadores = JsonConvert.DeserializeObject<List<Jogador>>(conteudo);
                foreach(Jogador aux in Jogador.jogadores)
                {
                    lbNomes.Items.Add(aux.Nome);
                }
            }
            BotaoTransparente(btnLogar);
            BotaoTransparente(btnSair);
            BotaoTransparente(btnSalvar);
        }

        #region Ações
        private void btnLogar_Click(object sender, EventArgs e) //Logar por um jogador já cadastrado
        {
            if(lbNomes.SelectedIndex<0)
                MessageBox.Show("Selecione um nome para logar!");
            else
            {
                Jogador aux = Jogador.jogadores.Find(j => j.Nome == lbNomes.SelectedItem);
                Jogador.atual = aux;
                Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) //Salvar e logar um jogador novo
        {
            try
            {
                Jogador.jogadores.Add(new Jogador(txtNome.Text));
                Jogador aux = Jogador.jogadores.Find(j => j.Nome == txtNome.Text);
                Jogador.atual = aux;
                string conteudo = JsonConvert.SerializeObject(Jogador.jogadores);
                File.WriteAllText("jogadores.json", conteudo);
                Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void btnSair_Click(object sender, EventArgs e) //Finaliza o programa
        {
            FechaTudo = true;
            Close();
        }
        #endregion
    }
}
