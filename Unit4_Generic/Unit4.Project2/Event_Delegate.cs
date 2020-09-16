using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project2
{
    public delegate void UpdateNameHandler(string name);
    public class Event_Delegate
    {
        public static void Run()
        {
            Student student = new Student();
            student.NameChanged += Student_NameChanged;
            student.Name = "Phuc";
            Console.WriteLine("Ten ban dau:{0} ", student.Name);
        }
        /// <summary>
        /// Extension method
        /// </summary>
        /// <param name="name"></param>
        private static void Student_NameChanged(string name)
        {
            Console.WriteLine("Nhap ten moi cua ban: ");
            string newName = Console.ReadLine();
            Console.WriteLine("Ten sau khi cap nhat : {0}", newName);
        }
    }
    public class Student
    {
        public event UpdateNameHandler NameChanged;
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                if (NameChanged != null) { NameChanged(Name); }
            }
        }

    }
}
