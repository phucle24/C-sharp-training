using System;

namespace ShapeAbstractClass
{
    public class Circle : Shape
    {
        private double _radius;
        const double pi = 3.14;

        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double Area
        {
            get
            {
                return Math.Pow(_radius, 2) * pi;
            }
        }

        public override double Perimeter
        {
            get
            {
                return _radius * 2 * pi;
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Hinh tron : ");
        }
    }
}
