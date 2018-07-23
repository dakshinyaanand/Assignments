using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonInfo p1 = new PersonInfo();
            p1.GetData();
            p1.ShowData();
            PersonInfo p2 = new PersonInfo();
            p2.ShowData();
            PersonInfo p3 = new PersonInfo("Blake", 30, "blake@email.com");
            p3.ShowData();

            Shapes s = new Rectangle();
            s.DisplayArea();
            s.DispalyShapes();
            Bird b = new Bird();
            b.fly();
            Kite k = new Kite();
            k.fly();
            Plane p = new Plane();
            p.fly();
            p.PrintTicket();


        }
    }
}
