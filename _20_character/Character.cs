using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_character
{
    class Character
    {
        /*static void Main(string[] args)
        {
            char ch_a = 'a';
            char ch_b = 'b';
            char ch_A = 'A';
            char ch_B = 'B';
            char ch_z = 'z';
            char ch_Z = 'Z';

            Console.WriteLine(ch_a + "=" + (int)ch_a);
            Console.WriteLine(ch_b + "=" + (int)ch_b);
            Console.WriteLine(ch_A + "=" + (int)ch_A);
            Console.WriteLine(ch_B + "=" + (int)ch_B);
            Console.WriteLine(ch_z + "=" + (int)ch_z);
            Console.WriteLine(ch_Z + "=" + (int)ch_Z);

            Console.WriteLine(ch_a + 1);
            Console.WriteLine((char)(ch_a + 1));
        }*/


        static void Main(string[] args)
        {
            /*char ch;

            Console.WriteLine("1.영문자를 입력받습니다 소문자인지 대문자인지 판별하세요(조건 연산자를 사용하세요)");
            Console.Write("");

            Console.Write("영문자 입력 : ");

            string result = ch ==  "소문자" : "대문자")
            Console.WriteLine(ch + "는 대문자입니다.");

            Console.ReadLine(); 
            Console.Clear();


            Console.WriteLine("2. 영문자를 입력받습니다 소문자인지 대문자인지 판별하세요 (if문을 사용하세요)");*/

            Console.WriteLine("6. 369게임을 작성합니다. 1~99까지의 정수를 입력받고 3, 6, 9중 하나가 있으면 '박수짝'을 출력하고 2개가 있으면 '박수짝짝'을 출력하세요");

            int num11 = 0;
            Console.Write("1 ~ 99까지의 정수를 입력하세요 : ");
            string strNum11 = Console.ReadLine();
            num11 = Int32.Parse(strNum11);

            if(((num11 / 10) %3 ==0) && ((num11 % 10) %3 ==0))
            {
                Console.Write("박수짝짝");
            } 
            else if(((num11 / 10) % 3 == 0) || ((num11 % 10) % 3 == 0))
            {
                Console.Write("박수짝");
            }
            else if(num11 <= 0 && num11 > 100)
            {
                Console.Write("1 ~ 99까지의 정수를 다시 입력하세요 : ");//진행해야댐
            }
            Console.ReadLine();
            Console.Clear();




            Console.WriteLine("7. 정수 3개를 입력받고 이 3개의 수로 삼각형을 만들 수 있는지를 판별하세요 (조건 연산자 사용)");
            int num8 = 0, num9 = 0, num10 = 0;

            Console.Write("첫번째 정수 입력 : ");
            string strNum8 = Console.ReadLine();
            num8 = Int32.Parse(strNum8);

            Console.Write("두번째 정수 입력 : ");
            string strNum9 = Console.ReadLine();
            num9 = Int32.Parse(strNum9);

            Console.Write("두번째 정수 입력 : ");
            string strNum10 = Console.ReadLine();
            num10 = Int32.Parse(strNum10);

            string result3 = num8 + num9 <= num10 ? "삼각형으로 만들 수 없습니다." : "삼각형으로 만들 수 있습니다.";
            string result4 = num9 + num10 <= num8 ? "삼각형으로 만들 수 없습니다." : "삼각형으로 만들 수 있습니다.";
            string result5 = num8 + num10 <= num9 ? "삼각형으로 만들 수 없습니다." : "삼각형으로 만들 수 있습니다.";

            Console.Write(result3,result4,result5);

            Console.ReadLine();
            Console.Clear();




            Console.WriteLine("8. 정수 3개를 입력받고 이 3개의 수로 삼각형을 만들 수 있는지를 판별하세요 (if문 사용)");
            int num5 = 0, num6 = 0, num7 = 0;

            Console.Write("첫번째 정수 입력 : ");
            string strNum5 = Console.ReadLine();
            num5 = Int32.Parse(strNum5);

            Console.Write("두번째 정수 입력 : ");
            string strNum6 = Console.ReadLine();
            num6 = Int32.Parse(strNum6);

            Console.Write("두번째 정수 입력 : ");
            string strNum7 = Console.ReadLine();
            num7 = Int32.Parse(strNum7);

            if(num5+num6<= num7 || num5+ num7<= num6 || num6+ num7 <= num5)
            {
                Console.Write("삼각형이 아닙니다.");
            }
            else Console.Write("삼각형으로 만들 수 있습니다.");

            Console.ReadLine();
            Console.Clear();




            Console.WriteLine("9. 두개의 정수를 입력받고 몫과 나머지를 출력하세요");
            int num0 = 0, num1 = 0;

            Console.Write("첫번째 숫자 입력 : ");
            string strNum0 = Console.ReadLine();  
            num0 = Int32.Parse(strNum0);  

            Console.Write("두번째 숫자 입력 : ");
            string strNum1 = Console.ReadLine();
            num1 = Int32.Parse(strNum1);  

            Console.WriteLine("몫은 " + num0 / num1 + " 나머지는 "+ num0 % num1 + " 입니다.");
            Console.ReadLine();
            Console.Clear();




            Console.WriteLine("10. 세개의 정수를 입력받고 각각의 수의 제곱을 구해서 모두 더하세요.");
            int num2 = 0, num3 = 0, num4 = 0;
            int result = 0, result1 = 0, result2 = 0;
            int sum = 0;

            Console.Write("첫번째 숫자 입력 : ");
            string strNum2 = Console.ReadLine();
            num2 = Int32.Parse(strNum0);

            Console.Write("두번째 숫자 입력 : ");
            string strNum3 = Console.ReadLine();
            num3 = Int32.Parse(strNum1);

            Console.Write("세번째 숫자 입력 : ");
            string strNum4 = Console.ReadLine();
            num4 = Int32.Parse(strNum1);

            result = num2 * num2;
            result1 = num3 * num3;
            result2 = num4 * num4;

            sum = result + result1 + result2;

            Console.WriteLine("세 수의 제곱은 " + result +" " +result1 +" "+result2 +" 합은 " + sum +" 입니다.");

        }
    }
}
