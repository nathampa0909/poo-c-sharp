using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public struct Especialidade
    {
        internal string Nome { get; set; }

        public Especialidade(string nome)
        {
            Nome = nome;
        }
    }
}
