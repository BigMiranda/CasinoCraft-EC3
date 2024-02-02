
namespace CassinoCraft
{
    partial class frLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frLogin));
            this.lbNomes = new System.Windows.Forms.ListBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.wmpSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomes
            // 
            this.lbNomes.FormattingEnabled = true;
            this.lbNomes.ItemHeight = 25;
            this.lbNomes.Location = new System.Drawing.Point(42, 238);
            this.lbNomes.Name = "lbNomes";
            this.lbNomes.Size = new System.Drawing.Size(517, 354);
            this.lbNomes.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(584, 48);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(168, 53);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(584, 316);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(168, 57);
            this.btnLogar.TabIndex = 5;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // wmpSound
            // 
            this.wmpSound.Enabled = true;
            this.wmpSound.Location = new System.Drawing.Point(517, 567);
            this.wmpSound.Name = "wmpSound";
            this.wmpSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSound.OcxState")));
            this.wmpSound.Size = new System.Drawing.Size(285, 46);
            this.wmpSound.TabIndex = 21;
            this.wmpSound.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(584, 424);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(168, 53);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(167, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(379, 30);
            this.txtNome.TabIndex = 23;
            // 
            // frLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CassinoCraft.Properties.Resources.Slide8;
            this.ClientSize = new System.Drawing.Size(796, 637);
            this.ControlBox = false;
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.wmpSound);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbNomes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbNomes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLogar;
        private AxWMPLib.AxWindowsMediaPlayer wmpSound;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNome;
    }
}