using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConceptProblem
{
    public class Shapes
    {
        public void ShapeMethod()
        {
            Console.WriteLine("There are so many shapes");
        }
    }
    public class Square:Shapes
    {
        //Single Inheritance
        public void ShapeMethodOne()
        {
            Console.WriteLine("This is square");
        }
    }
    public class Triangle : Square
    {
        //Multilevel Inheritance
        public void ShapeMethodTwo()
        {
            Console.WriteLine("This is triangle");
        }
    }
    public class Pentagon:Shapes
    {
        //Hierarchical Inheritance
        public void ShapeMethod()
        {
            Console.WriteLine("This is pentagon");
        }
    }
    //Multiple Inheritance
    interface IAnimal
    {
        void Eat();
    }

    interface IRobot
    {
        void Work();
    }

    public class Gadget : IAnimal, IRobot
    {
        public void Eat() 
        { 
            Console.WriteLine("Animal is Eating"); 
        }
        public void Work() 
        { 
            Console.WriteLine("Robot is Working"); 
        }
    }
}
