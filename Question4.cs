using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_05_20_solve
{
    class Question4
    {
        static void ClearConsole()
        {
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(">> Enter 입력");
            Console.ReadLine();
            Console.Clear();

            //문자를 입력받는 2가지 방법.
            /*string strCh = Console.ReadLine();
            char ch = strCh[0];
            Console.WriteLine("ch=" + ch);*/

            /* ConsoleKeyInfo cki = Console.ReadKey();
             char ch = cki.KeyChar;
             Console.WriteLine();
             Console.WriteLine("ch=" + ch);*/

            /*조건 연산자(3항 연산자)
              A 항목의 결과가 참이면 B, 거짓이면 C
              A ? B : C;*/
            /*int num0 = 10, num1 = 5;
            int result = 0;
            string op = "+";

            result = (op=="+") ? (num0+num1) : (num0 - num1);
            Console.WriteLine("result=" + result);*/


            //1. 영문자를 입력받습니다. 소문자인지 대문자인지 판별하세요(조건 연산자를 사용하세요)
            /*string strCh = Console.ReadLine();
            char ch = strCh[0];
            Console.WriteLine("ch=" + ch);*/
            /*ClearConsole();
            string strCh = Console.ReadLine();
            char ch = strCh[0];
            string strResult;

            strResult = (ch >= 'a') ? 
                (ch <= 'z' ? "소문자" :"소문자아님 ")
                : 
                (ch >= 'A' ?
                (ch <= 'Z' ? "대문자" : "대문자아님 ") : "알파벳 아님");*/


            //2. 영문자를 입력받습니다
            //   소문자인지 대문자인지 판별하세요(if문을 사용하세요)
            /*ClearConsole();
            string strCh = Console.ReadLine();
            char ch = strCh[0];
            
            if(ch >='a') //if((int)ch >= 97)
            {
                if (ch <= 'z')
                    Console.WriteLine("소문자");
            }
            else if(ch >= 'A')
            {
                if (ch <= 'Z')
                    Console.WriteLine("대문자");
            }*/
            //3. 영문자를 입력받습니다
            //   소문자는 대문자로, 대문자는 소문자로 변경해서 출력하세요
            //   (조건 연산자를 사용하세요)
            //   (아스키테이블을 참조하면 됩니다)
            /*ClearConsole();
            strCh = Console.ReadLine();
            ch = strCh[0];
            

            ch = (ch >= 'a') ? 
                (ch <= 'z' ? (char)(char-32) : ch)
                :
                (ch >= 'A' ?
                (ch <= 'Z' ? "대문자" : "대문자아님 ") : "알파벳 아님");*/
            //4. 영문자를 입력받습니다
            //   소문자는 대문자로, 대문자는 소문자로 변경해서 출력하세요
            //   (if문을 사용하세요)
            //   (아스키테이블을 참조하면 됩니다)

            /*ClearConsole();
            strCh = Console.ReadLine();
            ch = strCh[0];

            if ((ch >= 'a') && (ch <= 'z'))
            {
                Console.WriteLine((char)(ch - 32));
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine((char)(ch + 32));
            }*/


            //5. 돈의 액수를 입금하세요
            //   입금한 돈을 오만원권, 만원권, 오천원권, 천원권, 500원동전, 100원동전, 50원동전, 10원동전, 1원동전 각 몇개로 변환되는지 출력하세요
            //   출력 개수는 단위가 큰 것 순서로 계산합니다
            //   예를 들어 78670원이면<오만원 1매, 만원 2매, 오천원 1매, 천원 3매, 500원 1개, 100원 1개, 50원 1개, 10원 2개> 입니다.
            /*Console.Write("돈을 입금하세요 : ");
            int money = Int32.Parse(Console.ReadLine());
            int num_50000 = money / 50000;
            money = money % 50000;
            int num_10000 = money / 10000;
            money = money % 10000;
            int num_5000 = money / 5000;
            money = money % 5000;
            int num_1000 = money / 10000;
            money = money % 10000;
            int num_500 = money / 500;
            money = money % 500;
            int num_100 = money / 100;
            money = money % 100;
            int num_50 = money / 50;
            money = money % 50;
            int num_10 = money / 10;
            money = money % 10;
            int num_1 = money / 1;

            Console.WriteLine("5만원{0}", num_50000);
            Console.WriteLine("1만원{0}", num_10000);
            Console.WriteLine("5천원{0}", num_5000);
            Console.WriteLine("1천원{0}", num_1000);
            Console.WriteLine("500원{0}", num_500);
            Console.WriteLine("100원{0}", num_100);
            Console.WriteLine("50원{0}", num_50);
            Console.WriteLine("10원{0}", num_10);
            Console.WriteLine("1원{0}", num_1);*/


            //6. 369게임을 작성합니다.
            //   1~99까지의 정수를 입력받고
            //   3,6,9중 하나가 있으면 "박수짝"을 출력하고
            //   2개가 있으면 "박수짝짝"을 출력하세요
            //   예를 들어 13은 "박수짝"
            //   36인 경우는 "박수짝짝"을 출력하면 됩니다.
            //   
            /*int num1 = 0;
            Console.Write("1 ~ 99까지의 정수를 입력하세요 : ");
            string strNum1 = Console.ReadLine();
            num1 = Int32.Parse(strNum1);

            if (((num1 / 10) % 3 == 0) && ((num1 % 10) % 3 == 0))
            {
                Console.Write("박수짝짝");
            }
            else if (((num1 / 10) % 3 == 0) || ((num1 % 10) % 3 == 0))
            {
                Console.Write("박수짝");
            }
            else if (num1 <= 0 && num1 > 100)
            {
                Console.Write("1 ~ 99까지의 정수를 다시 입력하세요 : ");//진행해야댐
            }
            Console.ReadLine();
            Console.Clear();*/
            //7. 정수 3개를 입력받고 이 3개의 수로 삼각형을 만들 수 있는지를 판별하세요
            //   삼각형이 가능하려면 두 변의 합이 다른 한 변의 합보다 반드시 커야 합니다. (조건 연산자를 사용하세요)

            //8. 정수 3개를 입력받고 이 3개의 수로 삼각형을 만들 수 있는지를 판별하세요
            //   삼각형이 가능하려면 두 변의 합이 다른 한 변의 합보다 반드시 커야 합니다. (if문을 사용하세요)

            //9. 두개의 정수를 입력받고 몫과 나머지를 출력하세요

            //10. 세개의 정수를 입력받고 각각의 수의 제곱을 구해서 모두 더하세요.
            //  즉, num1의 제곱+num2의 제곱+num3의 제곱


        }
    }
}
