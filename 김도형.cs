using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_05_24_solve
{
    class 김도형
    {
        static void mulprogram()
        {
            int multot = 1;
            for (int i = 1; i <= 10; i++)
            {
                multot *= i;
            }
            Console.WriteLine("1~10까지 곱한 값:" + multot);
        }
        static int MAXvalue(int a, int b)
        {
            int maxvalue = 0;
            if (a > b)
            {
                Console.Write("큰값:" + a);
                maxvalue = a;
            }
            if (a < b)
            {
                Console.Write("큰값:" + b);
                maxvalue = b;
            }
            return maxvalue;
        }

        static int MINvalue(int a, int b)
        {
            int minvalue = 0;
            if (a < b)
            {
                Console.Write("작은값:" + a);
                minvalue = a;
            }
            if (a > b)
            {
                Console.Write("작은값:" + b);
                minvalue = b;
            }
            return minvalue;
        }

        static string dis(char dis)
        {
            string str1 = "";
            if ((int)dis >= 65 || (int)dis <= 90)
            {
                str1 = "대문자";
            }
            if ((int)dis >= 97 && (int)dis <= 122)
            {
                str1 = "소문자";
            }
            if ((int)dis >= 48 && (int)dis <= 57)
            {
                str1 = "숫자";
            }

            return str1;
        }

        static int threeMax(int[] numArr)
        {
            int result = 0;
            if(numArr[0] > numArr[1] && numArr[0] > numArr[2])
            {
                result = numArr[0];
            }
            else if (numArr[1] > numArr[0] && numArr[1] > numArr[2])
            {
                result = numArr[1];
            }
            else if (numArr[2] > numArr[0] && numArr[2] > numArr[1])
            {
                result = numArr[2];
            }

            return result;
        }

        static int threeMin(int[] numArr)
        {
            int result = 0;
            if (numArr[0] < numArr[1] && numArr[0] < numArr[2])
            {
                result = numArr[0];
            }
            else if (numArr[1] < numArr[0] && numArr[1] < numArr[2])
            {
                result = numArr[1];
            }
            else if (numArr[2] < numArr[0] && numArr[2] < numArr[1])
            {
                result = numArr[2];
            }

            return result;
        }

        static void Main(string[] args)
        {
            //1. 정수 10개를 입력받아 배열에 저장하고, 이 정수중에서 3의 배수만 출력하세요

            //int[] numArr = new int[10];
            //for(int i = 0; i<numArr.Length; i++)
            //{
            //    Console.Write(i+"번째 정수입력(총10개): ");
            //    numArr[i] = Int32.Parse(Console.ReadLine());
            //}
            //for(int i= 0; i<numArr.Length; i++)
            //{
            //    if (numArr[i] % 3 == 0)
            //    {
            //        Console.WriteLine("3의배수 :{0}", numArr[i]);
            //    }
            //}

            //2. 1부터 10까지 곱해서 그 결과를 출력하는 메서드를 만들고 사용하는 프로그램을 작성하세요
            //mulprogram();



            //3. 2개의 정수를 입력받고 큰 값을 반환하는 메서드와
            //   작은 값을 반환하는 메서드를 작성하고 사용하세요
            //int[] numArr1 = new int[2];

            //Console.WriteLine("2개 정수 입력: ");
            //numArr1[0] = Int32.Parse(Console.ReadLine());
            //numArr1[1] = Int32.Parse(Console.ReadLine());

            //MAXvalue(numArr1[0], numArr1[1]);
            //MINvalue(numArr1[0], numArr1[1]);



            //3. 20개 배열을 선언하세요
            //    20개의 값을 난수를 이용해서 0 ~ 100까지의 값으로 채워넣고
            //    먼저 인덱스의 홀수번째는 앞에서부터 출력하고
            //    짝수번째는 뒤에서부터 출력하세요
            //Random rand = new Random();
            //int[] numarr2 = new int[20];

            //for (int i = 0; i < numarr2.Length; i++)
            //{
            //    numarr2[i] = rand.Next(100) + 0;
            //    if (i % 2 == 1)
            //    {
            //        Console.Write(i + "번째" + numarr2[i] +", ");
            //    }
            //}
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + "번째" + numarr2[i]+", ");
            //    }
            //}

            //4. AB + BA = 99 를 만족하는 모든 A와 B의 조합을 구하는 프로그램을 작성하세요





            //5. 0~99까지 임의의 수를 생성합니다
            //   사용자로부터 숫자를 입력받습니다
            //   사용자가 임의의 수보다 낮은 값을 입력하면 "더 높게"를 출력하고
            //   높은 값을 입력하면 "더 낮게"를 출력합니다
            //   정답을 맞추면 "맞았습니다"를 출력합니다.
            //   y/n을 묻고 y를 입력하면 다시 게임을 진행하고
            //   n을 입력하면 종료합니다

            //int dap = 0;
            //Random rand1 = new Random();
            //dap = rand1.Next(100) + 0;
            //int su = 0;
            //int c = 0;
            //char b;
            //while (c == 0)
            //{
            //        Console.WriteLine("수 입력: ");
            //        su = Int32.Parse(Console.ReadLine());
            //    if(dap > su) Console.WriteLine("더 높게");
            //    if(dap < su) Console.WriteLine("더 작게");
            //    if (dap == su)
            //    {
            //        Console.WriteLine("맞았습니다.");
            //        Console.WriteLine("다시하겠습니까? (y/n): ");
            //        b = Console.ReadLine()[0];
            //        if(b == 'y')
            //        {
            //            c = 0;
            //            dap = rand1.Next(100) + 0;
            //        }
            //        if(b == 'n')
            //        {
            //            Console.WriteLine("종료하겠습니다.");
            //            c = 1;
            //        }
            //    }


            //}


            //6. 두 개의 정수를 입력받습니다.
            //   두 정수를 포함한 사이의 정수의 합을 출력하세요
            //   예를 들면 3과 5를 입력하면 3+4+5의 합을 출력하면 됩니다.
            //int num3;
            //int num4;
            //Console.WriteLine("두 개의 정수 입력: ");
            //int result = 0;
            //num3 = Int32.Parse(Console.ReadLine());
            //num4 = Int32.Parse(Console.ReadLine());
            //for (int i =num3; i <=num4; i++) {
            //    result += i;
            //}
            //Console.WriteLine("합:" + result);

            //7. 영문자와 숫자를 입력받고
            //   "대문자", "소문자", "숫자"를
            //   판단하는 메서드를 제작하고
            //   사용해보세요
            //   아스키코드테이블 참조


            char ch;
            Console.WriteLine("입력: ");
            ch = Console.ReadLine()[0];

            dis(ch);






            //8. 두 수를 입력받고 최대 공약수를 출력하세요


            //9. 전달된 값이 소수인지 아닌지 판단하여, 소수인 경우 true를, 소수가 아닌 경우 false를 반환하는 메서드를 정의하고
            //이를 이용해서 1이상 100이하의 소수가 전부 출력할 수 있도록 코드를 구성하세요
            //소수는 1외에 자기자신으로만 나뉘어지는 수입니다



            //10. 구구단을 출력하세요
            //2x1= 2 3x1= 3 4x1= 4... 9x1= 9
            //2x2= 4 3x2= 6 4x2= 8... 9x2= 18...
            //2x9= 18 3x9= 27 4x9= 36... 9x9= 81
            //for(int i = 2; i<=9; i++)
            //{
            //    for(int j = 1; j<=9; j++)
            //    {
            //        Console.Write(i + "X" + j + "=" + i * j+"  ");
            //    }
            //}


            //11. 세개의 정수를 매개변수로 받아서
            //  가장 큰 수를 반환하는 메서드와
            //  가장 작은 수를 반환하는 메서드를 제작해서 사용해보세요

            int[] numArr4 = new int[3];
            for (int i = 0; i < numArr4.Length; i++)
            {
                Console.WriteLine(i+"번째 정수 입력(총3개): ");
                numArr4[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("큰수:"+threeMax(numArr4));
            Console.Write("작은수:" + threeMin(numArr4));




            //12. 사용자로부터 초를 입력받은 후
            //  이 초를 [시간, 분, 초] 로 출력하는 메서드를 제작해서
            //  사용해보세요
            //  예를 들어 3672를 입력하면 [1시간, 1분, 12초]를
            //  출력하면 됩니다.
        }
    }
}

