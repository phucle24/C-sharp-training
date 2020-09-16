using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project1
{
    public class LinearGradienBrush<T> : GradientBrush<T>
    {
        private double _startPoint, _endPoint;
        public void linearGradienBrush(double endPoint, double startPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public override void Style()
        {
            Console.WriteLine("##### Kieu co ve mau chuyen sac tinh #####");
            Console.WriteLine("Diem bat dau to mau: {0}", _startPoint);
            Console.WriteLine("Diem ket thuc to mau: {0}", _endPoint);
        }
    }
}
