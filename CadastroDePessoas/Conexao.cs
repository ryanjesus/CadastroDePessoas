using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace CadastroDePessoas
{
    public class Conexao
    {
        SqlConnection connection = new SqlConnection();

        //Construtor
        public Conexao()
        {
            connection.ConnectionString = (@"Data Source=DESKTOP-E267L7P\SQLEXPRESS;Initial Catalog=Contas;Integrated Security=True");
        }
        //Metodo Conectar

        public SqlConnection conectar()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        //Metodo Desconectar
        public void desconnectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
