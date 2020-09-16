using System;
using System.Collections.Generic;
using System.Text;

namespace Information
{
    public abstract class Vehicle : IAction
    {
        protected string _color;
        protected double _price;
        public abstract void Run();
    }
}
