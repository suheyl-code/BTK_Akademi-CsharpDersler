using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Add(1.0,2.0,3.0,4.0,5.0));
          
        }

        static void Add()
        {
            Console.WriteLine("Add!");
        }

        static double Add(out double a, ref double b)
        {
            a = b;
            return a + b;
        }

        static double Add(params double[] nums)
        {
            return nums.Sum();
        }
    }
}
