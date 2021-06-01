using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_05_24
{
    class 김민혁
    { 
        static void Q(int a)
        {
            switch (a)
            {
                case 1:
                    Q1();
                    break;
                case 2:
                    Q2();
                    break;
                case 3:
                    Q3();
                    break;
                case 4:
                    Q4();
                    break;
                default:
                    Console.WriteLine("다시 입력해주세요.");
                    break;
            }
        }
        
        static void Clear()
        {
            Console.ReadKey();
            Console.Clear();
        }

        static void Q1()
        {
            Console.Write("문제 번호 입력: ");
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    Q1_1();
                    break;
                case 2:
                    Q1_2();
                    break;
                case 3:
                    Q1_3();
                    break;
                case 4:
                    Q1_4();
                    break;
                case 5:
                    Q1_5();
                    break;
                case 6:
                    Q1_6();
                    break;
                case 7:
                    Q1_7();
                    break;
                case 8:
                    Q1_8();
                    break;
                case 9:
                    Q1_9();
                    break;
                case 10:
                    Q1_10();
                    break;
                case 11:
                    Q1_11();
                    break;
                case 12:
                    Q1_12();
                    break;
                case 13:
                    Q1_13();
                    break;
                default:
                    Console.WriteLine("처음부터 다시 입력해주세요.");
                    break;
            }
            Console.Clear();
        }
        static void Q2()
        {
            Console.Write("문제 번호 입력: ");
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    Q2_1();
                    break;
                case 2:
                    Q2_2();
                    break;
                case 3:
                    Q2_3();
                    break;
                case 4:
                    Q2_4();
                    break;
                default:
                    Console.WriteLine("처음부터 다시 입력해주세요.");
                    break;
            }
            Console.Clear();
        }
        static void Q3()
        {
            Console.Write("문제 번호 입력: ");
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    Q3_1();
                    break;
                case 2:
                    Q3_2();
                    break;
                case 3:
                    Q3_3();
                    break;
                case 4:
                    Q3_4();
                    break;
                case 5:
                    Q3_5();
                    break;
                default:
                    Console.WriteLine("처음부터 다시 입력해주세요.");
                    break;
            }
            Console.Clear();
        }
        static void Q4()
        {
            Console.Write("문제 번호 입력: ");
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    Q4_1();
                    break;
                case 2:
                    Q4_2();
                    break;
                case 3:
                    Q4_3();
                    break;
                case 4:
                    Q4_4();
                    break;
                case 5:
                    Q4_5();
                    break;
                default:
                    Console.WriteLine("처음부터 다시 입력해주세요.");
                    break;
            }
            Console.Clear();
        }

        static void Q1_1()
        {
            Console.WriteLine("1-1번 : 정수 10개를 입력받아 배열에 저장하고, 이 정수중에서 3의 배수만 출력하세요");

            int[] arrNum = new int[10];

            for(int i = 0; i < arrNum.Length; i++)
            {
                Console.Write("정수를 입력해주세요: ");
                arrNum[i] = Int32.Parse(Console.ReadLine());
            }

            for(int i = 0; i < arrNum.Length; i++)
            {
                if(arrNum[i] % 3 == 0)
                {
                    Console.WriteLine(arrNum[i]);
                }
            }

            Clear();
        }

        static int Q1_2_1(int a, int b)
        {
            int result = 1;

            for(int i = a; i <= b; i++)
            {
                result *= i;
            }

            return result;
        }

        static void Q1_2()
        {
            Console.WriteLine("1-2번 : 1부터 10까지 곱해서 그 결과를 출력하는 메서드를 만들고 사용하는 프로그램을 작성하세요");

            Console.WriteLine(Q1_2_1(1, 10));

            Clear();
        }

        static int Q1_3_1(int a, int b)
        {
            int result;

            if (a > b)
            {
                result = a;
            }
            else
            {
                result = b;
            }

            return result;
        }

        static int Q1_3_2(int a, int b)
        {
            int result;

            if (a < b)
            {
                result = a;
            }
            else
            {
                result = b;
            }

            return result;
        }

        static void Q1_3()
        {
            Console.WriteLine("1-3번 : 2개의 정수를 입력받고 큰 값을 반환하는 메서드와 "+
                                      "작은 값을 반환하는 메서드를 작성하고 사용하세요");

            Console.Write("정수를 입력해주세요: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("정수를 입력해주세요: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("큰 값: "+Q1_3_1(a, b));
            Console.WriteLine("작은 값: " + Q1_3_2(a, b));

            Clear();
        }

        static void Q1_4()
        {
            Console.WriteLine("1-4번 : 20개 배열을 선언하세요. " +
                                      "20개의 값을 난수를 이용해서 0 ~100까지의 값으로 채워넣고 " +
                                      "먼저 인덱스의 홀수번째는 앞에서부터 출력하고 " +
                                      "짝수번째는 뒤에서부터 출력하세요");

            Random ran = new Random();

            int[] arrNum = new int[20];

            for(int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = ran.Next(100);
                Console.WriteLine($"{i}번째 {arrNum[i]}");
            }

            for (int i = 0; i < arrNum.Length; i++)
            {
                if(i % 2 != 0)
                {
                    Console.Write("홀수: " + arrNum[i] + " ");
                }  
            }

            Console.WriteLine();

            for (int i = arrNum.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write("짝수: " + arrNum[i] + " ");
                }
            }

            Clear();
        }

        static void Q1_5()
        {
            Console.WriteLine("1-5번 : AB + BA = 99 를 만족하는 모든 A와 B의 조합을 구하는 프로그램을 작성하세요");

            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                }
            }

            Clear();
        }

        static void Q1_6()
        {
            Console.WriteLine("1-6번 : 0~99까지 임의의 수를 생성합니다 " +
                                      "사용자로부터 숫자를 입력받습니다. " +
                                      "사용자가 임의의 수보다 낮은 값을 입력하면 \"더 높게\"를 출력하고 " +
                                      "높은 값을 입력하면 \"더 낮게\"를 출력합니다. " +
                                      "정답을 맞추면 \"맞았습니다\"를 출력합니다. " +
                                      "y / n을 묻고 y를 입력하면 다시 게임을 진행하고 " +
                                      "n을 입력하면 종료합니다");
            Random ran = new Random();

            for(; ; )
            {
                int result = ran.Next(99);
                for (; ; )
                {
                    Console.Write("정수 입력: ");
                    int num = Int32.Parse(Console.ReadLine());

                    if (num == result)
                    {
                        Console.WriteLine("맞았습니다.");
                        break;
                    }
                    else if (num > result)
                    {
                        Console.WriteLine("더 낮게");
                    }
                    else if (num < result)
                    {
                        Console.WriteLine("더 높게");
                    }
                }

                Console.WriteLine("정답은 : " + result);

                Console.Write("게임을 더 진행하시겠습니까?(y/n) ");
                string str = Console.ReadLine();

                if(str == "n")
                {
                    break;
                }
                Console.Clear();
            }

            Clear();
        }

        static void Q1_7()
        {
            Console.WriteLine("1-7번 : 두 개의 정수를 입력받습니다. " +
                                      "두 정수를 포함한 사이의 정수의 합을 출력하세요. " +
                                      "예를 들면 3과 5를 입력하면 3 + 4 + 5의 합을 출력하면 됩니다.");

            int max, min,result = 0;

            Console.Write("정수를 입력하세요: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.Write("정수를 입력하세요: ");
            int num2 = Int32.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                max = num1;
                min = num2;
            }
            else
            {
                max = num2;
                min = num1;
            }

            for(int i = min; i <= max; i++)
            {
                result += i;
            }

            Console.WriteLine(result);

            Clear();
        }

        static void Q1_8_1(char a, int b)
        {
            if(a >= 'a' && a <= 'z')
            {
                Console.WriteLine("소문자");
            }
            else if(a >= 'A' && a <= 'Z')
            {
                Console.WriteLine("대문자");
            }
            else
            {
                Console.WriteLine("영문자가 아닙니다.");
            }

            if(b >= '0' && b <= '9')
            {
                Console.WriteLine("숫자");
            }
            else
            {
                Console.WriteLine("영문자, 숫자가 아닙니다.");
            }
        }

        static void Q1_8()
        {
            Console.WriteLine("1-8번 : 영문자와 숫자를 입력받고 " +
                                    "\"대문자\", \"소문자\", \"숫자\"를 " +
                                      "판단하는 메서드를 제작하고 " +
                                      "사용해보세요. " +
                                      "아스키코드테이블 참조");

            Console.Write("영문자를 입력하세요: ");
            char cha = Char.Parse(Console.ReadLine());

            Console.Write("숫자를 입력하세요: ");
            char num = Char.Parse(Console.ReadLine());

            Q1_8_1(cha, num);

            Clear();
        }

        static void Q1_9()
        {
            Console.WriteLine("1-9번 : 두 수를 입력받고 최대 공약수를 출력하세요");

            int a,max = 0;

            Console.Write("정수를 입력하세요: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.Write("정수를 입력하세요: ");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                a = num1;
            }
            else
            {
                a = num2;
            }

            for(int i = 1; ; i++)
            {

                if(num1 % i == 0 && num2 % i == 0)
                {
                    max = i;
                }

                if(i == a)
                {
                    break;
                }
            }

            Console.WriteLine($"{num1}와 {num2}의 최대 공약수는 {max}다.");

            Clear();
        }

        static bool Q1_10_1(int a)
        {
            int cnt = 0;

            for(int i = 1; i <= a; i++)
            {
                if(a % i == 0)
                {
                    cnt++;
                }
            }

            return (cnt == 2);
        }

        static void Q1_10()
        {
            Console.WriteLine("1-10번 : 전달된 값이 소수인지 아닌지 판단하여, 소수인 경우 true를, 소수가 아닌 경우 false를 반환하는 메서드를 정의하고 " +
                                       "이를 이용해서 1이상 100이하의 소수가 전부 출력할 수 있도록 코드를 구성하세요. " +
                                       "소수는 1외에 자기자신으로만 나뉘어지는 수입니다");

            for(int i = 1; i <= 100; i++)
            {
                if (Q1_10_1(i))
                {
                    Console.WriteLine($"{i}는 소수입니다.");
                }
            }

            Clear();
        }

        static void Q1_11()
        {
            Console.WriteLine("1-11번 : 구구단을 출력하세요");

            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.Write($"{j} X {i} = {j * i} ");
                }
                Console.WriteLine();
            }

            Clear();
        }

        static int Q1_12_1(int a, int b, int c)
        {
            int max = 0;

            if(a > b)
            {
                if(a > c)
                {
                    max = a;
                }
                else if(a < c)
                {
                    max = c;
                }
            }
            else if(a < b)
            {
                if(b > c)
                {
                    max = b;
                }
                else if(b < c)
                {
                    max = c;
                }
            }

            return max;
        }

        static int Q1_12_2(int a, int b, int c)
        {
            int min = 0;

            if (a > b)
            {
                if (b > c)
                {
                    min = c;
                }
                else if (b < c)
                {
                    min = b;
                }
            }
            else if (a < b)
            {
                if (a > c)
                {
                    min = c;
                }
                else if (a < c)
                {
                    min = a;
                }
            }

            return min;
        }

        static void Q1_12()
        {
            Console.WriteLine("1-12번 : 세개의 정수를 매개변수로 받아서 " +
                                       "가장 큰 수를 반환하는 메서드와 "+
                                       "가장 작은 수를 반환하는 메서드를 제작해서 사용해보세요");

            Console.Write("정수를 입력하세요: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.Write("정수를 입력하세요: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.Write("정수를 입력하세요: ");
            int num3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"가장 큰 값은 {Q1_12_1(num1, num2, num3)}, 가장 작은 값은 {Q1_12_2(num1, num2, num3)}");

            Clear();
        }

        static void Q1_13_1(int a)
        {
            int hour,min,sec;

            Console.Write(a + "초는: ");

            sec = a % 60;
            a -= sec;

            min = a / 60;

            hour = min / 60;
            min %= 60;

            Console.WriteLine($"{hour}시간, {min}분, {sec}초");
        }

        static void Q1_13()
        {
            Console.WriteLine("1-13번 : 사용자로부터 초를 입력받은 후 " +
                                       "이 초를[시간, 분, 초]로 출력하는 메서드를 제작해서 " +
                                       "사용해보세요. " +
                                       "예를 들어 3672를 입력하면[1시간, 1분, 12초]를 " +
                                       "출력하면 됩니다.");

            Console.Write("초를 입력하세요: ");
            int num = Int32.Parse(Console.ReadLine());

            Q1_13_1(num);

            Clear();
        }

        static void Q2_1()
        {
            Console.WriteLine("2-1번 : 5개의 int배열을 선언하고 " +
                                      "난수로 값을 입력하고 " +
                                      "출력하세요");

            Random ran = new Random();

            int[] arrNum = new int[5];

            for(int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = ran.Next();

                Console.WriteLine($"arrNum[{i}]번째 값은 : {arrNum[i]}");
            }

            Clear();
        }

        static void Q2_2()
        {
            Console.WriteLine("2-2번 : 2개의 새로운 int배열을 할당하고 " +
                                      "값을 복사하세요");

            Random ran = new Random();

            int[] arrNum1 = new int[5];
            int[] arrNum2;

            for (int i = 0; i < arrNum1.Length; i++)
            {
                arrNum1[i] = ran.Next();

                Console.WriteLine($"arrNum1[{i}]번째 값은 : {arrNum1[i]}");
            }

            Console.WriteLine("============ 복사 후 ============");

            arrNum2 = (int[])arrNum1.Clone();

            for (int i = 0; i < arrNum1.Length; i++)
            { 
                Console.WriteLine($"arrNum2[{i}]번째 값은 : {arrNum2[i]}");
            }

            Clear();
        }

        static void Q2_3()
        {
            Console.WriteLine("2-3번 : Arrays.Sort를 사용해서 오름차순 정렬하세요");

            Random ran = new Random();

            int[] arrNum = new int[5];

            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = ran.Next();

                Console.WriteLine($"arrNum[{i}]번째 값은 : {arrNum[i]}");
            }

            Console.WriteLine("============ 정렬 후 ============");

            Array.Sort(arrNum);

            for (int i = 0; i < arrNum.Length; i++)
            {
                Console.WriteLine($"arrNum[{i}]번째 값은 : {arrNum[i]}");
            }

            Clear();
        }

        static void Q2_4()
        {
            Console.WriteLine("2-4번 : 정렬을 하고 내림차순으로 출력하세요");

            Random ran = new Random();

            int[] arrNum = new int[5];

            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = ran.Next();

                Console.WriteLine($"arrNum[{i}]번째 값은 : {arrNum[i]}");
            }

            Console.WriteLine("============ 정렬 후 ============");

            Array.Sort(arrNum);

            for (int i = 0; i < arrNum.Length; i++)
            {
                Console.WriteLine($"arrNum[{i}]번째 값은 : {arrNum[i]}");
            }

            Console.WriteLine("============ 역순 후 ============");

            Array.Reverse(arrNum);

            for (int i = 0; i < arrNum.Length; i++)
            {
                Console.WriteLine($"arrNum[{i}]번째 값은 : {arrNum[i]}");
            }

            Clear();
        }

        static void Q3_1()
        {
            Console.WriteLine("3-1번 : 8 x 9 이차원 배열을 선언하세요");

            int[,] arrNum = new int[8,9];

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    arrNum[i, j] += j;

                    Console.Write(arrNum[i, j]);
                }
                Console.WriteLine();
            }

            Clear();
        }

        static void Q3_2()
        {
            Console.WriteLine("3-2번 : 8 x 9 이차원 배열에 구구단의 결과값을 대입하세요");

            int[,] arrNum = new int[8,9];
            int k = 1, l = 1;

            for(int i = 0; i < 8; i++)
            {
                l = 1;
                for(int j = 0; j < 9; j++)
                {
                    arrNum[i, j] += k * l;

                    Console.Write($"{k} X {l} = {arrNum[i, j]} ");
                    l++;
                }
                k++;
                Console.WriteLine();
            }

            Clear();
        }

        static void Q3_3()
        {
            Console.WriteLine("3-3번 : 2번에 대입한 값을 출력하세요");


            int[,] arrNum = new int[8, 9];
            int k = 1, l = 1;

            for (int i = 0; i < 8; i++)
            {
                l = 1;
                for (int j = 0; j < 9; j++)
                {
                    arrNum[i, j] += k * l;

                    Console.Write($"{k} X {l} = {arrNum[i, j]} ");
                    l++;
                }
                k++;
                Console.WriteLine();
            }

            Clear();
        }

        static void Q3_4()
        {
            Console.WriteLine("3-4번 : 7개의 float 배열을 할당하세요. " +
                                      "앞의 5개에는 성적을 입력받고 " +
                                      "6번째는 총점 " +
                                      "7번째는 평균을 계산해서 넣으세요");

            float result = 0;
            float[] arrFl = new float[7];

            for(int i = 0; i < 5; i++)
            {
                Console.Write("성적 입력: ");
                arrFl[i] = float.Parse(Console.ReadLine());

                result += arrFl[i];
            }

            arrFl[5] = result;
            arrFl[6] = result / 5;

            for (int i = 0; i < arrFl.Length; i++)
            {
                if (i != 5 && i != 6)
                {
                    Console.WriteLine("성적 : " + arrFl[i]);
                }
                else if (i == 5)
                {
                    Console.WriteLine("총점 : " + arrFl[i]);
                }
                else if (i == 6)
                {
                    Console.WriteLine("평균 : " + arrFl[i]);
                }
            }


            Clear();
        }

        static void Q3_5()
        {
            Console.WriteLine("3-5번 : 4번을 출력하세요");

            float result = 0;
            float[] arrFl = new float[7];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("성적 입력: ");
                arrFl[i] = float.Parse(Console.ReadLine());

                result += arrFl[i];
            }

            arrFl[5] = result;
            arrFl[6] = result / 5;

            for (int i = 0; i < arrFl.Length; i++)
            {
                if (i != 5 && i != 6)
                {
                    Console.WriteLine("성적 : " + arrFl[i]);
                }
                else if (i == 5)
                {
                    Console.WriteLine("총점 : " + arrFl[i]);
                }
                else if (i == 6)
                {
                    Console.WriteLine("평균 : " + arrFl[i]);
                }
            }

            Clear();
        }

        static void Q4_1()
        {
            Console.WriteLine("4-1번 : 구구단의 짝수단만 출력하되, " +
                                      "2단은 2 x 2까지 " +
                                      "4단은 4 x 4까지 " +
                                      "6단은 6 x 6까지 " +
                                      "8단은 8 x 8까지 출력하세요");

            for(int i = 0; i <= 9; i++)
            {
                for(int j = 0; j <= 9; j++)
                {
                    if(i % 2 == 0)
                    {
                        Console.WriteLine($"{i} X {j} = {i * j} ");
                        if(j == i)
                        {
                            break;
                        }
                    }
                }
            }

            Clear();
        }

        static double Q4_2_1(double a)
        {
            double result = 0;

            result = a * a * 3.14;

            return result;
        }

        static double Q4_2_2(double a)
        {
            double result = 0;

            result = 2 * 3.14 * a;

            return result;
        }

        static void Q4_2()
        {
            Console.WriteLine("4-2번 : 원의 반지름 정보를 전달하면, " +
                                      "원의 넓이를 계산하여 반환하는 메서드와 " +
                                      "원의 둘레를 계산하여 반환하는 메서드를 정의하고 " +
                                      "main에서 사용하세요");

            Console.Write("원의 반지름을 입력하세요: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine($"원의 넓이 : {Q4_2_1(a)}, 원의 둘레 : {Q4_2_2(a)}");

            Clear();
        }

        static bool Q4_3_1(int a)
        {
            int cnt = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    cnt++;
                }
            }

            return (cnt == 2);
        }

        static void Q4_3()
        {
            Console.WriteLine("4-3번 : 전달된 값이 소수(prime number)인지 아닌지 판단하여 " +
                                      "소수인 경우는 true를, 소수가 아닌 경우는 false를 " +
                                      "반환하는 메서드를 정의하고, " +
                                      "이를 이용해서 1 이상 100이하의 소수를 전부 출력할 수 있도록 " +
                                      "main 메서드를 정의하세요.");

            for (int i = 1; i <= 100; i++)
            {
                if (Q1_10_1(i))
                {
                    Console.WriteLine($"{i}는 소수입니다.");
                }
            }

            Clear();
        }

        static void showHi(int a)
        {
            for(int i = 1; i <= a; i++)
            {
                Console.WriteLine("Hi~ ");
            }
        }

        static void Q4_4()
        {
            Console.WriteLine("4-4번 : showHi(3); " +
                                      "을 입력하면 " +
                                      "Hi~ " +
                                      "Hi~ " +
                                      "Hi~ " +
                                      "회수만큼 Hi~를 호출할 수 있도록 for문을 사용해서 출력하세요");

            Console.Write("정수 입력: ");
            showHi(Int32.Parse(Console.ReadLine()));

            Clear();
        }

        static void showHi1(int a)
        {
            if (a == 0) return;
            showHi2(a-1);
            Console.WriteLine("Hi~ ");
        }

        static void showHi2(int a)
        {
            if (a == 0) return;
            showHi1(a - 1);
            Console.WriteLine("Hi~ ");
        }

        static void Q4_5()
        {
            Console.WriteLine("4-5번 : 4 - 4번: showHi(3); " +
                                      "을 입력하면 " +
                                      "Hi~ " +
                                      "Hi~ " +
                                      "Hi~ " +
                                      "회수만큼 Hi~를 호출할 수 있도록 재귀호출을 사용해서 출력하세요");

            Console.Write("정수 입력: ");
            showHi1(Int32.Parse(Console.ReadLine()));

            Clear();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("문제 번호 입력: ");
                Q(Int32.Parse(Console.ReadLine()));

                Console.Write("종료하시겠습니까? (yes/no): ");
                string b = Console.ReadLine();

                if(b == "yes")
                {
                    Console.WriteLine("종료하겠습니다.");
                    break;
                }

                Console.Clear();
            }
        }
    }
}
