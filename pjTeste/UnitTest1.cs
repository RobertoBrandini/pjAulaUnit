using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace pjTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteCalculoZerado()
        {
            Assert.AreEqual( Negocio.Calculo.AumentoSalario(0 , 0), 0 );
        }

        [TestMethod]
        public void TesteCalculoSemAumento()
        {
            Assert.AreEqual(Negocio.Calculo.AumentoSalario(100, 0), 100);
        }

        [TestMethod]
        public void TesteCalculoAumentoSalarioDezPorcento()
        {
            Assert.AreEqual(Negocio.Calculo.AumentoSalario(100, 10), 110);
        }

        [TestMethod]
        public void TesteCalculoAumentoSalarioDezPorcentoDecimal()
        {
            Assert.AreEqual(Negocio.Calculo.AumentoSalario(100.10m, 10), 110.11m);
        }

        [TestMethod]
        public void TesteCalculoAumentoSalarioDezPorcentoDecimalFixo()
        {
            Assert.AreEqual(Negocio.Calculo.AumentoSalario(100.10m), 110.11m);
        }
    }
}
