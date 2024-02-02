
namespace CassinoCraft
{
    partial class frCalculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCalculos));
            this.wmpSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.imgCalculos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCalculos)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpSound
            // 
            this.wmpSound.Enabled = true;
            this.wmpSound.Location = new System.Drawing.Point(410, 648);
            this.wmpSound.Name = "wmpSound";
            this.wmpSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSound.OcxState")));
            this.wmpSound.Size = new System.Drawing.Size(285, 46);
            this.wmpSound.TabIndex = 20;
            this.wmpSound.Visible = false;
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.Location = new System.Drawing.Point(802, 639);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(90, 64);
            this.btnEsquerda.TabIndex = 21;
            this.btnEsquerda.Text = "Esquerda";
            this.btnEsquerda.UseVisualStyleBackColor = true;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // btnDireita
            // 
            this.btnDireita.Location = new System.Drawing.Point(925, 639);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(90, 64);
            this.btnDireita.TabIndex = 22;
            this.btnDireita.Text = "Direita";
            this.btnDireita.UseVisualStyleBackColor = true;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1090, 639);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(171, 64);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // imgCalculos
            // 
            this.imgCalculos.BackColor = System.Drawing.Color.Transparent;
            this.imgCalculos.Image = global::CassinoCraft.Properties.Resources.Calculos1;
            this.imgCalculos.Location = new System.Drawing.Point(92, 12);
            this.imgCalculos.Name = "imgCalculos";
            this.imgCalculos.Size = new System.Drawing.Size(1076, 607);
            this.imgCalculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCalculos.TabIndex = 24;
            this.imgCalculos.TabStop = false;
            // 
            // frCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CassinoCraft.Properties.Resources.Slide6;
            this.ClientSize = new System.Drawing.Size(1289, 715);
            this.ControlBox = false;
            this.Controls.Add(this.imgCalculos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.wmpSound);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frCalculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculos";
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCalculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpSound;
        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox imgCalculos;
    }
}