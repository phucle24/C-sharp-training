using System;
namespace Unit4.Project1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Square<double> square = new Square<double>();
            square.Draw();
            square.Add(2);
            square.Calculate();
            Console.WriteLine("------------------------");
            Retangle<double> retangle = new Retangle<double>();
            retangle.Draw();
            retangle.Add(2,4);
            retangle.Calculate();
            Console.WriteLine("------------------------");
            Cirle<double> cirle = new Cirle<double>();
            cirle.Draw();
            cirle.Add(4);
            cirle.Calculate();
            Console.WriteLine("------------------------");
            GradientBrush<object> gradient = new GradientBrush<object>();
            gradient.Brush("Red",2,3,4);
            gradient.Style();
            Console.WriteLine("------------------------");
            LinearGradienBrush<object> linearGradien = new LinearGradienBrush<object>();
            linearGradien.linearGradienBrush(2, 3);
            linearGradien.Style();
            Console.WriteLine("------------------------");
            RadialGradienBrush<object> radialGradien = new RadialGradienBrush<object>();
            radialGradien.radialGradienBrush(2, 3, 4, 3);
            radialGradien.Style();

        }
    }
}
