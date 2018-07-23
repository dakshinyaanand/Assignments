using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            char gender;
            double salary;
            bool cab;
            DateTime doj;
            //parse function is used to convert string to different datatype
            Console.WriteLine("enter Id");
            //id = int.Parse(Console.ReadLine());
            bool result = int.TryParse(Console.ReadLine(), out id);
            if (result == false)
            {
                Console.WriteLine("Id has to be integer");
                return;
            }
            Console.WriteLine("enter Name");
            name = Console.ReadLine();
            
            Console.WriteLine("enter Gender");
            bool result1 = char.TryParse(Console.ReadLine(), out gender);
            if (result1 == false)
            {
                Console.WriteLine("Gender has to be char");
                return;
            }
            //gender = char.Parse(Console.ReadLine());
            Console.WriteLine("enter Salary");
            // salary = double.Parse(Console.ReadLine());
            bool result2 = double.TryParse(Console.ReadLine(), out salary);
            if (result2 == false)
            {
                Console.WriteLine("Salary has to be Double");
                return;
            }
            Console.WriteLine("enter Cab(true/false)");
            cab = bool.Parse(Console.ReadLine());
                    
            Console.WriteLine("enter Date of joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID:"+id);
            Console.WriteLine("NAME:"+name);
            Console.WriteLine("GENDER:"+gender);
            Console.WriteLine("SALARY:"+salary);
            Console.WriteLine("CAB:"+cab);
            Console.WriteLine("DOJ:"+doj);
        }
    }
}
