using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMathOperations
{
    public class MathClass
    {
        // These are methods of the class, and the class is a model to look at. This doesn't create any objects.
        // These are for when I create an object, to know what it will have.
        public static int addNumbers(int num)
        {
            num = num + 10;
            return num;
        }
        
        public int subtractNumbers(int num)
        {
            num = num - 10;
            return num;
        }

        public int multiplyNumbers(int num)
        {
            num = num * 10;
            return num;
        }

    }
}
