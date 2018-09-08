using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals.Core.Operation;

namespace RomanNumerals.Test.Core
{
    [TestClass]
    public class RomanNumTest
    {
        #region [Fields]

        private RomanNums romanNums;


        #endregion


        #region [Constructors]

        public RomanNumTest()
        {
            romanNums = new RomanNums();
        }

        #endregion


        [TestMethod]
        public void TestZeroNum()
        {
            Assert.IsTrue(romanNums.Parse(0) == "", "0 can not be converted to roman numerals.!");
        }

        [TestMethod]
        public void TesNonValidNum()
        {
            try
            {
                var test = romanNums.Parse(-23);
                Assert.Fail("No exception thrown.");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }


        [TestMethod]
        public void TestSpecialNumber()
        {
            Assert.IsTrue(romanNums.Parse(1) == "I", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(2) == "II", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(3) == "III", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(4) == "IV", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(5) == "V", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(9) == "IX", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(10) == "X", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(14) == "XIV", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(19) == "XIX", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(40) == "XL", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(49) == "XLIX", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(50) == "L", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(90) == "XC", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(99) == "XCIX", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(100) == "C", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(369) == "CCCLXIX", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(400) == "CD", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(432) == "CDXXXII", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(448) == "CDXLVIII", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(499) == "CDXCIX", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(500) == "D", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(505) == "DV", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(900) == "CM", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(901) == "CMI", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(2111) == "MMCXI", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(2751) == "MMDCCLI", "Not a valid translation!");
            Assert.IsTrue(romanNums.Parse(3159) == "MMMCLIX", "Not a valid translation!");
        }
    }
}
