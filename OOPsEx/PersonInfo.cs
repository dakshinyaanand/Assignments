using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    class PersonInfo
    {
        string name;
        int age;
        string email;
        public void GetData()
        {
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter email");
            email = Console.ReadLine();


        }
        public void ShowData()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("Email :" + email);
        }
        public PersonInfo()
        {
            name = "Default";
            age = 99;
            email = "default@dafault.com";
        }
        public PersonInfo(string name, int age, string email)
        {
            //parameters variables are local variables
            this.name = name;
            this.age = age;
            this.email = email;
        }
        ~PersonInfo()
        {
            GC.Collect();
            Console.WriteLine("object Destroyed");
        }
    }
}
