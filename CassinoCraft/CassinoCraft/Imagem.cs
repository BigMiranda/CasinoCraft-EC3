using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassinoCraft
{
    /// <summary>
    /// Classe imagem para roleta
    /// </summary>
    public class Imagem 
    {
        /// <summary>
        /// Propriedade do nome da imagem
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Propriedade do desenho da imagem
        /// </summary>
        public System.Drawing.Image Desenho { get; set; }

        /// <summary>
        /// Constroi uma imagem a partir do nome de entrada
        /// </summary>
        /// <param name="nome">"pig", "creeper" ou "enderman"</param>
        public Imagem(string nome)
        {
            if(nome=="pig")
            {
                Desenho = CassinoCraft.Properties.Resources.pig;
                Nome = nome;
            }
            if (nome == "creeper")
            {
                Desenho = CassinoCraft.Properties.Resources.creeper;
                Nome = nome;
            }
            if (nome == "enderman")
            {
                Desenho = CassinoCraft.Properties.Resources.enderman;
                Nome = nome;
            }
        }

        /// <summary>
        /// Constutor padrão
        /// </summary>
        public Imagem()
        {
            Desenho = null;
            Nome = null;
        }
    }
}
