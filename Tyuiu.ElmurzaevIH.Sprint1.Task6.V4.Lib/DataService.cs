using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ElmurzaevIH.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string[] words = value.Split(' ');
            var res = "";

            foreach (string el in words)
            {
                string word = el;
                if (word.IndexOf("нн") > 0)
                {
                    if (word.IndexOf(',') > 0)
                    {
                        word = word.Trim(',');
                    }
                    
                    if (word.IndexOf('.') > 0)
                    {
                        word = word.Trim('.');
                    }

                    if (word.IndexOf('!') > 0)
                    {
                        word = word.Trim('!');
                    }

                    if (word.IndexOf('?') > 0)
                    {
                        word = word.Trim('?');
                    }

                    if (word.IndexOf(':') > 0)
                    {
                        word = word.Trim(':');
                    }

                    res = res + " " + word;
                }
            }
            return res.Trim();
        }
    }
}
