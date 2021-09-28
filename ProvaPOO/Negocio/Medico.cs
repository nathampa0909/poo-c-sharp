using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Medico : IDadosBasicos
    {
        private List<Especialidade> _especialidades = 
            new List<Especialidade>();

        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public int Idade { get; set; }
        public int CRM { get; set; }
        public IEnumerable<Especialidade> Especialidade 
        {
            get => _especialidades;
        }

        public void AdicioneEspecialidade(Especialidade especialidade)
        {
            _especialidades.Add(especialidade);
        }

        public void SetEspecialidades(Especialidade[] especialidades)
        {
            _especialidades = especialidades.ToList();
        }

        public Medico(string nome, DateTime dataDeNascimento, 
            Endereco endereco, int idade, int crm, Especialidade[] especialidades)
        {
            this.Nome = nome;
            this.DataDeNascimento = dataDeNascimento;
            this.Endereco = endereco;
            this.Idade = idade;
            this.CRM = crm;
            SetEspecialidades(especialidades);
        }
    }
}
