using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0524homework
{
    class 김상재
    {
        static void Main(string [] args)
        {

            Console.WriteLine("정수를 입력 받습니다 : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("정수를 입력 받습니다 : ");
            int b = int.Parse(Console.ReadLine());
            int result = 0;

            for(int i = a; i <= b; i++) // 작은값을 반복문 시작수로 두고 
                                        // 조건을 큰값과 같아질때까지 작은 값을 1씩 증가하면서 결과값에 넣어준다
            {

                result += i; // result = result + i

            }
            Console.WriteLine(result);
        }
    }
}
