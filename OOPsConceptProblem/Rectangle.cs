using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConceptProblem
{
    public class Rectangle
    {
        public void PrintArea(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void PrintArea(int x)
        {
            Console.WriteLine(x * x);
        }
        public void PrintArea(int x, double y)
        {
            Console.WriteLine(x * y);
        }
        public void PrintArea(double x)
        {
            Console.WriteLine(x * x);
        }
    }
}
