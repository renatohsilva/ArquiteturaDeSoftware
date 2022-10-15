namespace SOLID.SRP.SOLUCAO
{
    public class Email
    {
        public string Endereco { get; set; }

        public Email()
        {
            Endereco = "";
        }

        public bool Validar()
        {
            return Endereco.Contains("@");
        }
    }
}