using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Consulta
    {
        public DateTime DataDaConsulta { get; set; }
        public Paciente Paciente { get; }
        public Medico Medico { get; }

        public Consulta(Paciente paciente, Medico medico)
        {
            Paciente = paciente;
            Medico = medico;
        }

        public Consulta(Paciente paciente, Medico medico, DateTime dataDaConsulta)
        {
            Paciente = paciente;
            Medico = medico;
            DataDaConsulta = dataDaConsulta;
        }
    }
}
