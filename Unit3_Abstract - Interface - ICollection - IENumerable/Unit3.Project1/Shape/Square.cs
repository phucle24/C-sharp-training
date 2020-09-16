using System;

namespace ShapeAbstractClass
{
    public class Square : Shape
    {
        private double _size;
        public Square(double size)
        {
            _size = size;
        }
        public override double Area
        {
            get
            {
                return _size * _size;
            }
        }
        public override double Perimeter
        {
            get
            {
                return _size * 4;
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Hinh vuong :");
        }
    }
}
