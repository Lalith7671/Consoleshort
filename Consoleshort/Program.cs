using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleshort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short a = 3276;
            Console.WriteLine("value of a is {0}", a);
            Console.WriteLine("short minimum value is {0}", short.MinValue);
            Console.WriteLine("short maximum value is {0}", short.MaxValue);
            Console.WriteLine("unsigned short minimum value is {0}", ushort.MinValue);
            Console.WriteLine("unsigned short minimum value is {0}", ushort.MaxValue);
            Console.WriteLine("size of short is {0}bytes", sizeof(short));
            Console.WriteLine("base type of short is {0}", a.GetType());
            //b=5000000
            //cccccccc


        }
    }
}
