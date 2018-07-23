using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Newfeatures
{
    static class Counter
    {
        static int count;
        static Counter()
        {
            count = 11;
        }
        public static void CountData()
        {
            //s.m can have local non static var
            int ctr = 0;
            ctr++;
            count++;
            Console.WriteLine("ctr :" + ctr);
            Console.WriteLine("count :" + count);
        }

    }
}
