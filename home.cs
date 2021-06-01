using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210524
{
    class home
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1. 8 x 9 이차원 배열을 선언하세요\n");

            int[] numArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numArr.Length; i++)
            {
                for (int j = 0; j < numArr.Length; j++)
                {
                    Console.Write("{0}{1} ", i, j);
                }
            Console.WriteLine();
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("2. 8 x 9 이차원 배열에 구구단의 결과값을 대입하세요\n");

            int[] numArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numArr1.Length; i++)
            {
                for (int j = 0; j < numArr1.Length; j++)
                {
                    Console.Write("{0} ", (i+1)*(j+1));
                    
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
            Console.Clear(); 

            /*Console.WriteLine("3. 2번에 대입한 값을 출력하세요");
            int a, b;
             int[,] ar = new int[9, 9];
            for (a = 1; a < ar.Length; a++)
                for (b = 0; b < ar.Length; b++)
                    ar[a, b] = (a) * (b + 1);

            for (a = 1; a < ar.Length; a++)
            {
                Console.WriteLine();

                for (b = 0; b < 9; b++)
                    Console.WriteLine("{0} * {1} = {2}", a, b + 1, ar[a, b]);
            }

                    for (int i = 0; i < numArr.Length; i++)
                Console.Write(numArr[i] + " ");
            Console.WriteLine();

            Console.WriteLine("");            */

        }
    }
}