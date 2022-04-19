namespace DemoDI.Models
{
    public class Cliente
    {
        public Cliente(string nome)
        {
            Nome = nome;
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
