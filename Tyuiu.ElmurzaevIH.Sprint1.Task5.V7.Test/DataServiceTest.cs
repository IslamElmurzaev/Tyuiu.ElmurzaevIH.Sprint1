using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var result = ds.AngleToHoursMinutes(119.67);
            var wait = 3;

            Assert.AreEqual(wait, result);
        }
    }
}
