using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project1
{
    public class Cirle<T> : Shape
    {
        private double _radius;
        const double PI = 3.14;
        public void Add(double radius)
        {
            _radius = radius;
        }
        public override double Area
        {
            get
            {
                return Math.Pow(_radius, 2) * PI;
            }
        }


        public override double Perimeter
        {
            get
            {
                return _radius * 2 * PI;
            }
        }
        public override void Calculate()
        {
            Console.WriteLine("Chu vi : {0}", Area);
            Console.WriteLine("Dien tich: {0}", Perimeter);
        }
        public override void Draw()
        {
            Console.WriteLine("Hinh tron");
        }
    }
}
