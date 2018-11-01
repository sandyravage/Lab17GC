using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab17GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17GC.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void PrimeNumberGenerator_GetsPrime_True()
        {
            int expected = 157;
            int actual = Program.PrimeNumberGenerator(37);
            Assert.AreEqual(expected, actual);
        }
    }
}