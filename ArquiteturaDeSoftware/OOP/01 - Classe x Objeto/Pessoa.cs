using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._01___Classe_x_Objeto
{    
    // Definição de Classe
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {         
            // Definição de Objeto
            var pessoa = new Pessoa
            {
                Nome = "Renato",
                Idade = 33,
                Sexo = 'M'
            };
        }
    }
}
