using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Solucao
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Debita Conta Investimento
            // Isentar Taxas
            return debitoConta.FormatarTransacao();
        }
    }
}
