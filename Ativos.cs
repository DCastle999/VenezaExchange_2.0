using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenexaExchangeForm
{
	public class Ativos
	{
		public string tipo { get; set; }
        public string nomeAtivo { get; set; }
		public double valor { get; set; }
		public int quantidade { get; set; }

        public Ativos()
        { }
		public Ativos(string tipo, string nomeAtivo, double valor, int quantidade)
        {
            this.tipo = tipo;
            this.nomeAtivo = nomeAtivo;
            this.valor = valor;
            this.quantidade = quantidade;
        }
    }
}
