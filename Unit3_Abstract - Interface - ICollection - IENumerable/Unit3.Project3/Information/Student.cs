using System;
using System.Collections.Generic;
using System.Text;

namespace Information
{
    public class Student : Person
    {
        private int _grade;

        public Student(int grade, int age)
        {
            _grade = grade;
            _age = age;
        }
        public Student()
        {

        }
        public void ShowPerson()
        {
            Console.WriteLine("Hoc sinh khoi {0} thi {1} tuoi.", _grade, _age);
        }
        public override void Work()
        {
            Console.WriteLine("Hoc sinh dang thuc hanh dong.");
        }
        public override void Run()
        {
            Console.WriteLine("Hoc sinh dang chay.");
        }
    }
}
