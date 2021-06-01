using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_05_24_HomeWork
{
    
    class WorkMain
    {
        //2. 1부터 10까지 곱해서 그 결과를 출력하는 메서드를 만들고 사용하는 프로그램을 작성하세요
        static int Mul()
        {
            int a = 1;
            for (int i = 1; i <= 10; i++)
            {
                a *= i;
                Console.WriteLine(a);
            }
            return 0;
        }

        //3. 2개의 정수를 입력받고 큰 값을 반환하는 메서드와
        //   작은 값을 반환하는 메서드를 작성하고 사용하세요
        static int MaxOrMin(int a, int b)
        {
            if(a > b)
            {
                Console.WriteLine("{0}이 더 크다", a);
                return a;
            }
            Console.WriteLine("{0}이 더 크다", b);
            return b;
        }

        static void Asc(int code)
        {
            if (code >= 65 && code <= 96)
            {
                Console.WriteLine("대문자");
            }
            else if (code <= 122 && code >= 97)
            {
                Console.WriteLine("소문자");
            }
            else
            {
                Console.WriteLine("특수기호 및 숫자");
            }
        }
        static int Gcd(int a, int b)
        {
            while (b != 0) //b가 0이 아닐때
            {
                int res = a % b; //res는 a%b의 나머지이다
                a = b; //a=b이다.
                b = res; //b=나머지이다.
            }
            return a;
        }
        static int GuguDan(int a, int b)
        {
            return a * b;
        }
        static int Max(int a, int b, int c)
        {
            int[] x = { a, b, c };
            int max = 0;
            
            for(int i = 0; i < x.Length; i++)
            {
                if (max < x[i])
                {
                    max = x[i];
                }

            }
            return max;
        }
        static int Min(int a, int b, int c)
        {
            int[] n = { a, b, c };
            int min = a;
            for(int i =0; i < n.Length;i++)
            {
                if(min > n[i])
                {
                    min = n[i];
                }
            }
            return min;
        }
        static void Time(int a)
        {
            int hour = 0, min = 0, sec = a;

            min = sec / 60;
            hour = min / 60;
            sec = sec % 60;
            min = min % 60;
            Console.WriteLine("{0}시 {1}분 {2}초",hour, min, sec);
        }
        static void Main(string[] args)
        {
            //1.정수 10개를 입력받아 배열에 저장하고, 이 정수중에서 3의 배수만 출력하세요
            /*int[] ar = { };
            ar = new int[10];

            for(int i = 0; i < ar.Length; i++)
            {
                Console.Write("정수 입력(10개 까지 입력 받음):");
                ar[i] = Int32.Parse(Console.ReadLine());
            }
            for(int i = 0; i < ar.Length; i++)
            {
                if(ar[i] % 3 == 0)
                {
                    Console.WriteLine("3의 배수만 출력합니다.: " + ar[i]);
                }
            }*/

            //2. 1부터 10까지 곱해서 그 결과를 출력하는 메서드를 만들고 사용하는 프로그램을 작성하세요
            //Mul();

            //3. 2개의 정수를 입력받고 큰 값을 반환하는 메서드와
            //   작은 값을 반환하는 메서드를 작성하고 사용하세요
            /*int[] ar1 = new int[2];
            for (int i = 0; i < ar1.Length; i++)
            {
                Console.WriteLine("정수입력: ");
                ar1[i] = Int32.Parse(Console.ReadLine());
            }
            MaxOrMin(ar1[0], ar1[1]);*/

            //4. 20개 배열을 선언하세요
            //    20개의 값을 난수를 이용해서 0 ~100까지의 값으로 채워넣고
            //   먼저 인덱스의 홀수번째는 앞에서부터 출력하고
            //    짝수번째는 뒤에서부터 출력하세요

            /*int[] ar2 = new int[20];
            int[] ar2_1 = new int[20];
            int s = 0, e = 19;
            Random rand = new Random();
            for(int i=0; i<ar2.Length; i++)
            {
                int randIndex = rand.Next(0, 100);
                ar2[i] = randIndex;
                Console.WriteLine(i+". 랜덤 배열"+ar2[i]);

                if (ar2[i] % 2 == 1)
                {
                    ar2_1[s] = ar2[i];
                    s++;
                }
                else
                {
                    ar2_1[e] = ar2[i];
                    e--;
                }
            }
            for(int i =0; i < ar2_1.Length; i++)
            {
                Console.WriteLine(i+". 재배열"+ar2_1[i]);
            }*/

            //5.AB + BA = 99 를 만족하는 모든 A와 B의 조합을 구하는 프로그램을 작성하세요

            for (int i = 0; i < 10; i++) //i는 0부터 9까지
            {
                for (int j = 0; j < 10; j++)//j는 0부터 9까지
                {
                    if (((i * 10) + j) + ((j * 10) + i) == 99) //(i*I0)+j + (j*10)+i == 99일때 출력
                    {
                        Console.WriteLine((i + " * 10 + " + j) + " + " + (j + " * 10 + " + i) + " = " i + j);
                    }
                }
            }

            //6. 0~99까지 임의의 수를 생성합니다
            //   사용자로부터 숫자를 입력받습니다
            //   사용자가 임의의 수보다 낮은 값을 입력하면 "더 높게"를 출력하고
            //   높은 값을 입력하면 "더 낮게"를 출력합니다
            //   정답을 맞추면 "맞았습니다"를 출력합니다.
            //   y / n을 묻고 y를 입력하면 다시 게임을 진행하고
            //   n을 입력하면 종료합니다

            /*Random rand1 = new Random();
            int num = rand1.Next(0, 99);

            while (true)
            { 
                
                Console.Write("수를 알아봅시다(0~99정수입력): ");
                int iNum = Int32.Parse(Console.ReadLine());
                if(iNum == num)
                {
                    Console.WriteLine("맞았습니다.");
                    Console.Write("더 하시겠습니까? (y/n): ");
                    string yn = Console.ReadLine();
                    if (yn == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("종료합니다.");
                        break;
                    }
                    else if(yn == "y")
                    {
                        num = rand1.Next(0, 99);
                        continue;
                    }

                }
                else if(iNum > num)
                {
                    Console.WriteLine("더 낮게");
                }
                else if(iNum < num)
                {
                    Console.WriteLine("더 높게");
                }
               
            }*/

            //7.두 개의 정수를 입력받습니다.
            //   두 정수를 포함한 사이의 정수의 합을 출력하세요
            //   예를 들면 3과 5를 입력하면 3 + 4 + 5의 합을 출력하면 됩니다.
            /*int a = 0, b = 0;
            int res=0;

            Console.Write("정수입력: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("정수입력: ");
            b = Int32.Parse(Console.ReadLine());
            
            if(a < b)
            {
                for(int i = a; i <= b; i++)
                {
                    res += i;
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    res += i;
                }
            }
            Console.WriteLine(res);*/

            //8. /* 영문자와 숫자를 입력받고
            //   * "대문자", "소문자", "숫자"를
            //   * 판단하는 메서드를 제작하고
            //   * 사용해보세요
            //   * 아스키코드테이블 참조
            //   * */

            /*int code;
            Console.Write("영문자, 숫자 입력시 구분해 드립니다: ");
            code = Console.Read();
            Console.ReadLine();
            Asc(code);*/

            //9.두 수를 입력받고 최대 공약수를 출력하세요
            int gcd = Gcd(32, 18);
            //Console.WriteLine(gcd);

            //10.전달된 값이 소수인지 아닌지 판단하여, 소수인 경우 true를, 소수가 아닌 경우 false를 반환하는 메서드를 정의하고
            //이를 이용해서 1이상 100이하의 소수가 전부 출력할 수 있도록 코드를 구성하세요
            //소수는 1외에 자기자신으로만 나뉘어지는 수입니다


            //11.구구단을 출력하세요
            //2x1 = 2 3x1 = 3 4x1 = 4... 9x1 = 9
            //2x2 = 4 3x2 = 6 4x2 = 8... 9x2 = 18...
            //2x9 = 18 3x9 = 27 4x9 = 36... 9x9 = 81
            /* int res = 0;
             for(int i = 2; i <= 9; i++)
             {
                 for(int j = 1; j <= 9; j++)
                 {
                     res=GuguDan(i, j);
                     Console.WriteLine("{0} X {1} = {2}", i, j,res);
                 }
             }*/

            //12.세개의 정수를 매개변수로 받아서
            // 가장 큰 수를 반환하는 메서드와
            //  가장 작은 수를 반환하는 메서드를 제작해서 사용해보세요
            /*Console.WriteLine(Max(8, 12, 15));
            Console.WriteLine(Min(10, 6, 8));
            //13.사용자로부터 초를 입력받은 후
            // 이 초를[시간, 분, 초]로 출력하는 메서드를 제작해서
            //  사용해보세요
            //  예를 들어 3672를 입력하면[1시간, 1분, 12초]를
            // 출력하면 됩니다.
            Time(3672);*/

            work2_24 work2 = new work2_24();
            //work2.RandNum();
           // work2.CopyArr();
            work3_24 work3 = new work3_24();
            //work3.GuGuDan();

            //work3.Sum();

            work4_24 work4 = new work4_24();
            /*work4.Gugu();
            work4.Round(5);
            work4.Area(5);
            work4.PrimeNum(7);
            for(int i =2; i <= 100; i++)
            {
                if (work4.PrimeNum(i) == true)
                {
                    work4.PrimeNum(i);
                }
            }
            work4.showHi(3);
            work4.SayHi(3);*/

            ChinaFoods china = new ChinaFoods();
            //china.China();
        }
    }
}
