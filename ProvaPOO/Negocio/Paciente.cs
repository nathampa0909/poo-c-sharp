using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Paciente : IDadosBasicos
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public Plano Plano { get; set; }

        public Paciente(IDadosBasicos dadosBasicos,
            Plano plano, string cpf)
        {
            Nome = dadosBasicos.Nome;
            DataDeNascimento = dadosBasicos.DataDeNascimento;
            Endereco = dadosBasicos.Endereco;
            Idade = dadosBasicos.Idade;
            CPF = cpf;
            Plano = plano;
        }
    }
}
