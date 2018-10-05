using DLLfile;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethods()
        {
            Converting obj = new Converting();

            double expected = 283.4952;
            double actual = obj.ConvertToGrams(10);
            double delta = 0.0001;

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethods1()
        {
            Converting obj = new Converting();

            double expected = 0.2822;
            double actual = obj.ConvertToOunces(8);
            double delta = 0.0001;

            Assert.AreEqual(expected, actual, delta);
        }

    }
}
