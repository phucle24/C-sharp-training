using System;

namespace ShapeAbstractClass
{
    public abstract class Shape
    {
        private double _area, _strokeThickness, _perimeter;
        public abstract double Area
        {
            get;

        }
        public abstract double Perimeter
        {
            get;

        }

        public abstract void Draw();
    }
}
