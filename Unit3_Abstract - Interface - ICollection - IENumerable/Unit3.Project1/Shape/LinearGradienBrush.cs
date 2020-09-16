using System;

namespace ShapeAbstractClass
{
    public class LinearGradienBrush : GradientBrush
    {
        private Point _endPoint, _startPoint;
        public LinearGradienBrush(Point endPoint, Point startPoint)
        {
            _endPoint = endPoint;
            _startPoint = startPoint;
        }

        public override void Style()
        {
            Console.WriteLine("##### Kieu co ve mau chuyen sac tinh #####");
            Console.WriteLine("Diem bat dau to mau: {0}", _startPoint);
            Console.WriteLine("Diem ket thuc to mau: {0}", _endPoint);
        }
    }
}
