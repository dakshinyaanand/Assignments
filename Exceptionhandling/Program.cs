using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            AcceptName an = new AcceptName();
            try
            {
                an.InputName();
            }
            catch(UpperNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                int a, b, c;
                a = 100;
                b = 0;
                c = 0;
                c = a / b;
                Console.WriteLine("div" + c);
                int[] arr = new int[3];
               arr[7] = 49;
               File.Open("c:\\test.txt",FileMode.Open);
            }
            
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine(i.Message);

            }
            catch(FileNotFoundException f)
            {
                Console.WriteLine(f.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block...........");
                GC.Collect();
            }
          

        }
    }
}
