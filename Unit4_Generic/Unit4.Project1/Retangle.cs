using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project1
{
    public class Retangle<T> : Shape
    {
        private double _height, _width;
        public override double Area
        {
            get
            {
                return (_height+_width)*2;
            }
        }
        public override double Perimeter
        {
            get
            {
                return _height*_width;
            }
        }
        public void Add(double height, double width)
        {
            _height = height;
            _width = width;
        }
        public override void Calculate()
        {
            Console.WriteLine("Chu vi : {0}", Area);
            Console.WriteLine("Dien tich: {0}", Perimeter);
        }
        public override void Draw()
        {
            Console.WriteLine("Hinh chu nhat");
        }
    }
}
