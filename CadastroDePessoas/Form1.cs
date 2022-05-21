namespace CadastroDePessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(txbNome.Text, txbConta.Text, txbAgencia.Text);
            MessageBox.Show(cad.mensagem); 
        }
    }
}