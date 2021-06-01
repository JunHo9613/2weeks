using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_05_20_solve
{
    class Question2
    {
        static void ClearConsole()
        {
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            // 1. do~while문을 이용해서 100부터 200까지 출력하세요
            int i = 100;
            do
            {
                Console.Write(i + " ");
                i++;
            } while (i <= 200);

            // 2. do~while문을 이용해서 10부터 20까지 5씩 증가하여 출력하세요
            ClearConsole();

            i = 10;
            do
            {
                Console.Write(i + "");
                i += 5;
            } while (i <= 20);
            // 3. do~while문을 이용해서 1부터 10까지 합을 출력하세요
            ClearConsole();

            int result = 0;
            i = 1;
            do
            {
                result += i;
                i++;
            } while (i <= 10);
            Console.WriteLine("result = " + result);
            // 4. do~while문을 이용해서 1부터 10까지 중에 짝수만 출력하세요
            //do ~while문내에 조건문을 넣어주면 됨
            //짝수 조건 if (num % 2 == 0)
            ClearConsole();

            i = 1;
            do
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
                i++;
            } while (i <= 10);

            // 5. do~while문을 이용해서 10부터 0까지 2씩 감소하여 출력하세요
            ClearConsole();

            i = 10;
            do
            {
                Console.Write(i + "");
                i -= 2;
            } while (i >= 0);
        }
    }
}
