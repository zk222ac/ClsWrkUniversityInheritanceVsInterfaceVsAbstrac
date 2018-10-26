using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkUniversity
{
    // Employee is a Base Class
    // Teacher is a Derived Class
    class Teacher : IBoss , IEmployee
    {
        public void Boss()
        {
            Console.WriteLine("Real implementation of this method Boss");
        }

        public void WorkHours()
        {
            Console.WriteLine("Real implementation of this method workHour");
        }
    }
}
