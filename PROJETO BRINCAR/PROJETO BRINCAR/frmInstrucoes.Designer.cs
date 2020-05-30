namespace PROJETO_BRINCAR
{
    partial class frmInstrucoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstrucoes));
            this.txtInstrucoes = new System.Windows.Forms.TextBox();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInstrucoes
            // 
            this.txtInstrucoes.BackColor = System.Drawing.Color.White;
            this.txtInstrucoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstrucoes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstrucoes.ForeColor = System.Drawing.Color.Black;
            this.txtInstrucoes.Location = new System.Drawing.Point(162, 203);
            this.txtInstrucoes.Multiline = true;
            this.txtInstrucoes.Name = "txtInstrucoes";
            this.txtInstrucoes.Size = new System.Drawing.Size(245, 217);
            this.txtInstrucoes.TabIndex = 0;
            this.txtInstrucoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.BackColor = System.Drawing.Color.SkyBlue;
            this.lblInstrucao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInstrucao.Location = new System.Drawing.Point(162, 168);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(245, 32);
            this.lblInstrucao.TabIndex = 1;
            this.lblInstrucao.Text = "Como Jogar";
            this.lblInstrucao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::PROJETO_BRINCAR.Properties.Resources.seta;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(-2, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(71, 54);
            this.btnSair.TabIndex = 10;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmInstrucoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::PROJETO_BRINCAR.Properties.Resources.fundointrucoes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 610);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblInstrucao);
            this.Controls.Add(this.txtInstrucoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInstrucoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instruções";
            this.Load += new System.EventHandler(this.frmInstrucoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInstrucoes;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Button btnSair;

    }
}