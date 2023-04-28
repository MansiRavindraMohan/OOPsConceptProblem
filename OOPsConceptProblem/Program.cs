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
            //Encapsulation Example
            Student student = new Student();
            student.Name = "Mansi Mohan";
            Console.WriteLine("Name of Student: " + student.Name);
            student.Age = 23;
            Console.WriteLine("Age of Student: " + student.Age);
            //Abstraction Example
            Pig pig = new Pig();
            pig.SoundAnimal();
            pig.Sleep();
            //Variables and data types
            Variables variables= new Variables();
            variables.MethodVariable();
            //Method Types
            //1)Non-parameterised method
            MethodsType methodsType= new MethodsType();
            methodsType.NonParameterMethod();
            //2)Parameterised method
            methodsType.ParameterMethod(23, "Mansi");
            Console.ReadKey();
        }
    }
}
