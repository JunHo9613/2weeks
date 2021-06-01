using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* [단축키]
1. 1줄 주석 : ctrl + K,c 
2. 1줄 주석 해제 : ctrl k u
3. 여러 줄 주석/해제 : ctrl shift + /
4. 코드 정렬 : ctrl k f
*/
namespace _2021_05_20_solve
{
    class Question1
    {
        static void ClearConsole()
        {
            Console.ReadLine();
            Console.Clear();
        }
        // 1. while문을 이용해서 100부터 200까지 출력하세요
        static void Main(string[] args)
        {
            int i = 100;
            while (i <= 200)
            {
                Console.Write(i + "");
                i++;
            }
            // 2. while문을 이용해서 10부터 20까지 5씩 증가하여 출력하세요
            ClearConsole();

            i = 10;
            while (i <= 20)
            {
                Console.Write(i + "");
                i += 5;
            }
            // 3. while문을 이용해서 1부터 10까지 합을 출력하세요
            ClearConsole();

            int result = 0;
            i = 1;
            while (i <= 10)
            {
                result += i;
                i++;
            }
            Console.WriteLine("result = " + result);
            // 4. while문을 이용해서 1부터 10까지 중에 짝수만 출력하세요
            // while문내에 조건문을 넣어주면 됨 
            // 짝수 조건 if(num % 2 == 0)
            ClearConsole();

            i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
                i++;
            }

            // 5. while문을 이용해서 10부터 0까지 2씩 감소하여 출력하세요
            ClearConsole();

            i = 10;
            while (i >= 0)
            {
                Console.Write(i + "");
                i -= 2;
            }
        }
    }
}
