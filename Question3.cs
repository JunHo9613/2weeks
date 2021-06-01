using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_05_20_solve
{
    class Question3
    {
        static void ClearConsole()
        {
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            //1. for문을 이용해서 100부터 200까지 출력하세요\
            for (int i = 100; i <= 200; i++)
                Console.Write(i + " ");

            //2. for문을 이용해서 10부터 20까지 5씩 증가하여 출력하세요
            ClearConsole();
            for (int i = 10; i <= 20; i += 5)
                Console.Write(i + " ");

            //3. for문을 이용해서 1부터 10까지 합을 출력하세요
            ClearConsole();
            int result = 0;
            for (int i = 1; i <= 10; i++)
                result += i;
            Console.WriteLine("result=" + result);

            //4. for문을 이용해서 1부터 10까지 중에 짝수만 출력하세요
            //   for문내에 조건문을 넣어주면 됨
            //   짝수 조건 if(num % 2 == 0)
            ClearConsole();
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            /* for (int i = 2; i <=10; i +=2)
             * Console.Write(i+" ");*/
            //5. for문을 이용해서 10부터 0까지 2씩 감소하여 출력하세요
            ClearConsole();
            for (int i = 10; i >= 0; i -= 2)
                Console.Write(i + " ");
        }
    }
}
