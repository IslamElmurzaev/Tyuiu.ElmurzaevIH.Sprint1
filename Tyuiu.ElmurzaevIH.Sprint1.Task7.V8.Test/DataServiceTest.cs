using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint1.Task7.V8.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 75;
            var res = ds.Calculate(x, y);

            var wait = -67.878;
            Assert.AreEqual(wait, res);

        }
    }
}
