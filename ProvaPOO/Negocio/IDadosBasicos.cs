using System;

namespace Negocio
{
    public interface IDadosBasicos
    {
        string Nome { get; set; }
        DateTime DataDeNascimento { get; set; }
        Endereco Endereco { get; set; }
        int Idade { get; set; }
    }
}
