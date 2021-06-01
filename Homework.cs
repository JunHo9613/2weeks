using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210524
{
    class Homework
    {

        static void Main(string[] args)
        {
            Console.WriteLine("2. 구구단을 출력하세요\n");

            for (int i = 1; i < 10; i++)
            {
                for (int n = 2; n < 10; n++)
                {
                    Console.Write(n + "*" + i + "=" + i * n + "\t");
                }
                Console.WriteLine();                
            }
            Console.ReadLine();
            Console.Clear();
            /*
            string[] arr = { "abc", "ABCDEEE", "cn", "bbc", "AABB" };

            Array.Sort(arr, (a, b) =>
            {
                if (a.Length < b.Length)
                    return -1;
                else if (a.Length > b.Length)
                    return 1;
                else //a.Length == b.Length
                    return String.Compare(a, b);
                
            });
            Console.WriteLine("{0} ,{1} ,{2} ,{3} ,{4}",arr); */
            //String.Compare(a, b)는 알파벳 순으로 a가 빠를 때 -1, a가 느릴 때 1 반환
            //결과 arr : { "abc", "bbc", "cnn", "AAANews", "foxnews"}
            
            
            /*
            Console.WriteLine("5. Array.Sort를 사용해서 오름차순 정렬하세요\n");

            int[] arr = new int[] { 2, 10, 5, 8, 4, 11 };
            Console.Write("주어진 값 : ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

            Array.Sort(arr);
            Console.Write("\n\n오름차순 : ");

            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\n\n6. 정렬을 하고 내림차순으로 출력하세요");

            Array.Sort(arr);
            Array.Reverse(arr);
            Console.Write("\n내림차순 : ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            */



        }
    }
}

