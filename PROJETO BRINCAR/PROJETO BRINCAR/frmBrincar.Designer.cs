namespace PROJETO_BRINCAR
{
    partial class frmBrincar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrincar));
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblBrincadeira = new System.Windows.Forms.Label();
            this.pcbImagem = new System.Windows.Forms.PictureBox();
            this.btnBrincar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.picX = new System.Windows.Forms.PictureBox();
            this.btnBrincadeiras = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTexto.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.Black;
            this.lblTexto.Location = new System.Drawing.Point(39, 44);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(394, 45);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "DO QUE VAMOS BRINCAR HOJE?";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrincadeira
            // 
            this.lblBrincadeira.BackColor = System.Drawing.Color.White;
            this.lblBrincadeira.Font = new System.Drawing.Font("Buxton Sketch", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrincadeira.ForeColor = System.Drawing.Color.Orange;
            this.lblBrincadeira.Location = new System.Drawing.Point(39, 89);
            this.lblBrincadeira.Name = "lblBrincadeira";
            this.lblBrincadeira.Size = new System.Drawing.Size(394, 51);
            this.lblBrincadeira.TabIndex = 1;
            this.lblBrincadeira.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbImagem
            // 
            this.pcbImagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbImagem.BackColor = System.Drawing.Color.Transparent;
            this.pcbImagem.Location = new System.Drawing.Point(39, 145);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(394, 212);
            this.pcbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagem.TabIndex = 2;
            this.pcbImagem.TabStop = false;
            // 
            // btnBrincar
            // 
            this.btnBrincar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBrincar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrincar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnBrincar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrincar.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrincar.ForeColor = System.Drawing.Color.White;
            this.btnBrincar.Location = new System.Drawing.Point(128, 373);
            this.btnBrincar.Name = "btnBrincar";
            this.btnBrincar.Size = new System.Drawing.Size(238, 48);
            this.btnBrincar.TabIndex = 3;
            this.btnBrincar.Text = "BRINCAR!";
            this.btnBrincar.UseVisualStyleBackColor = false;
            this.btnBrincar.Click += new System.EventHandler(this.btnBrincar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(128, 507);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(238, 56);
            this.btnCadastro.TabIndex = 4;
            this.btnCadastro.Text = "CADASTRAR BRINCADEIRA";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // picIcone
            // 
            this.picIcone.BackColor = System.Drawing.Color.Transparent;
            this.picIcone.Image = global::PROJETO_BRINCAR.Properties.Resources.imagem;
            this.picIcone.Location = new System.Drawing.Point(0, 0);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(51, 41);
            this.picIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcone.TabIndex = 5;
            this.picIcone.TabStop = false;
            // 
            // picX
            // 
            this.picX.BackColor = System.Drawing.Color.Transparent;
            this.picX.Image = global::PROJETO_BRINCAR.Properties.Resources.X;
            this.picX.Location = new System.Drawing.Point(471, 1);
            this.picX.Name = "picX";
            this.picX.Size = new System.Drawing.Size(34, 29);
            this.picX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picX.TabIndex = 6;
            this.picX.TabStop = false;
            this.picX.Click += new System.EventHandler(this.picX_Click);
            // 
            // btnBrincadeiras
            // 
            this.btnBrincadeiras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBrincadeiras.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrincadeiras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnBrincadeiras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrincadeiras.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrincadeiras.ForeColor = System.Drawing.Color.White;
            this.btnBrincadeiras.Location = new System.Drawing.Point(128, 442);
            this.btnBrincadeiras.Name = "btnBrincadeiras";
            this.btnBrincadeiras.Size = new System.Drawing.Size(238, 48);
            this.btnBrincadeiras.TabIndex = 7;
            this.btnBrincadeiras.Text = "BRINCADEIRAS";
            this.btnBrincadeiras.UseVisualStyleBackColor = false;
            this.btnBrincadeiras.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.BackColor = System.Drawing.Color.Transparent;
            this.btnLivro.BackgroundImage = global::PROJETO_BRINCAR.Properties.Resources.livro;
            this.btnLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLivro.FlatAppearance.BorderSize = 0;
            this.btnLivro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivro.Location = new System.Drawing.Point(439, 276);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(64, 79);
            this.btnLivro.TabIndex = 8;
            this.btnLivro.UseVisualStyleBackColor = false;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // frmBrincar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::PROJETO_BRINCAR.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(505, 573);
            this.Controls.Add(this.btnLivro);
            this.Controls.Add(this.btnBrincadeiras);
            this.Controls.Add(this.picX);
            this.Controls.Add(this.picIcone);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnBrincar);
            this.Controls.Add(this.pcbImagem);
            this.Controls.Add(this.lblBrincadeira);
            this.Controls.Add(this.lblTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrincar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROJETO BRINCAR";
            this.Load += new System.EventHandler(this.frmBrincar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblBrincadeira;
        private System.Windows.Forms.PictureBox pcbImagem;
        private System.Windows.Forms.Button btnBrincar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.PictureBox picX;
        private System.Windows.Forms.Button btnBrincadeiras;
        private System.Windows.Forms.Button btnLivro;
    }
}

