
namespace CassinoCraft
{
    partial class frPontuacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPontuacoes));
            this.wmpSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.txtPontuacoes = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpSound
            // 
            this.wmpSound.Enabled = true;
            this.wmpSound.Location = new System.Drawing.Point(174, 627);
            this.wmpSound.Name = "wmpSound";
            this.wmpSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSound.OcxState")));
            this.wmpSound.Size = new System.Drawing.Size(285, 46);
            this.wmpSound.TabIndex = 22;
            this.wmpSound.Visible = false;
            // 
            // txtPontuacoes
            // 
            this.txtPontuacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPontuacoes.Location = new System.Drawing.Point(88, 88);
            this.txtPontuacoes.Multiline = true;
            this.txtPontuacoes.Name = "txtPontuacoes";
            this.txtPontuacoes.ReadOnly = true;
            this.txtPontuacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPontuacoes.Size = new System.Drawing.Size(479, 506);
            this.txtPontuacoes.TabIndex = 23;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(640, 558);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(172, 63);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frPontuacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CassinoCraft.Properties.Resources.Slide3;
            this.ClientSize = new System.Drawing.Size(864, 666);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtPontuacoes);
            this.Controls.Add(this.wmpSound);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frPontuacoes";
            this.Text = "Pontuacoes";
            this.Load += new System.EventHandler(this.frPontuacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpSound;
        private System.Windows.Forms.TextBox txtPontuacoes;
        private System.Windows.Forms.Button btnVoltar;
    }
}