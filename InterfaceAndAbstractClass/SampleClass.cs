using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractClass
{
    class SampleClass : AbstractClass, Interface1, Interface2
    {
        public string MyInterfaceProperty { get; set; }

        public void FooInterface2()
        {
            throw new NotImplementedException();
        }

        protected override void FooClass()
        {
            throw new NotImplementedException();
        }
    }
}
