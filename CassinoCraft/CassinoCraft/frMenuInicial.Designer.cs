
namespace CassinoCraft
{
    partial class frMenuInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMenuInicial));
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnCalculos = new System.Windows.Forms.Button();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.btnPontuacoes = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.wmpMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmpSound = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(462, 295);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(6);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(358, 55);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnCalculos
            // 
            this.btnCalculos.Location = new System.Drawing.Point(462, 647);
            this.btnCalculos.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalculos.Name = "btnCalculos";
            this.btnCalculos.Size = new System.Drawing.Size(358, 62);
            this.btnCalculos.TabIndex = 1;
            this.btnCalculos.Text = "Calculos";
            this.btnCalculos.UseVisualStyleBackColor = true;
            this.btnCalculos.Click += new System.EventHandler(this.btnCalculos_Click);
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.Location = new System.Drawing.Point(462, 472);
            this.btnOpcoes.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(358, 59);
            this.btnOpcoes.TabIndex = 2;
            this.btnOpcoes.Text = "Opções";
            this.btnOpcoes.UseVisualStyleBackColor = true;
            this.btnOpcoes.Click += new System.EventHandler(this.btnOpcoes_Click);
            // 
            // btnPontuacoes
            // 
            this.btnPontuacoes.Location = new System.Drawing.Point(462, 410);
            this.btnPontuacoes.Margin = new System.Windows.Forms.Padding(6);
            this.btnPontuacoes.Name = "btnPontuacoes";
            this.btnPontuacoes.Size = new System.Drawing.Size(358, 59);
            this.btnPontuacoes.TabIndex = 3;
            this.btnPontuacoes.Text = "Pontuações";
            this.btnPontuacoes.UseVisualStyleBackColor = true;
            this.btnPontuacoes.Click += new System.EventHandler(this.btnPontuacoes_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(15, 647);
            this.btnSobre.Margin = new System.Windows.Forms.Padding(6);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(363, 62);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnTutorial
            // 
            this.btnTutorial.Location = new System.Drawing.Point(462, 353);
            this.btnTutorial.Margin = new System.Windows.Forms.Padding(6);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(358, 54);
            this.btnTutorial.TabIndex = 5;
            this.btnTutorial.Text = "Tutorial";
            this.btnTutorial.UseVisualStyleBackColor = true;
            this.btnTutorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(912, 647);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(362, 62);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // wmpMusic
            // 
            this.wmpMusic.Enabled = true;
            this.wmpMusic.Location = new System.Drawing.Point(162, 148);
            this.wmpMusic.Name = "wmpMusic";
            this.wmpMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMusic.OcxState")));
            this.wmpMusic.Size = new System.Drawing.Size(285, 46);
            this.wmpMusic.TabIndex = 20;
            this.wmpMusic.Visible = false;
            // 
            // wmpSound
            // 
            this.wmpSound.Enabled = true;
            this.wmpSound.Location = new System.Drawing.Point(162, 200);
            this.wmpSound.Name = "wmpSound";
            this.wmpSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSound.OcxState")));
            this.wmpSound.Size = new System.Drawing.Size(285, 46);
            this.wmpSound.TabIndex = 19;
            this.wmpSound.Visible = false;
            // 
            // frMenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CassinoCraft.Properties.Resources.Slide2;
            this.ClientSize = new System.Drawing.Size(1289, 715);
            this.ControlBox = false;
            this.Controls.Add(this.wmpMusic);
            this.Controls.Add(this.wmpSound);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnPontuacoes);
            this.Controls.Add(this.btnOpcoes);
            this.Controls.Add(this.btnCalculos);
            this.Controls.Add(this.btnJogar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frMenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CassinoCraft";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnCalculos;
        private System.Windows.Forms.Button btnOpcoes;
        private System.Windows.Forms.Button btnPontuacoes;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.Button btnSair;
        private AxWMPLib.AxWindowsMediaPlayer wmpMusic;
        private AxWMPLib.AxWindowsMediaPlayer wmpSound;
    }
}

