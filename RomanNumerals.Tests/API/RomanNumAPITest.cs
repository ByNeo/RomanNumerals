using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals.API.Controllers;

namespace RomanNumerals.Test.API
{
    [TestClass]
    public class RomanNumAPITest
    {
        RomanNumeralsController api = new RomanNumeralsController();

        [TestMethod]
        public void TestParse()
        {
            var result = api.Converter(40);
            Assert.IsTrue(result.IsSuccessful);
            Assert.AreEqual(result.Data, "XL");
        }
    }
}
