using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _1_вариант_Огилько;

namespace TestingMarks
{
    [TestClass]
    public class PositiveTestOfMarks
    {
        [TestMethod]
        public void PositiveTests()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.Check("10","50","30","10"));
            Assert.IsTrue(page.Check("0", "0", "0", "0"));
            Assert.IsTrue(page.Check("1", "20", "0", "0"));
            Assert.IsTrue(page.Check("10", "10", "0", "10"));
            Assert.IsTrue(page.Check("10", "50", "0", "0"));
        }
    }
}
