using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class Calculo
    {

        public static Decimal AumentoSalario(Decimal SalarioAtual, Decimal PercentualAumento)
        {
            return SalarioAtual * (1 + (PercentualAumento/100));
        }

        public static Decimal AumentoSalario(Decimal SalarioAtual)
        {
            return SalarioAtual * (1.20m);
        }

    }
}

