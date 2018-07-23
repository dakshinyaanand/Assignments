using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Newfeatures
{
    partial class Employee
    {
        public Employee()
        {
            id = 777;
            name = "James";
            dept = "CID";
            salary = 100000;

        }
        public Employee (int id,string name,string dept,double salary)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
            this.salary = salary;
        }

    }
}
