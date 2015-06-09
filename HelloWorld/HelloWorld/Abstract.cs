using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    abstract class Abstract
    {
        public abstract void Interface1();

        public virtual void Interface2()
        {
            System.Console.WriteLine("Abstract::Interface2");
        }
    }
}
