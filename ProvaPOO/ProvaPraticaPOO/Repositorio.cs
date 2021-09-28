using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPraticaPOO
{
    public class Repositorio : IRepositorio
    {
        private List<Especialidade> _especialidades;
        private List<Plano> _planos;
        private List<Endereco> _enderecos;
        private List<Medico> _medicos;
        private List<Paciente> _pacientes;
        private List<Consulta> _consultas;

        public List<Consulta> ConsulteConsulta(DateTime data)
        {
            List<Consulta> consultas = new List<Consulta>(); 
            _consultas.ForEach(consulta =>
            {
                if (consulta.DataDaConsulta.Equals(data))
                    consultas.Add(consulta);
            });
            return consultas;
        }

        public Endereco ConsulteEndereco(int cep)
        {
            Endereco endereco = null;
            _enderecos.ForEach(edr =>
            {
                if (edr.CEP == cep)
                    endereco = edr;
            });
            return endereco;
        }

        public Especialidade ConsulteEspecialidade(Especialidade nome)
        {
            Especialidade esp;
            _especialidades.ForEach(especialidade =>
            {
                if (especialidade.Equals(nome))
                    esp = especialidade;
            });
            return esp;
        }

        public Medico ConsulteMedico(int crm)
        {
            Medico medico = null;
            _medicos.ForEach(mdc =>
            {
                if (mdc.CRM == crm)
                    medico = mdc;
            });
            return medico;
        }

        public Paciente ConsultePaciente(string cpf)
        {
            Paciente paciente = null;
            _pacientes.ForEach(pcnt =>
            {
                if (pcnt.CPF.Equals(cpf))
                    paciente = pcnt;
            });
            return paciente;
        }

        public Plano ConsultePlanoDeSaude(string nome)
        {
            Plano plano = null;
            _planos.ForEach(pln =>
            {
                if (pln.NomeDoPlano.Equals(nome))
                    plano = pln;
            });
            return plano;
        }

        public void SalveConsulta(Consulta consulta)
        {
            _consultas.Add(consulta);
        }

        public void SalveEndereco(Endereco endereco)
        {
            _enderecos.Add(endereco);
        }

        public void SalveEspecialidade(Especialidade especialidade)
        {
            _especialidades.Add(especialidade);
        }

        public void SalveMedico(Medico medico)
        {
            _medicos.Add(medico);
        }

        public void SalvePaciente(Paciente paciente)
        {
            _pacientes.Add(paciente);
        }

        public void SalvePlanoDeSaude(Plano plano)
        {
            _planos.Add(plano);
        }
    }
}
