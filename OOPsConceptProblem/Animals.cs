using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConceptProblem
{
    public abstract class Animals
    {
        public abstract void SoundAnimal();
        public void Sleep()
        {
            Console.WriteLine("The animals are sleeping");
        }
    }
    public class Pig : Animals
    {
        public override void SoundAnimal()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
