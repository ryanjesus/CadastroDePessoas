namespace CadastroDePessoas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbConta = new System.Windows.Forms.TextBox();
            this.txbAgencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(277, 242);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(92, 37);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conta:";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbNome.Location = new System.Drawing.Point(86, 22);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(180, 23);
            this.txbNome.TabIndex = 3;
            // 
            // txbConta
            // 
            this.txbConta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbConta.Location = new System.Drawing.Point(86, 65);
            this.txbConta.Name = "txbConta";
            this.txbConta.Size = new System.Drawing.Size(100, 23);
            this.txbConta.TabIndex = 4;
            // 
            // txbAgencia
            // 
            this.txbAgencia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbAgencia.Location = new System.Drawing.Point(86, 109);
            this.txbAgencia.Name = "txbAgencia";
            this.txbAgencia.Size = new System.Drawing.Size(100, 23);
            this.txbAgencia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Agencia:";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbEmail.Location = new System.Drawing.Point(86, 148);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(180, 23);
            this.txbEmail.TabIndex = 7;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(23, 148);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 19);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSenha.Location = new System.Drawing.Point(18, 186);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(55, 19);
            this.lbSenha.TabIndex = 9;
            this.lbSenha.Text = "Senha:";
            this.lbSenha.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbSenha.Location = new System.Drawing.Point(86, 186);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(180, 23);
            this.txbSenha.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(381, 291);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbAgencia);
            this.Controls.Add(this.txbConta);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private TextBox txbNome;
        private TextBox txbConta;
        private TextBox txbAgencia;
        private Label label3;
        private TextBox txbEmail;
        private Label lbEmail;
        private Label lbSenha;
        private TextBox txbSenha;
    }
}