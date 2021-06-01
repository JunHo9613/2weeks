using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_Random
{
    class RandomEx
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for(int i = 0; i<100; i++)
            {
                Console.CursorLeft = rand.Next(80); // 0 ~ 79
                Console.CursorTop = rand.Next(24); // 0 ~ 23
                Console.Write("*");
            }    
        }
    }
}
