using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BRFTesting
{
    [TestClass]
    public class UnitTest1
    {
        private Regex RX = new Regex("^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");
        private string[] romanPassCollection = {"I", "V", "X", "L", "C", "D", "M", "IV", "IX", "XI", "VI", "XL", "XC"};
        private string[] romanFailCollection = {"CX", "LX", "CD", "CM", "MC", "DC", "VV", "LL", "DD", "IIII", "VVVV", "XXXX", "LLLL", "CCCC", "DDDD", "MMMM"};

        [TestMethod]
        public void TestPassRegEx()
        {
            foreach (var s in romanPassCollection)
            {
                if (RX.IsMatch(s))
                {
                    Assert.IsTrue(true);
                }
            }
        }

        [TestMethod]
        public void TestFailRegEx()
        {
            foreach (var s in romanFailCollection)
            {
                if (!RX.IsMatch(s))
                {
                    Assert.IsTrue(true);
                }
            }
        }
    }
}
