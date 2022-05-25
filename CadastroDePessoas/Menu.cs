using CadastroDePessoas.DAL;
using CadastroDePessoas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroDePessoas.Modelo;


namespace CadastroDePessoas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            ControleConta cc = new ControleConta(txbValor.Text, txbAgencia.Text, txbConta.Text);
            MessageBox.Show(cc.mensagem);
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            Sacar cc = new Sacar(txbValor.Text, txbAgencia.Text, txbConta.Text);
            MessageBox.Show(cc.mensagem);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastroBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
