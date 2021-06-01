using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operator
{
    // 연산자
    // 산술연산자(+ - * / %)
    // 비교연산자(> < == >= <=)
    class Operator
    {
        static void Main(string[] args)
        {
            int num0 = 0, num1 = 0;
            bool bResult; // true & false

            Console.WriteLine("비교 연산을 합니다");
            Console.Write("첫번째 숫자 입력 : ");
            string strNum0 = Console.ReadLine();  // 입력
            num0 = Int32.Parse(strNum0);  // 문자열->숫자

            Console.Write("두번째 숫자 입력 : ");
            string strNum1 = Console.ReadLine();  // 입력
            num1 = Int32.Parse(strNum1);  // 문자열->숫자

            bResult = num0 > num1;
            Console.WriteLine("{0]은 {1}보다 크다는 사실은 {2} 입니다.", num0, num1, bResult);        
        }
    }
}
