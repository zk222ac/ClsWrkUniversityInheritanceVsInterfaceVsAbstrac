using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkUniversity
{
    abstract class President
    {
        // abstract method - no real implementation
      public abstract void Method();

        // Concrete method - with implementation
        public void MethodA()
        {
            Console.WriteLine("Method A implementation inside abstract method");
        }

        public virtual void MethodC()
        {
            Console.WriteLine("MethodC");
        }

        public void MethodD()
        {
            Console.WriteLine("Simple Method");
        }
    }
}
