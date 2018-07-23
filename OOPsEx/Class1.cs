using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    class Bird : IFlying
    {
        public void fly()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Flap,Flap,Flap....");
        }
    }
    class Kite : IFlying
    {
        public void fly()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Files colourfully with tail and thread");
        }
    }
    class Plane : IFlying, IPassengerInfo
    {
        public void fly()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Up Up in sky");
           
        }

        public void PrintTicket()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Passenger Name : Deepa");
            Console.WriteLine("Source : Coimbatore");
            Console.WriteLine("Designation : Bengaluru");
            Console.WriteLine("DOJ: 07/20/2018");
            Console.WriteLine("Seat no: EA");
        }
    }
}
