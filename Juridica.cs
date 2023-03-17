using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenexaExchangeForm
{
	class Juridica : Pessoa
	{
		public string cnpj { get; set; }
		public Juridica(string nome, string cnpj, string localidade, string associacao)
        {
            this.cnpj = cnpj;
			this.nome = nome;
			this.localidade = localidade;
			this.associacao = associacao;
		}
    }
}