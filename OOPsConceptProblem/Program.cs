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
            //Polymorphism Example
            //1)Method Overloading
            Rectangle rectangle = new Rectangle();
            rectangle.PrintArea(3,5);
            rectangle.PrintArea(5);
            rectangle.PrintArea(6,2.5);
            rectangle.PrintArea(5.5);
            //2)Method Overriding
            Dog dog = new Dog();
            dog.Sound();
            Console.ReadKey();
        }
    }
}
