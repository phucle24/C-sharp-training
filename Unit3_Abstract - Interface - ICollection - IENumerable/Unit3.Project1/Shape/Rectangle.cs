using System;

namespace ShapeAbstractClass
{
    public class Rectangle : Shape
    {
        private double _height, _width;
        public override double Area
        {
            get
            {
                return _height * _width;
            }
        }

        public override double Perimeter
        {
            get
            {
                return (_height + _width) * 2;
            }
        }
        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }
        public override void Draw()
        {
            Console.WriteLine("Hinh chu nhat :");
        }
    }
}
