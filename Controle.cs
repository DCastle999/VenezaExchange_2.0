using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenexaExchangeForm
{
    internal class Controle
    {
        public bool tem;
        public string menssagem = "";
        public bool acessar(string usuario, string senha)
        {
            LoginComando loginco = new LoginComando();
            tem = loginco.verificarlogin(usuario, senha);
            if(!loginco.menssagem.Equals(""))
            {
                this.menssagem= loginco.menssagem;
            }
            return tem;
        }
        public string cadastrar(string usuario, string senha, string confirmarsenha)
        {
            LoginComando loginco = new LoginComando();
            this.menssagem = loginco.cadastrar(usuario, senha, confirmarsenha);

            if (loginco.tem)
            {
                this.tem = true;
            }
            return menssagem;
            }
    }
}
