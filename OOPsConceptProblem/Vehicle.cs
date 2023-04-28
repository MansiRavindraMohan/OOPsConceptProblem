using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConceptProblem
{
    public class Vehicle
    {
        public int speed;
        public void Start()
        {
            Console.WriteLine("The vehicle is starting.");
        }
        public void Stop()
        {
            Console.WriteLine("The vehicle is stopping.");
        }
    }
    public class Car : Vehicle
    {
        public string carName;
        public int year;

        public void Drive()
        {
            Console.WriteLine("My car name is: " + carName + " It was started in year: " + year);
        }
    }
}
