using System;
using System.Collections.Generic;
using System.Text;

namespace Information
{
    public class Motobike : Vehicle
    {
        private string _fashion;
        private double _speed;
        public Motobike(string color, double price, double speed, string fashion)
        {
            _color = color;
            _price = price;
            _speed = speed;
            _fashion = fashion;
        }
        public Motobike()
        {

        }
        public void  ShowVehicle()
        {
            Console.WriteLine("Xe Moto mau {0} co gia {1}$, toc do {2} km/h thi nhin {3}.", _color, _price,_speed, _fashion);
        }
        public override void Run()
        {
            Console.WriteLine("Mo to dang chay tren duong.");
        }
    }
}
