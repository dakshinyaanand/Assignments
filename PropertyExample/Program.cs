using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name and age");
            string n = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            PersonInfoCLR p1 = new PersonInfoCLR();
            p1.Name = n;
            p1.Age = a;
            Console.WriteLine("NAME :" + p1.Name + "\n AGE :" + p1.Age);
            PersonInfoCLR p2 = new PersonInfoCLR { Name="scott",Age=32};
            Console.WriteLine("NAME :" + p2.Name + "\n AGE :" + p2.Age);
            PersonInfoAuto p3 = new PersonInfoAuto();
            p3.Name = n;
            p3.Age = a;
            Console.WriteLine("NAME :" + p3.Name + "\n AGE :" + p3.Age);
            PersonInfoAuto p4 = new PersonInfoAuto { Name = "scott", Age = 32 };
            Console.WriteLine("NAME :" + p4.Name + "\n AGE :" + p4.Age);
        }
    }
}
