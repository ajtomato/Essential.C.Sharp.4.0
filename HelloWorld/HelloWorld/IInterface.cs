using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    interface IInterface
    {
        // No access modifier is needed. All of them are public.
        void InterfaceFunction1();

        int Property1
        {
            get;
            set;
        }

    }
}
