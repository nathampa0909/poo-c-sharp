namespace Negocio
{
    public class Plano
    {
        public string NomeDoPlano { get; set; }
        public TiposDePlano TipoDePlano { get; set; }

        public Plano(string nomeDoPlano, TiposDePlano tipoDePlano)
        {
            this.NomeDoPlano = nomeDoPlano;
            this.TipoDePlano = tipoDePlano;
        }
    }
}