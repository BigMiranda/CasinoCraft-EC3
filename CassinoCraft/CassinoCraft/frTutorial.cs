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
    public partial class frTutorial : Form
    {
        public frTutorial()
        {
            InitializeComponent();
            BotaoTransparente(btnVoltar);
        }

        private void btnVoltar_Click(object sender, EventArgs e) //Fecha Forms
        {
            Close();
        }
    }
}
