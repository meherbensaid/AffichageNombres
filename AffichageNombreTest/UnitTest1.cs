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

        /// <summary>
        /// Tester la divisiblité multiple exemple 15 est divisible par 3 et 5 donc on doit 
        /// avoir FooBar car 15 et divisible par 3(devient Foo) et 5(devient Bar) en tenant en compte l'ordre 3,5,7 
        /// </summary>
        [TestMethod]
        public void DivisibiliteMultiple()
        {
            Nombre C = new Nombre();

            int val = 15;
            String expected = "FooBar";
            Assert.AreEqual(expected, C.divisibilité(val));
        }


    }
}
