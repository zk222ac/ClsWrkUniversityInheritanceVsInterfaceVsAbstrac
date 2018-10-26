
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkUniversity
{
    // Base Class
    class Employee
    {
        public int _id;
        private string _name;
        protected string _salary;

        // Method Overriding concept
        // Virtual keyword in method : this method is going to be inherited
        // Virtual method always use in a Base class 
        public virtual string WorkHour()
        {
             return "Employee working Hours:";
        }
    }
}
