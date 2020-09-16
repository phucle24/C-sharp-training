using System;
namespace Unit4.Project1
{
    public class Square<T> : Shape
    {
        private double _size;

        public void Add(double size)
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
        public override void Calculate()
        {
            Console.WriteLine("Chu vi : {0}", Area);
            Console.WriteLine("Dien tich: {0}", Perimeter);
        }
        public override void Draw()
        {
            Console.WriteLine("Hinh vuong");
        }
    }
}
