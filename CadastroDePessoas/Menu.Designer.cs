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
            this.components = new System.ComponentModel.Container();
            this.btSacar = new System.Windows.Forms.Button();
            this.btDepositar = new System.Windows.Forms.Button();
            this.lbAgencia = new System.Windows.Forms.Label();
            this.lbConta = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.blValor = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.txbConta = new System.Windows.Forms.TextBox();
            this.txbAgencia = new System.Windows.Forms.TextBox();
            this.cadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btSacar
            // 
            this.btSacar.Location = new System.Drawing.Point(290, 236);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(100, 33);
            this.btSacar.TabIndex = 0;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // btDepositar
            // 
            this.btDepositar.Location = new System.Drawing.Point(153, 236);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(100, 33);
            this.btDepositar.TabIndex = 1;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = true;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // lbAgencia
            // 
            this.lbAgencia.AutoSize = true;
            this.lbAgencia.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbAgencia.Location = new System.Drawing.Point(227, 84);
            this.lbAgencia.Name = "lbAgencia";
            this.lbAgencia.Size = new System.Drawing.Size(67, 19);
            this.lbAgencia.TabIndex = 3;
            this.lbAgencia.Text = "Agência:";
            // 
            // lbConta
            // 
            this.lbConta.AutoSize = true;
            this.lbConta.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbConta.Location = new System.Drawing.Point(47, 84);
            this.lbConta.Name = "lbConta";
            this.lbConta.Size = new System.Drawing.Size(53, 19);
            this.lbConta.TabIndex = 4;
            this.lbConta.Text = "Conta:";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbSaldo.Location = new System.Drawing.Point(51, 125);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(51, 19);
            this.lbSaldo.TabIndex = 5;
            this.lbSaldo.Text = "Saldo:";
            // 
            // blValor
            // 
            this.blValor.AutoSize = true;
            this.blValor.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.blValor.Location = new System.Drawing.Point(51, 178);
            this.blValor.Name = "blValor";
            this.blValor.Size = new System.Drawing.Size(49, 19);
            this.blValor.TabIndex = 6;
            this.blValor.Text = "Valor:";
            this.blValor.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbValor
            // 
            this.txbValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbValor.Location = new System.Drawing.Point(106, 174);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 23);
            this.txbValor.TabIndex = 7;
            // 
            // txbConta
            // 
            this.txbConta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbConta.Location = new System.Drawing.Point(106, 84);
            this.txbConta.Name = "txbConta";
            this.txbConta.Size = new System.Drawing.Size(100, 23);
            this.txbConta.TabIndex = 8;
            // 
            // txbAgencia
            // 
            this.txbAgencia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbAgencia.Location = new System.Drawing.Point(300, 84);
            this.txbAgencia.Name = "txbAgencia";
            this.txbAgencia.Size = new System.Drawing.Size(100, 23);
            this.txbAgencia.TabIndex = 9;
            // 
            // cadastroBindingSource
            // 
            this.cadastroBindingSource.DataSource = typeof(CadastroDePessoas.Cadastro);
            this.cadastroBindingSource.CurrentChanged += new System.EventHandler(this.cadastroBindingSource_CurrentChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(538, 311);
            this.Controls.Add(this.txbAgencia);
            this.Controls.Add(this.txbConta);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.blValor);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lbConta);
            this.Controls.Add(this.lbAgencia);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.btSacar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btSacar;
        private Button btDepositar;
        private Label lbAgencia;
        private Label lbConta;
        private Label lbSaldo;
        private Label blValor;
        private TextBox txbValor;
        private TextBox txbConta;
        private TextBox txbAgencia;
        private BindingSource cadastroBindingSource;
    }
}