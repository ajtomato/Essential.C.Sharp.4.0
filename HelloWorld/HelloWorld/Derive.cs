using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    // Sealed classes cannot be derived from.
    sealed class Derive: Base
    {
        public Derive(): base()
        {
            System.Console.WriteLine("Derive Constructor");
        }

        public override void Hello()
        {
            System.Console.WriteLine("Hello, Derive");
        }

        public override int Property
        {
            get
            {
                System.Console.WriteLine("Derive::get");
                return 0;
            }
            set
            {
                System.Console.WriteLine("Derive::set");
            }
        }

        public new void Function1()
        {
            base.Function1();
            System.Console.WriteLine("Derive::Function1");
        }

        public override sealed void Function2()
        {
            System.Console.WriteLine("Derive::Function2");
        }
    }
}
