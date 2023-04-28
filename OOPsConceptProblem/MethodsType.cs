using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConceptProblem
{
    public class MethodsType
    {
        public void NonParameterMethod()
        {
            Console.WriteLine("This is Non-parameterised method");
        }
        public void ParameterMethod(int rollNo,string name)
        {
            Console.WriteLine("This is Parameterised method");
            Console.WriteLine(rollNo);
            Console.WriteLine(name);
        }
    }
}
