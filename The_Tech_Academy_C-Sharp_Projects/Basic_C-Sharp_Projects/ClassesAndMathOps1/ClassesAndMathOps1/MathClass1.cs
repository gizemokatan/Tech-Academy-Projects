using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMathOps1
{
    class MathClass1
    {
        public int addNumber(int num)
        {
            num = num + 25;
            return num;
        }

        public int addNumber(decimal num)
        {
            num = num + 50.5m;
            int decimalNum = Convert.ToInt32(num); 
            return decimalNum;
        }

        public int addNumber(string num) 
        {
            return Convert.ToInt32(num) + 5;
        }
    }
}
