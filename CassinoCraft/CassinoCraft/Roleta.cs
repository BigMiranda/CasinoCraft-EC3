using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassinoCraft
{
    /// <summary>
    /// Classe de Roleta
    /// </summary>
    public class Roleta
    {
        #region Variavies para criar o disco padrão da roleta e para comparativos do resultado
        /// <summary>
        /// Variavel publica estatica de Imagem "pig"
        /// </summary>
        public static Imagem Pig = new Imagem("pig");

        /// <summary>
        /// Variavel publica estatica de Imagem "enderman"
        /// </summary>
        public static Imagem Enderman = new Imagem("enderman");

        /// <summary>
        /// Variavel publica estatica de Imagem "creeper"
        /// </summary>
        public static Imagem Creeper = new Imagem("creeper");
        #endregion

        /// <summary>
        /// Propriedade publica da posição/ordem do disco
        /// </summary>
        public int qntdOrdem { get; set; }

        /// <summary>
        /// Lista publica estatica de Imagem contendo a sequencia do disco padrão
        /// </summary>
        public static List<Imagem> imagens = new List<Imagem> { Pig , Pig , Enderman , Pig ,
                                                                 Creeper, Pig ,Enderman ,
                                                                Pig ,Pig , Enderman };
        
        /// <summary>
        /// Construtor de Roleta a partir de uma posição/ordem do disco
        /// (normalmente dado por um gerador aleatorio para simular aleatoriedade)
        /// </summary>
        /// <param name="gerador">posição/ordem do disco</param>
        public Roleta(int gerador)
        {
            qntdOrdem = gerador;
        }
    }
}
