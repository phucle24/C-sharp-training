using System;
namespace Information
{
    public class Employee : Person
    {
        private double _salary;

        public Employee(int age, double salary)
        {
            _age = age;
            _salary = salary;
        }
        public Employee()
        {

        }
        public void ShowPerson()
        {
            Console.WriteLine("Anh nhan vien {0} tuoi luong {1}$.", _age, _salary);
        }
        public override void Run()
        {
        }

        public override void Work()
        {
            Console.WriteLine("Nhan vien dang lam viec.");
        }
    }
}
