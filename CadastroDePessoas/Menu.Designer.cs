namespace CadastroDePessoas
{
    partial class Menu
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
            this.btSacar = new System.Windows.Forms.Button();
            this.btDepositar = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbAgencia = new System.Windows.Forms.Label();
            this.lbConta = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.blValor = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btSacar
            // 
            this.btSacar.Location = new System.Drawing.Point(296, 236);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(88, 33);
            this.btSacar.TabIndex = 0;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = true;
            // 
            // btDepositar
            // 
            this.btDepositar.Location = new System.Drawing.Point(153, 236);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(100, 33);
            this.btDepositar.TabIndex = 1;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = true;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(58, 57);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(50, 15);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbAgencia
            // 
            this.lbAgencia.AutoSize = true;
            this.lbAgencia.Location = new System.Drawing.Point(244, 87);
            this.lbAgencia.Name = "lbAgencia";
            this.lbAgencia.Size = new System.Drawing.Size(50, 15);
            this.lbAgencia.TabIndex = 3;
            this.lbAgencia.Text = "Agência";
            // 
            // lbConta
            // 
            this.lbConta.AutoSize = true;
            this.lbConta.Location = new System.Drawing.Point(58, 87);
            this.lbConta.Name = "lbConta";
            this.lbConta.Size = new System.Drawing.Size(42, 15);
            this.lbConta.TabIndex = 4;
            this.lbConta.Text = "Conta:";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(58, 121);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(39, 15);
            this.lbSaldo.TabIndex = 5;
            this.lbSaldo.Text = "Saldo:";
            // 
            // blValor
            // 
            this.blValor.AutoSize = true;
            this.blValor.Location = new System.Drawing.Point(58, 182);
            this.blValor.Name = "blValor";
            this.blValor.Size = new System.Drawing.Size(36, 15);
            this.blValor.TabIndex = 6;
            this.blValor.Text = "Valor:";
            this.blValor.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(100, 179);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 23);
            this.txbValor.TabIndex = 7;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 311);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.blValor);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lbConta);
            this.Controls.Add(this.lbAgencia);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.btSacar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btSacar;
        private Button btDepositar;
        private Label lbUsuario;
        private Label lbAgencia;
        private Label lbConta;
        private Label lbSaldo;
        private Label blValor;
        private TextBox txbValor;
    }
}