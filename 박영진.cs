using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class _2_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5개의 int배열을 선언하고 난수로 값을 입력하고 출력하세요");
            Random rand = new Random();

            int[] randNum = new int[5];

            for (int i = 0; i < randNum.Length; i++)
            {
                randNum[i] = rand.Next(0,100);

                Console.WriteLine( randNum[i]);
            }
        }

    }
}
