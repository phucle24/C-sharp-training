
using System;

namespace Unit4.Project1
{
    public abstract class Shape
    {
        public abstract double Area
        {
            get;
        }
        public abstract double Perimeter
        {
            get;
        }
        public abstract void Calculate();
        public abstract void Draw();
    }
}
