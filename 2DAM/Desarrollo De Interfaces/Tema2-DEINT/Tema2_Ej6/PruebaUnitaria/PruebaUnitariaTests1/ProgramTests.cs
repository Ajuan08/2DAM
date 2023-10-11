using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaUnitaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitaria.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void devolverStringTest()
        {
            string result = PruebaUnitaria.Program.DevolverString(new string[] { "Luck ", "yo ", "soy ", "tu ", "padre." });
            Assert.AreEqual("Luck yo soy tu padre.", result);
        }

        [TestMethod()]
        public void SonIguales()
        {
            int num1 = 1;
            int num2 = 1;
            bool result = SonIguales(num1, num2);
            Assert.IsTrue(result);
        }

        private bool SonIguales(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }
}