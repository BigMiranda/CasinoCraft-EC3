
namespace CassinoCraft
{
    partial class frOpcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frOpcoes));
            this.wmpSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.tbMusica = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSom = new System.Windows.Forms.TrackBar();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btAplicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMusica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSom)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpSound
            // 
            this.wmpSound.Enabled = true;
            this.wmpSound.Location = new System.Drawing.Point(285, 513);
            this.wmpSound.Name = "wmpSound";
            this.wmpSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSound.OcxState")));
            this.wmpSound.Size = new System.Drawing.Size(285, 46);
            this.wmpSound.TabIndex = 22;
            this.wmpSound.Visible = false;
            // 
            // tbMusica
            // 
            this.tbMusica.BackColor = System.Drawing.Color.BurlyWood;
            this.tbMusica.Location = new System.Drawing.Point(216, 190);
            this.tbMusica.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.tbMusica.Maximum = 100;
            this.tbMusica.Name = "tbMusica";
            this.tbMusica.Size = new System.Drawing.Size(429, 45);
            this.tbMusica.TabIndex = 0;
            this.tbMusica.Value = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(138, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Musica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(155, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sons";
            // 
            // tbSom
            // 
            this.tbSom.BackColor = System.Drawing.Color.BurlyWood;
            this.tbSom.Location = new System.Drawing.Point(216, 280);
            this.tbSom.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.tbSom.Maximum = 100;
            this.tbSom.Name = "tbSom";
            this.tbSom.Size = new System.Drawing.Size(429, 45);
            this.tbSom.TabIndex = 3;
            this.tbSom.Value = 80;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(88, 452);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(272, 55);
            this.btVoltar.TabIndex = 9;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btAplicar
            // 
            this.btAplicar.Location = new System.Drawing.Point(468, 452);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(269, 55);
            this.btAplicar.TabIndex = 8;
            this.btAplicar.Text = "Aplicar e Voltar";
            this.btAplicar.UseVisualStyleBackColor = true;
            this.btAplicar.Click += new System.EventHandler(this.btAplicar_Click);
            // 
            // frOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CassinoCraft.Properties.Resources.Slide4;
            this.ClientSize = new System.Drawing.Size(841, 571);
            this.ControlBox = false;
            this.Controls.Add(this.tbMusica);
            this.Controls.Add(this.wmpSound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAplicar);
            this.Controls.Add(this.tbSom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frOpcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções";
            this.Load += new System.EventHandler(this.frOpcoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMusica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar tbMusica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbSom;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btAplicar;
        private AxWMPLib.AxWindowsMediaPlayer wmpSound;
    }
}