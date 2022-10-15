using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Solucao
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            // Valida Aniversário da Conta
            // Debita Conta Corrente
            return debitoConta.FormatarTransacao();
        }
    }
}
