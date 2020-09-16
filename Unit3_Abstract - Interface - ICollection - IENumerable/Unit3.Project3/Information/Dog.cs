using System;
using System.Collections.Generic;
using System.Text;

namespace Information
{
    public class Dog : Animal
    {
        public Dog(string name)
        {
            _name = name;
        }
        public Dog()
        {

        }
        public override void Speak()
        {
            Console.WriteLine("Con Cho thi sua gau....gau ^-^ ");
        }
        public void ShowInforAnimal()
        {
            Console.WriteLine("Con Cho ten la: {0}.", _name);
        }
    }
}
