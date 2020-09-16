using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project1
{
    public class RadialGradienBrush<T> : GradientBrush<T>
    {
        private double _center, _gradientOrigin, _radiusX, _radiusY;
        public void radialGradienBrush(double center, double gradientOrigin, double radiusX, double radiusY)
        {
            _center = center;
            _gradientOrigin = gradientOrigin;
            _radiusX = radiusX;
            _radiusY = radiusY;
        }

        public override void Style()
        {
            Console.WriteLine("##### Kieu co ve mau sac toa tron #####");
            Console.WriteLine("Dat tam o ngoai cung tai: {0} ", _center);
            Console.WriteLine("Tieu diem bat dau Gradient: {0} ", _gradientOrigin);
            Console.WriteLine("Ban kinh ngang {0}: ", _radiusX);
            Console.WriteLine("Ban Kinh doc {0}: ", _radiusY);

        }
    }
}
