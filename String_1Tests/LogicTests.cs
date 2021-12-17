using Microsoft.VisualStudio.TestTools.UnitTesting;
using String_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace String_1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void ChangeTest()
        {
            string str = "процессор ппочта ммашина ккарусель";

            var count = Logic.Change(str);
            Assert.AreEqual(4,count);
        }
        [TestMethod()]
        public void ChangeTest_1()
        {

            string str = "деррево шинна колонна";

            var count = Logic.Change(str);
            Assert.AreEqual(3, count);

        }
        [TestMethod()]
        public void ChangeTest_2()
        {

            string str = "пппп дом";

            var count = Logic.Change(str);
            Assert.AreEqual(3, count);

        }

    } 
   

}