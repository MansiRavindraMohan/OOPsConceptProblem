using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConceptProblem
{
    public class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("This is parent class called Animal");
        }
    }
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dogs bark");
        }
    }
}