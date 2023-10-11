using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_PilasOColas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_PilasOColas.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ValidarDeSimbolosTest()
        {
            bool result = Ejercicio_PilasOColas.Program.ValidarDeSimbolos("(2+3-12]*{8/3})");
            Assert.IsFalse(result);
        }
    }
}