using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas.DAL
{
    internal class Sacar
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public String mensagem = "";
        public Sacar(String v_conta, String agencia, String conta)
        {
            //Sacar
            //Comandos
            cmd.CommandText = "declare @valor1 money, @valor2 money, @valorRecebido money; set @valorRecebido = @v_conta; set @valor2 = (select v_conta from Users where agencia = @agencia and conta = @conta); set @valor1 = (@valor2 - @valorRecebido); update Users set v_conta = @valor1 where agencia = @agencia and conta = @conta";

            //Parametros
            cmd.Parameters.AddWithValue("@v_conta", v_conta);
            cmd.Parameters.AddWithValue("@agencia", agencia);
            cmd.Parameters.AddWithValue("@conta", conta);

            try
            {
                //Conectar com banco --Conexao
                cmd.Connection = conexao.conectar();

                //Executar comando
                cmd.ExecuteNonQuery();

                //Desconectar
                conexao.desconnectar();

                //Mostrar mensagem de erro ou sucesso --Variavel
                this.mensagem = "Sacado com Sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Ocorreu o erro:" + e;
            }
        }
    }
}
