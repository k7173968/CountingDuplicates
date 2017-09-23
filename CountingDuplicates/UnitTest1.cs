using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountingDuplicates
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testCase = new CountingDuplicates();
            Assert.AreEqual(0, testCase.countingDuplicates(""));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var testCase = new CountingDuplicates();
            Assert.AreEqual(0, testCase.countingDuplicates("abcde"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var testCase = new CountingDuplicates();
            Assert.AreEqual(2, testCase.countingDuplicates("aabbcde"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            var testCase = new CountingDuplicates();
            Assert.AreEqual(2, testCase.countingDuplicates("aabBcde"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            var testCase = new CountingDuplicates();
            Assert.AreEqual(1, testCase.countingDuplicates("Indivisibility"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            var testCase = new CountingDuplicates();
            Assert.AreEqual(2, testCase.countingDuplicates("Indivisibilities"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            var testCase = new CountingDuplicates();
            Assert.AreEqual(3, testCase.countingDuplicates("aa111"));
        }

        [TestMethod]
        public void TestMethod8()
        {
            var testCase = new CountingDuplicates();
            Assert.AreEqual(5, testCase.countingDuplicates("aa11@@@@@1"));
        }
    }
}
