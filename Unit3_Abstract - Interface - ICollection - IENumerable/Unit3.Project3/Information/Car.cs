using Information;
using System;
using System.Collections.Generic;
using System.Text;

namespace Information
{
    public class Car : Vehicle
    {
        private string _fashion;
        public Car(string color, double price, string fashion)
        {
            _color = color;
            _price = price;
            _fashion = fashion;
        }
        public Car()
        {

        }
        public void ShowVehicle()
        {
            Console.WriteLine("Xe to mau {0} co gia {1}$ thi nhin {2}.", _color, _price, _fashion);
        }
        public override void Run()
        {
            Console.WriteLine("O to dang chay tren duong.");
        }
    }
}
