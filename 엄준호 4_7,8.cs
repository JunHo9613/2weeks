using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_character
{
    class Character
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7. 정수 3개를 입력받고 이 3개의 수로 삼각형을 만들 수 있는지를 판별하세요 (조건 연산자 사용)");
            int num = 0, num1 = 0, num2 = 0;

            Console.Write("첫번째 정수 입력 : ");
            string strNum = Console.ReadLine();
            num = Int32.Parse(strNum);

            Console.Write("두번째 정수 입력 : ");
            string strNum1 = Console.ReadLine();
            num1 = Int32.Parse(strNum1);

            Console.Write("두번째 정수 입력 : ");
            string strNum2 = Console.ReadLine();
            num2 = Int32.Parse(strNum2);

            string result = num + num1 <= num2 ? "삼각형으로 만들 수 없습니다." : "삼각형으로 만들 수 있습니다.";
            string result1 = num1 + num2 <= num ? "삼각형으로 만들 수 없습니다." : "삼각형으로 만들 수 있습니다.";
            string result2 = num + num2 <= num1 ? "삼각형으로 만들 수 없습니다." : "삼각형으로 만들 수 있습니다.";

            Console.Write(result, result1, result2);

            Console.ReadLine();
            Console.Clear();






            Console.WriteLine("8. 정수 3개를 입력받고 이 3개의 수로 삼각형을 만들 수 있는지를 판별하세요 (if문 사용)");
            int num3 = 0, num4 = 0, num5 = 0;

            Console.Write("첫번째 정수 입력 : ");
            string strNum3 = Console.ReadLine();
            num3 = Int32.Parse(strNum3);

            Console.Write("두번째 정수 입력 : ");
            string strNum4 = Console.ReadLine();
            num4 = Int32.Parse(strNum4);

            Console.Write("두번째 정수 입력 : ");
            string strNum5 = Console.ReadLine();
            num5 = Int32.Parse(strNum5);

            if (num3 + num4 <= num5 || num3 + num5 <= num4 || num4 + num5 <= num3)
            {
                Console.WriteLine("삼각형으로 만들 수 없습니다.");
            }
            else Console.WriteLine("삼각형으로 만들 수 있습니다.");
        }
    }
}
