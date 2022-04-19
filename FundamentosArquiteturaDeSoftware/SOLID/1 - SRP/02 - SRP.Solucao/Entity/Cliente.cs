using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.SOLUCAO
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Cpf Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public Cliente()
        {
            Nome = "";
            Email = new Email();
            Cpf = new Cpf();
        }

        public bool Validar()
        {
            return Email.Validar() && Cpf.Validar();
        }
    }
}
