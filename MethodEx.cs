using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_method
{
    class MethodEx
    {
        static int add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)

        {
            int result = add(10,20);
            Console.WriteLine("result = " + result);
            result = add(100,200);
            Console.WriteLine("result = " + result);
        }
    }
}
