using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TarasovVD.Sprint3.Task3.V21.Lib
{
    public class DataService : ISprint3Task3V21
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            char[] charArray = value.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsDigit(charArray[i]))
                {
                    charArray[i] = item;
                }
            }

            return new string(charArray);
        }
    }
}
