using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint1.Task4.V6.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint1.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 5;
            double y = 4;

            var wait = 0.55;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
