using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web;

using Tyuiu.ElmurzaevIH.Sprint1.Task6.V4.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string testStr = "Извержение Везувия подробно описано в адресованных: римскому историку Тациту письмах Плиния Младшеннго," +
                " раненного в тот страшный августовский месяц.";
            string res = ds.CheckDoubleN(testStr);
            
            string wait = "адресованных Младшеннго раненного";
            Assert.AreEqual(wait, res);
            
        }
    }
}
