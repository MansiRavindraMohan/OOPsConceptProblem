using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConceptProblem
{
    public class ValueType
    {
        public void Methodvalue()
        {
            // Value types
            int x = 5;
            int y = x;
            y = 10;
            Console.WriteLine(x);
            Console.WriteLine(y);

            // Reference types
            int[] arrOne = new int[] { 1, 2, 3 };
            int[] arrTwo = arrOne;
            arrTwo[0] = 5;
            Console.WriteLine(arrOne[0]);
            Console.WriteLine(arrTwo[0]);

            //TypeCasting
            int valueOne = 10;
            double valueTwo = valueOne;
            int valueThree = 20;
            Console.WriteLine(valueOne);
            Console.WriteLine(valueTwo);
            Console.WriteLine(valueThree);
            double valueFour = 10.5;
            int valueFive = (int)valueFour;
            Console.WriteLine(valueFive);
        }
    }
}
