using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassinoCraft
{
    /// <summary>
    /// Classe de jogadores
    /// </summary>
    public class Jogador
    {
        #region Propriedades
        /// <summary>
        /// Variavel privada de nome
        /// </summary>
        private string nome;

        /// <summary>
        /// Propriedade de Nome(string) do Jogador
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new Exception("Nome invalido");
                }
                else
                {
                    nome = value;
                }
            }
        }

        /// <summary>
        /// Propriedade de Gasto(double) do Jogador
        /// </summary>
        public double Gasto { get; set; }

        /// <summary>
        /// Propriedade de quantidade de Moedas(int) do Jogador
        /// </summary>
        public int QntdMoeda { get; set; }

        /// <summary>
        /// Propriedade de Ganho(double) do Jogador
        /// </summary>
        public double Ganho { get; set; }

        /// <summary>
        /// Propriedade de Lucro do Jogador. Só há retorno.
        /// </summary>
        public double Lucro
        {
            get
            {
                return Ganho - Gasto;
            }
        }
        #endregion

        #region Variaveis Estatica
        /// <summary>
        /// Lista estatica de jogadores cadastrados 
        /// </summary>
        public static List<Jogador> jogadores = new List<Jogador>();  

        /// <summary>
        /// Jogador estatico atual
        /// </summary>
        public static Jogador atual = new Jogador();
        #endregion

        #region Metodos e Construtores
        public override string ToString()
        {
            StringBuilder conteudo = new StringBuilder();
            conteudo.AppendLine("Nome: " + Nome);
            conteudo.AppendLine("Quantidade de Moedas: " + QntdMoeda.ToString());
            conteudo.AppendLine("Gasto total: " + Gasto.ToString("F2"));
            conteudo.AppendLine("Ganho total: " + Ganho.ToString("F2"));
            conteudo.AppendLine("Lucro total: " + Lucro.ToString("F2"));
            conteudo.AppendLine("");
            return conteudo.ToString();
        }

        /// <summary>
        /// Construtor padrão do Jogador
        /// </summary>
        public Jogador()
        {
            Nome = "aux";
            Gasto = 0;
            QntdMoeda = 0;
            Ganho = 0;
        }

        /// <summary>
        /// Construtor de Jogador a partir de um nome(string)
        /// </summary>
        /// <param name="nome"></param>
        public Jogador(string nome)
        {
            Nome = nome;
            Gasto = 0;
            QntdMoeda = 0;
            Ganho = 0;
        }
        #endregion

    }
}
