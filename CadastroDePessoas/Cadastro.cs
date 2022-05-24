using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    public class Cadastro
    {   
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        //public bool tem = false;
        public Cadastro(String Nome, String Conta, String Agencia, String Email, String Senha)
        {
            //1 - Comando sql --SqlComand
            cmd.CommandText = "insert into Users (nome, conta, agencia, email, senha) values (@Nome, @Conta, @Agencia, @Email, @Senha)";

            //Parametros
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@conta", Conta);
            cmd.Parameters.AddWithValue("@agencia", Agencia);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@senha", Senha);

            try
            {
                //Conectar com banco --Conexao
                cmd.Connection = conexao.conectar();

                //Executar comando
                cmd.ExecuteNonQuery();

                //Desconectar
                conexao.desconnectar();

                //Mostrar mensagem de erro ou sucesso --Variavel
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Ocorreu o erro:" + e;
            }

            
        }
    }
}
