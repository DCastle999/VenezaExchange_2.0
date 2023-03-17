using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenexaExchangeForm
{
	class Fisica : Pessoa
	{
		public string cpf { get; set; }
		public Fisica(string nome, string cpf, string localidade, string associacao)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.localidade = localidade;
            this.associacao = associacao;
        }
    }
}