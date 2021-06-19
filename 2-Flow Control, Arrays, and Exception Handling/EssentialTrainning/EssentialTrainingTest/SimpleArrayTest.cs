using EssentialTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTrainingTest
{[TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInstanciacion()
        {
            var testInstancia = new SimpleArray();
            Assert.AreEqual(testInstancia.ListaSuper.Length, 4);
            Assert.AreEqual(testInstancia.ListaSuper[1], "Milf");
        }

        [TestMethod]
        public void TestToString()
        {
            var testInstancia = new SimpleArray();
            Assert.IsTrue(testInstancia.ToString().StartsWith("Hay"));
        }
    }
}
