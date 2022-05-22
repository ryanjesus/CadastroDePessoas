namespace CadastroDePessoas.Apresentação
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.tbSair = new System.Windows.Forms.Button();
            this.btEntrar = new System.Windows.Forms.Button();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btcadastreSe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSair
            // 
            this.tbSair.Location = new System.Drawing.Point(376, 193);
            this.tbSair.Name = "tbSair";
            this.tbSair.Size = new System.Drawing.Size(77, 23);
            this.tbSair.TabIndex = 0;
            this.tbSair.Text = "Sair";
            this.tbSair.UseVisualStyleBackColor = false;
            this.tbSair.Click += new System.EventHandler(this.tbSair_Click);
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(290, 193);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(75, 23);
            this.btEntrar.TabIndex = 1;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(223, 135);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(42, 15);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha:";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(223, 100);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(40, 15);
            this.lbLogin.TabIndex = 3;
            this.lbLogin.Text = "Login:";
            this.lbLogin.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbLogin
            // 
            this.txbLogin.BackColor = System.Drawing.SystemColors.Info;
            this.txbLogin.Location = new System.Drawing.Point(290, 97);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(163, 23);
            this.txbLogin.TabIndex = 5;
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.SystemColors.Info;
            this.txbSenha.Location = new System.Drawing.Point(290, 132);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(163, 23);
            this.txbSenha.TabIndex = 6;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btcadastreSe
            // 
            this.btcadastreSe.Location = new System.Drawing.Point(339, 290);
            this.btcadastreSe.Name = "btcadastreSe";
            this.btcadastreSe.Size = new System.Drawing.Size(114, 34);
            this.btcadastreSe.TabIndex = 8;
            this.btcadastreSe.Text = "CADASTRE - SE";
            this.btcadastreSe.UseVisualStyleBackColor = false;
            this.btcadastreSe.Click += new System.EventHandler(this.btcadastreSe_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(533, 350);
            this.Controls.Add(this.btcadastreSe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.tbSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button tbSair;
        private Button btEntrar;
        private Label lbSenha;
        private Label lbLogin;
        private TextBox txbLogin;
        private TextBox txbSenha;
        private PictureBox pictureBox1;
        private Button btcadastreSe;
    }
}