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
        public Cadastro(String Nome, String Conta, String Agencia)
        {
            //1 - Comando sql --SqlComand
            cmd.CommandText = "insert into Users (nome, conta, agencia) values (@Nome, @Conta, @Agencia)";

            //Parametros
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@conta", Conta);
            cmd.Parameters.AddWithValue("@agencia", Agencia);


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
