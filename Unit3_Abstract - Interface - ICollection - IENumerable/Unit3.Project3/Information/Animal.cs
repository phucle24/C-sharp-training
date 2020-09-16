using System;
using System.Collections.Generic;
using System.Text;

namespace Information
{
    public abstract class Animal : IAction
    {
        protected string _name;

        public abstract void Speak();
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
