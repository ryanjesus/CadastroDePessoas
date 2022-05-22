using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        //acessar
        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();

            //verificando login
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        //cadastrar

        public String cadastrar(String email, String senha, String ConfSenha)
        {
            return mensagem;
        }
    }
}
