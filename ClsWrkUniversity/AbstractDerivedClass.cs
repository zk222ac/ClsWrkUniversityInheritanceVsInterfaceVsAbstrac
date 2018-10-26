using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkUniversity
{
    class AbstractDerivedClass : President
    {
        public override void Method()
        {
            Console.WriteLine("actual implementation");
        }

        public override void MethodC()
        {
            Console.WriteLine("New implementation");
        }
    }
}
