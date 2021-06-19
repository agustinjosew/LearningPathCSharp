using System;
using EssentialTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTrainingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMetodo1()
        {
            var testInstancia = new Class1();
            var testResultado = testInstancia.SumarDosNumeros(10, 5);
            Assert.AreEqual(15, testResultado, "Espero 10 + 5 igual a 15");
        }

        [TestMethod]
        public void TestMetodo2()
        {
            var testInstancia = new Class1();
            var testResultado = testInstancia.SumarDosNumeros(10, 5);
            Assert.AreEqual(14, testResultado, "Espero 10 + 5 igual 15");
        }
    }
}
