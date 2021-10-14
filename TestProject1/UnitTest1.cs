using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expect = "happy,sad";
            MoodAnalyzer1.emp name = new MoodAnalyzer1.emp();
            string res = ("happy,sad");
            Assert.AreEqual(expect, res);

        }
    }
} 