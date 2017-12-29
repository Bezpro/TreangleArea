using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreangleArea;

namespace TreangleAreaTest
{
    [TestClass]
    public class TreangleTest
    {
        [TestMethod]
        public void Area_3and4and5_6returned()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            double actual = Treangle.GetArea(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        public void Area_5and5and5_0returned()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 0;
            double actual = Treangle.GetArea(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
