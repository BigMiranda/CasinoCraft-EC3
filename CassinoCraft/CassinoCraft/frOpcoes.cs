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
using static CassinoCraft.DadosCompartilhados;

namespace CassinoCraft
{
    public partial class frOpcoes : Form
    {
        public frOpcoes()
        {
            InitializeComponent();
            BotaoTransparente(btAplicar);
            BotaoTransparente(btVoltar);
        }
        private void frOpcoes_Load(object sender, EventArgs e) // Ao iniciar o forms Opcoes, pega os valores já implementados
        {
            tbMusica.Value = volumeMusica;
            tbSom.Value = volumeSom;
        }

        #region Ações
        private void btVoltar_Click(object sender, EventArgs e) //Sai do forms de Opções sem salvar as alterações
        {
            Close();
        }

        private void btAplicar_Click(object sender, EventArgs e) //Aplica as opções e salva no arquivo opcoes.txt
        {
            File.WriteAllText("opcoes.txt", tbMusica.Value.ToString() + "|" + tbSom.Value.ToString());
            volumeMusica = tbMusica.Value;
            volumeSom = tbSom.Value;
            Close();
        }
        #endregion
    }
}
