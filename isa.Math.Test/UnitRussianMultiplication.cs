using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace isa.Math.Test
{
    /// <summary>Tests für Russische Bauernmultiplikation</summary>
    /// <remarks> isa.Math.dll {  isa.Math.RussianMultiplication.Mul } </remarks>

    [TestClass]
    public class UnitRussianMultiplication
    {
        /// <summary>Test isa.Math.RussianMultiplication.Mul(Random.Next, Random.Next)</summary>
        /// <remarks> Zahlenreihe von Multiplikatoren,Multiplikant (20 mal Random 0-1000) </remarks>
        [TestMethod]
        public void RussianMultiplicationRandomRangeValue()
        {
            Random rnd = new Random();
            for (int ctr = 1; ctr <= 20; ctr++)
            {
                int multiplier = rnd.Next(0, 1000);
                int multiplicand = rnd.Next(0, 1000);
                int product = isa.Math.RussianMultiplication.Mul(multiplicand, multiplier);
                Assert.AreEqual(product, multiplicand * multiplier);
            }

        }

        /// <summary>Test isa.Math.RussianMultiplication.Mul(100, 0)</summary>
        /// <remarks>Multiplikator ist 0  (multiplier == 0)</remarks>
        [TestMethod]
        public void RussianMultiplicationMultiplierZero()
        {
            int product = isa.Math.RussianMultiplication.Mul(100, 0);
            Assert.AreEqual(product, 100 * 0);
        }

        /// <summary>Test isa.Math.RussianMultiplication.Mul(+, -)</summary>
        /// <remarks>Multiplikator ist eine negative zahl (multiplier kleiner 0)</remarks>
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void RussianMultiplicationMultiplierNegation()
        {
            isa.Math.RussianMultiplication.Mul(5, -100);
        }

        /// <summary>Test isa.Math.RussianMultiplication.Mul(0, 100)</summary>
        /// <remarks>Multiplikant ist 0 (multiplicand == 0)</remarks>
        [TestMethod]
        public void RussianMultiplicationMultiplicandZero()
        {
            int product = isa.Math.RussianMultiplication.Mul(0, 100);
            Assert.AreEqual(product, 0 * 100);

        }

        /// <summary>Test isa.Math.RussianMultiplication.Mul(-, +)</summary>
        /// <remarks>Multiplikant ist eine negative Zahl / ExpectedException ArgumentOutOfRangeException</remarks>
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void RussianMultiplicationMultiplicandNegation()
        {
            isa.Math.RussianMultiplication.Mul(-2, 100);
        }

        /// <summary>Test isa.Math.RussianMultiplication.Mul(0, 0)</summary>
        /// <remarks>Multiplikant und  Multiplikator sind 0 (multiplicand == 0) (multiplier == 0)</remarks>
        [TestMethod]
        public void RussianMultiplicationMultiplicandAndMultiplierZero()
        {
            int product = isa.Math.RussianMultiplication.Mul(0, 0);
            Assert.AreEqual(product, 0 * 0);
        }

        /// <summary>Test isa.Math.RussianMultiplication.Mul(-, -)</summary>
        /// <remarks>Multiplikant und  Multiplikator sind eine negative Zahl / (multiplier kleiner 0) (multiplicand kleiner 0)  / ExpectedException ArgumentOutOfRangeException </remarks>
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void RussianMultiplicationMultiplicandAndMultiplierNegation()
        {
            isa.Math.RussianMultiplication.Mul(-10, -100);
        }
    }

}
