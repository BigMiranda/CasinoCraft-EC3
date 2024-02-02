
namespace CassinoCraft
{
    partial class frTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frTutorial));
            this.wmpSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpSound
            // 
            this.wmpSound.Enabled = true;
            this.wmpSound.Location = new System.Drawing.Point(203, 657);
            this.wmpSound.Name = "wmpSound";
            this.wmpSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSound.OcxState")));
            this.wmpSound.Size = new System.Drawing.Size(285, 46);
            this.wmpSound.TabIndex = 22;
            this.wmpSound.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(636, 558);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(175, 61);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CassinoCraft.Properties.Resources.Slide51;
            this.ClientSize = new System.Drawing.Size(842, 715);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.wmpSound);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frTutorial";
            this.Text = "Tutorial";
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpSound;
        private System.Windows.Forms.Button btnVoltar;
    }
}