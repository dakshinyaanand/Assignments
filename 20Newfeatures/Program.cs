using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Newfeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.ShowData();
            Employee e2 = new Employee(123, "Martin", "CDCI", 120000);
            e2.ShowData();
            for (int i = 0; i < 10; i +=1)
            {
                Counter.CountData();
            }
            int num1 = 100;
            int num2 = 200;
            string str1 = "hello";
            string str2 = "world";
            Console.WriteLine("before swap.......    " + num1 +"   "+num2);
            Console.WriteLine("before swap.......    " + str1 + "   " + str2);
            SwapExample<int> intobj = new SwapExample<int>();
            intobj.swap(ref num1,ref num2);
            SwapExample<string> obj = new SwapExample<string>();
            obj.swap(ref str1,ref str2);
            Console.WriteLine("after swap........    " + num1 + "   " + num2);
            Console.WriteLine("after swap........    " + str1 + "   " + str2);

            int? age = 32;
            double? pi = null;
            if (age.HasValue)
            {
                Console.WriteLine(age.Value);
            }
            else
                Console.WriteLine("Age:NULL");
            if (pi.HasValue)
                Console.WriteLine(pi.Value);
            else
                Console.WriteLine("Pi:NULL");

        }
    }
}
