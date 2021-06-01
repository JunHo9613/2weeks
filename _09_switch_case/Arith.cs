using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_switch_case
{
    class Arith
    {
        static void Main(string[] args)
        {
            int num0 = 0, num1 = 0, result = 0;
            string op;

            Console.WriteLine("사칙연산을 합니다.");
            Console.Write("첫번째 숫자 입력: ");
            string strNum0 = Console.ReadLine();
            num0 = Int32.Parse(strNum0);

            Console.Write("두번째 숫자 입력: ");
            string strNum1 = Console.ReadLine();
            num1 = Int32.Parse(strNum1);

            Console.Write("+ - / * % 연산자 입력 : ");
            op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    result = num0 + num1;
                    break;
                case "-":
                    result = num0 - num1;
                    break;
                case "*":
                    result = num0 * num1;
                    break;
                case "/":
                    result = num0 / num1;
                    break;
                case "%":
                    result = num0 % num1;
                    break;
                default:  //else에 해당
                    Console.WriteLine("알맞은 연산자가 아닙니다.");
                    break;
            }
            Console.WriteLine("결과값은 " + result + " 입니다.");
        }
    }
}
