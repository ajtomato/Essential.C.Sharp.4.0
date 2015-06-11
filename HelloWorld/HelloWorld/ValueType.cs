using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    // A good guideline is for value types to be immutable.
    struct ValueType
    {
#if COMPILE_ERROR
        public ValueType()
        {
            // Explicit parameterless constructor is NOT allowed.
        }
        int field = 0; // cannot have instance field initializers in struct.
#endif

        private int field1;
        private int field2;

        public ValueType(int field1)
        {
            this.field1 = field1;
            this.field2 = default(int); // All fields should be initialized.
        }
    }
#if COMPILE_ERROR
    struct ValueType2: ValueType
    {
        // Struct can NOT be derived. But it can implements an interface.
    }
#endif
}
