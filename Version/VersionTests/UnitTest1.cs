using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Version;

namespace VersionTests
{
    [TestClass]
    public class UnitTest1
    {
        ComVersion example = new ComVersion();
        [TestMethod]
        public void Result_01_11()
        {
            string a = "0.1";
            string b = "1.1";
            int expected = -1;

            int actual = example.CompareVersion(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Result_101_1()
        {
            string a = "1.0.1";
            string b = "1";
            int expected = 1;

            int actual = example.CompareVersion(a, b);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Result_10_100()
        {
            string a = "1.0";
            string b = "1.0.0";
            int expected = 0;

            int actual = example.CompareVersion(a, b);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Result_101_1001()
        {
            string a = "1.01";
            string b = "1.001";
            int expected = 0;

            int actual = example.CompareVersion(a, b);
           
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Result_13004_230()
        {
            string a = "1.3.0.0.4";
            string b = "2.3.0";
            int expected = -1;
   
            int actual = example.CompareVersion(a, b);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Result_13004_2300()
        {
            string a = "1.3.0.0.4";
            string b = "2.3.0.0";
            int expected = 1;
           
            int actual = example.CompareVersion(a, b);

            Assert.AreNotEqual(expected, actual);
        }
    }
}
