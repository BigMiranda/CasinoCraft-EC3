using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CassinoCraft
{
    class DadosCompartilhados
    {
        /// <summary>
        /// int compartilhado do volume de som
        /// </summary>
        public static int volumeSom; 

        /// <summary>
        /// int compartilhado do volume da musica
        /// </summary>
        public static int volumeMusica; 

        /// <summary>
        /// bool compartilhado para fechar o programa  de imediato
        /// </summary>
        public static bool FechaTudo; 

        #region Metodo para Botão Transparente
        public static void BotaoTransparente(Button btnClique)
        {
            btnClique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClique.FlatAppearance.BorderSize = 0;
            btnClique.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClique.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClique.BackColor = System.Drawing.Color.Transparent;
            btnClique.Text = "";
        }
        #endregion

        #region Sons e Musica
        public static AxWMPLib.AxWindowsMediaPlayer TocaMusica(AxWMPLib.AxWindowsMediaPlayer wmpMusic, string nomeMusica)
        {
            wmpMusic.settings.volume = volumeMusica;
            wmpMusic.URL = nomeMusica;
            wmpMusic.settings.setMode("loop", true);
            wmpMusic.Ctlcontrols.play();
            return wmpMusic;
        }

        public static AxWMPLib.AxWindowsMediaPlayer TocaSom(AxWMPLib.AxWindowsMediaPlayer wmpSound , string nomeSom)
        {
            wmpSound.settings.volume = volumeSom;
            wmpSound.URL = nomeSom;
            wmpSound.Ctlcontrols.play();
            return wmpSound;
        }
        #endregion


    }
}
