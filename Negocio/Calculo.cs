using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class Calculo
    {

        /// <summary>
        /// Aumento Salario com percentuals
        /// </summary>
        /// <param name="SalarioAtual"></param>
        /// <param name="PercentualAumento"></param>
        /// <returns></returns>
        public static Decimal AumentoSalario(Decimal SalarioAtual, Decimal PercentualAumento)
        {
            return SalarioAtual * (1 + (PercentualAumento/100));
        }

        /// <summary>
        /// Aumento Salario padrao
        /// </summary>
        /// <param name="SalarioAtual"></param>
        /// <returns></returns>
        public static Decimal AumentoSalario(Decimal SalarioAtual)
        {
            return SalarioAtual * (1.20m);
        }

    }
}

