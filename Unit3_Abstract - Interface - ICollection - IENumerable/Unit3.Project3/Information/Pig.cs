using System;

namespace Information
{
    public class Pig : Animal
    {
        private double _weight;
        public Pig(string name, double weight)
        {
            _name = name;
            _weight = weight;
        }
        public Pig()
        {

        }
        public override void Speak()
        {
            Console.WriteLine("Con Heo thi keu ec...ec ^-^ ");
        }
        public void ShowInforAnimal()
        {
            Console.WriteLine("Con Heo ten la: {0} thi nang {1}kg.", _name, _weight);
        }
    }
}
