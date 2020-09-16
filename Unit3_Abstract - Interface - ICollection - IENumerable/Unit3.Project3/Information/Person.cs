using System;
using System.Collections.Generic;
using System.Text;

namespace Information
{
    public abstract class Person : IAction
    {
        protected int _age;
        public abstract void Work();
        public abstract void Run();
    }
}
