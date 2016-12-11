using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AffichageNombres;
namespace AffichageNombreTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Divisibilite3()
        {
            Nombre C = new Nombre();

            int val = 9;
            Boolean expected = true;
            Assert.AreEqual(expected, C.SimpleDiv(val, 3));
        }

        [TestMethod]
        public void Divisibilite5()
        {
            Nombre C = new Nombre();

            int val = 20;
            Boolean expected = true;
            Assert.AreEqual(expected, C.SimpleDiv(val, 5));
        }

        [TestMethod]
        public void Divisibilite7()
        {
            Nombre C = new Nombre();

            int val = 28;
            Boolean expected = true;
            Assert.AreEqual(expected, C.SimpleDiv(val, 7));
        }
    }
}
