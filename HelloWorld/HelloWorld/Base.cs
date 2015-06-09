using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Base: Abstract
    {
        public Base()
        {
            System.Console.WriteLine("Base Construtor");
        }

        public override void Interface1()
        {
            System.Console.WriteLine("Base::Interface1");
        }

        public virtual void Hello()
        {
            System.Console.WriteLine("Hello, Base");
        }

        public virtual int Property
        {
            get;
            set;
        }

        public virtual void Function1()
        {
            System.Console.WriteLine("Base::Function1");
        }

        public virtual void Function2()
        {
            System.Console.WriteLine("Base::Function2");
        }
    }
}
