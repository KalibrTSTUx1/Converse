using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Tests
{
    [TestClass()]
    public class ConvertionTests
    {
        [TestMethod()]
        public void RoundAnythingTest()
        {
            string num = "32,12";
            int znakKolvo = 1;
            string expected = "32,1";

            string res = Convertion.RoundAnything(num, znakKolvo);


            Assert.AreEqual(expected, res);
        }

        [TestMethod()]
        public void ConvertSysmsTest()
        {
            string num = "10";
            int baseof = 10;
            int resBase = 2;
            string expected = "1010";
            string res = Convertion.ConvertSysms(num, baseof, resBase);

            Assert.AreEqual(expected, res);
        }

        [TestMethod()]
        public void ConvertToDecTest()
        {
            string num = "10";
            int baseof = 2;
            string expected = "2";

            string res = Convertion.ConvertToDec(num, baseof);

            Assert.AreEqual(expected, res);
        }

        [TestMethod()]
        public void ConvertFromDecTest()
        {
            string num = "32";
            int resof = 16;
            string expected = "20";

            
            string res = Convertion.ConvertFromDec(num, resof);

            Assert.AreEqual(expected, res);
        }
    }
}