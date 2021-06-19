using EssentialTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTrainingTest
{[TestClass]
    public class SalsaSuperTest
    {
        [TestMethod]
        public void LaSalsaExisteTest()
        {
            var testInstancia = new SalsaSuper();
            testInstancia.Salsas.Add("Tabasco");
            testInstancia.Salsas.Add("Cholula");
            testInstancia.Salsas.Add("Chespirito");

            //espero TRUE
            Assert.IsTrue(testInstancia.LaSalsaExiste("Cholula"));

            //espero FALSE
            Assert.IsFalse(testInstancia.LaSalsaExiste("Gordillo"));

        }
    }
}
