using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }

        public Endereco(string logradouro, int numero,
            string bairro, int cep)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Bairro = bairro;
            this.CEP = cep;
        }
    }

}
