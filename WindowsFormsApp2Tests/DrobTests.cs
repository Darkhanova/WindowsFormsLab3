using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Tests
{
    [TestClass()]
    public class DrobTests
    {
        [TestMethod()]
        public void outputTestSum()
        {
            Drob drob1, drob2, drob3;
            drob1 = new Drob(1, 2);
            drob2 = new Drob(2, 3);
            drob3 = drob1 + drob2;
            String output = drob3.output();

            Assert.AreEqual(output, "7/6");
        }
        [TestMethod()]
        public void outputTestRaz()
        {
            Drob drob1, drob2, drob3;
            drob1 = new Drob(1, 2);
            drob2 = new Drob(2, 3);
            drob3 = drob1 - drob2;
            String output = drob3.output();

            Assert.AreEqual(output, "-1/6");
        }
        [TestMethod()]
        public void outputTestMultiply()
        {
            Drob drob1, drob2, drob3;
            drob1 = new Drob(1, 2);
            drob2 = new Drob(2, 3);
            drob3 = drob1 * drob2;
            String output = drob3.output();

            Assert.AreEqual(output, "2/6");
        }
        [TestMethod()]
        public void outputTestDivide()
        {
            Drob drob1, drob2, drob3;
            drob1 = new Drob(1, 2);
            drob2 = new Drob(2, 3);
            drob3 = drob1 / drob2;
            String output = drob3.output();

            Assert.AreEqual(output, "3/4");
        }
        [TestMethod()]
        public void outputTestComparison()
        {
            Drob drob1, drob2, drob3;
            drob1 = new Drob(1, 2);
            drob2 = new Drob(2, 4);
            drob3 = drob1 ^ drob2;
            String output = drob3.getStr;
            Assert.AreEqual(output, "Равны");
        }
        [TestMethod()]
        public void outputTestSokr()
        {
            Drob drob1, drob2, drob3;
            drob1 = new Drob(5, 15);
            drob2 = new Drob(0, 0);
            drob3 = drob1 % drob2;
            String output = drob3.output();

            Assert.AreEqual(output, "1/3");
        }

    }
}