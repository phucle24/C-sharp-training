using System;
using ShapeAbstractClass;
namespace Unit3.Project1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Square(3),
                new Circle(2),
                new Rectangle( 2, 4)
            };
            Console.WriteLine("--------------------------");
            foreach (Shape s in shapes)
            {
                s.Draw();
                Console.WriteLine("Dien tich = {0}", s.Area);
                Console.WriteLine("Chu vi = {0}", s.Perimeter);
                Console.WriteLine("------------------------");
            }

            Point endPoint = new Point(2, 1);
            Point startPoint = new Point(1, 2);

            Brush[] brushs =
            {
                new GradientBrush("red", 0.25, 0.5, 0.5),
                new LinearGradienBrush(startPoint,endPoint),
                new RadialGradienBrush( 0.5, 0.5, 0.5, 0.5),
                new SolidColorBrush(0.5, 0.5, "red"),
            };
            foreach (Brush brush in brushs)
            {
                brush.Style();
                Console.WriteLine("------------------------");
            }
        }
    }
}
