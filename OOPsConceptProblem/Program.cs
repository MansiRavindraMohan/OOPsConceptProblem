namespace OOPsConceptProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Object of class ObjectClass
            ObjectClass objectClass = new ObjectClass();
            objectClass.ObjectClassMethod();
            //Inheritance Example
            Car car = new Car();
            car.Start();
            car.Stop();
            Console.WriteLine(car.carName = "XUV");
            Console.WriteLine(car.year = 2022);
            car.Drive();
            Console.ReadKey();
        }
    }
}
