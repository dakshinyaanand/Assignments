using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Newfeatures
{
    partial class Employee
    {
        public void ShowData()
        {
            Console.WriteLine("ID :" + id);
            Console.WriteLine("NAME :" + name);
            Console.WriteLine("DEPARTMENT :" + dept);
            Console.WriteLine("SALARY :" + salary);
        }

    }
}
