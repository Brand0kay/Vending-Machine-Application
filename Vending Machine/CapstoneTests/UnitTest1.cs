using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class UnitTest1
    {
        SubMenu sub = new SubMenu();
        menuDisplay md = new menuDisplay();

        [TestMethod]
        public void CheckDisplayBalance()
        {
            sub.DisplayBalance = 5;
            Assert.AreEqual(5M, sub.DisplayBalance);
        }
    }
}
