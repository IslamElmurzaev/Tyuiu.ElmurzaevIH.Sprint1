using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint1.Task3.V2.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double priceNotebook = 30; double pricePencil = 15;
            int amountNotebook = 3; int amountPencil = 2;

            var wait = 120;

            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);

            Assert.AreEqual(wait, res);
        }
    }
}
