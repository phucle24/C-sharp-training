using System;
using System.Collections.Generic;
using System.Text;

namespace Information
{
    public class Cat : Animal
    {
        public Cat(string name)
        {
            _name = name;
        }
        public Cat()
        {

        }
        public override void Speak()
        {
            Console.WriteLine("Con Meo thi keu meo...meo ^-^ ");
        }
        public void ShowInforAnimal()
        {
            Console.WriteLine("Con Meo ten la: {0}.", _name);
        }
    }
}
