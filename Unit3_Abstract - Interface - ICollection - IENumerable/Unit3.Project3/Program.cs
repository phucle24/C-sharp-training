using Information;
using System;

namespace Unit3.Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Kitty");
            cat.ShowInforAnimal();
            cat.Speak();
            Console.WriteLine("------------------");
            Dog dog = new Dog("Lu Lu");
            dog.ShowInforAnimal();
            dog.Speak();
            Console.WriteLine("------------------");
            Pig pig = new Pig("Pikachu", 100);
            pig.ShowInforAnimal();
            pig.Speak();
            Console.WriteLine("------------------");
            Student student = new Student(12, 17);
            student.ShowPerson();
            student.Work();
            student.Run();
            Console.WriteLine("------------------");
            Employee employee = new Employee(25, 2000);
            employee.ShowPerson();
            employee.Work();
            Console.WriteLine("------------------");
            Motobike motobike = new Motobike("red", 2000,200, "Cool");
            motobike.ShowVehicle();
            motobike.Run();
            Console.WriteLine("------------------");
            Car car = new Car("Blue", 10000, "Dep");
            car.ShowVehicle();
            car.Run();
            Console.WriteLine("------------------");
            Console.WriteLine("------------------");
        }
    }
}
