using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ElmurzaevIH.Sprint1.Task2.V20.Lib
{
    public class DataService : ISprint1Task2V20
    {
        public int CalculateSquaresSumm(int value, int valueTwo)
        {
            return value * value + valueTwo * valueTwo;
        }
    }
}
