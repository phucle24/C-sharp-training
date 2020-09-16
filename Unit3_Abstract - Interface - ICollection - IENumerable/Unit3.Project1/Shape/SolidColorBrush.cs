using System;

namespace ShapeAbstractClass
{
    public class SolidColorBrush : Brush
    {
        private string _color;
        public SolidColorBrush(double transform, double opacity, string color)
        {
            _transform = transform;
            _opacity = opacity;
            _color = color;
        }
        public override void Style()
        {
            Console.WriteLine("##### Kieu Co ve dong nhat #####");
            Console.WriteLine("Thay doi vi tri: {0}", _transform);
            Console.WriteLine("Do mo cua mau: {0}", _opacity);
            Console.WriteLine("Mau sac co ve: {0}", _color);
        }
    }
}
