using Negocio;
using System;
using System.Collections.Generic;

namespace ProvaPraticaPOO
{
    public interface IRepositorio
    {
        void SalvePlanoDeSaude(Plano plano);
        Plano ConsultePlanoDeSaude(string nome);
        void SalvePaciente(Paciente paciente);
        Paciente ConsultePaciente(string cpf);
        void SalveMedico(Medico medico);
        Medico ConsulteMedico(int crm);
        void SalveEndereco(Endereco endereco);
        Endereco ConsulteEndereco(int cep);
        void SalveConsulta(Consulta consulta);
        List<Consulta> ConsulteConsulta(DateTime data);
        void SalveEspecialidade(Especialidade especialidade);
        Especialidade ConsulteEspecialidade(Especialidade nome);
    }
}
