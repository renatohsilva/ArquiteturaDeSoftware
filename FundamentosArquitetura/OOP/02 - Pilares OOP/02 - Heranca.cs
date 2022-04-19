using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string? Registro { get; set; }
    }

    public class Processo
    {
        public static void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "Renato Henrique Silva",
                DataNascimento = new DateTime(1988,11,29),
                DataAdmissao = DateTime.Now,
                Registro = "0123456",
            };

            funcionario.CalcularIdade();
        }
    }
}
