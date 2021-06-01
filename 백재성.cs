using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_24_HomeWork_
{
    class 백재성
    {
        static void Main(string[] args)
        {
            // 1. 8 x 9 이차원 배열을 선언하세요
            /*int[,] array = new int[8, 9];*/

            // 2. 8 x 9 이차원 배열에 구구단의 결과값을 대입하세요

            /*int[,] array = new int[8, 9] { { 2, 4, 6, 8, 10, 12, 14, 16, 18 }, { 3, 6, 9, 12, 15, 18, 21, 24, 27 }, 
                                           { 4, 8, 12, 16, 20, 24, 28, 32, 36 },{ 5, 10, 15, 20, 25, 30, 35, 40, 45 }, 
                                           { 6, 12, 18, 24, 30, 36, 42, 48, 54 }, { 7, 14, 21, 28, 35, 42, 49, 56, 63 }
                                          , { 8, 16, 24, 32, 40, 48, 56, 64, 72 }, { 9, 18, 27, 36, 45, 54, 63, 72, 81 }};*/

            // 3. 2번에 대입한 값을 출력하세요

            /*int[,] array = new int[8, 9] { { 2, 4, 6, 8, 10, 12, 14, 16, 18 }, { 3, 6, 9, 12, 15, 18, 21, 24, 27 },
                                           { 4, 8, 12, 16, 20, 24, 28, 32, 36 },{ 5, 10, 15, 20, 25, 30, 35, 40, 45 },
                                           { 6, 12, 18, 24, 30, 36, 42, 48, 54 }, { 7, 14, 21, 28, 35, 42, 49, 56, 63 }
                                          , { 8, 16, 24, 32, 40, 48, 56, 64, 72 }, { 9, 18, 27, 36, 45, 54, 63, 72, 81 }};

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine();
                    Console.Write($"[{i}, {j}] : {array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();*/
        }
    }
}
