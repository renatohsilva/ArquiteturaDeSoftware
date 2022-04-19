namespace SOLID.SRP.SOLUCAO
{
    public class Cpf
    {
        public string Numero { get; set; }

        public Cpf()
        {
            Numero = "";
        }

        public bool Validar()
        {
            return Numero.Length == 11;
        }
    }
}