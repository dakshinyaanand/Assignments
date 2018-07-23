using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    class Rectangle :Shapes
    {
        int len;
        int brd;
        public override void DispalyShapes()
        {
            base.DispalyShapes();
            Console.WriteLine("Rectangle class");
        }
        public override void DisplayArea()
        {
            // throw new NotImplementedException();
            len = 200;
            brd = 50;
            area=len* brd;
            Console.WriteLine("Area of the rectangle:" + area);

        }


    }
}
