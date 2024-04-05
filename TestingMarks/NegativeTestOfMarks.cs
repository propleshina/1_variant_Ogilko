using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _1_вариант_Огилько;

namespace TestingMarks
{
    [TestClass]
    public class NegativeTestOfMarks
    {
        [TestMethod]
        public void NegativeTest()
        {
            var page = new MainWindow();
            Assert.IsFalse(page.Check("", "", "", ""));
            Assert.IsFalse(page.Check("0", "-1", "0", "0"));
            Assert.IsFalse(page.Check("100", "20", "0", "0"));
            Assert.IsFalse(page.Check("10", "100", "0", "10"));
            Assert.IsFalse(page.Check("10", "50", "100", "0"));
            Assert.IsFalse(page.Check("10", "20", "0.5", "1000"));
            Assert.IsFalse(page.Check("a", ",", "0", "10"));
            Assert.IsFalse(page.Check("10", "50", "", "0"));
        }
    }
}
