using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Newfeatures
{
    class SwapExample<T>
    {
        public void swap(ref T a,ref T b)
        {
            //ref is used for call by reference 
            T temp = a;
            a = b;
            b = temp;
            //ref keyword is used in place of * and & in call by ref in c#
           

        }
    }
}
