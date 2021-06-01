using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Class
    {
        static void Main(string[] agrs)
        {
            Console.Write("큰 값반환 : "+Return_func1()+"작은 값 반환 :"+Return_func2());
            print_arr();
        }
        static void function_sum()
        {
            int sum = 0;
            for(int i= 1;i <= 10;i++)
                sum += i;
            Console.WriteLine("합 : " + sum);
        }
        static void func_arr()
        {
            int[] arr_num = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + "번쨰 배열 숫자를 입력하세요 : ");
                string str = Console.ReadLine();
                arr_num[i] = Int32.Parse(str);
            }
            for (int i = 0; i < 10; i++)
            {
                if (arr_num[i] % 3 == 0)
                    Console.WriteLine("3의 배수는 : " + arr_num[i]);
            }
        }
        static int Return_func1()
        {
            int num1,num2;
            Console.Write("숫자 입력 : ");
            string str = Console.ReadLine();
            num1 = Int32.Parse(str);

            Console.Write("숫자 입력 : ");
            str = Console.ReadLine();
            num2 = Int32.Parse(str);

            if (num1 > num2)
            {
                Console.WriteLine("더 큰 숫자는 : " + num1);
                return num1;
            }
            else if(num2 > num1)
            {
                Console.WriteLine("더 큰 숫자는 : " + num2);
                return num2;
            }
            else 
            {
                Console.WriteLine("두 수는 같습니다");
                return num1;
            }
        }
        static int Return_func2()
        {
            int num1, num2;

            Console.Write("숫자 입력 : ");
            string str = Console.ReadLine();
            num1 = Int32.Parse(str);

            Console.Write("숫자 입력 : ");
            str = Console.ReadLine();
            num2 = Int32.Parse(str);

            if (num1 < num2)
            {
                Console.WriteLine("더 작은 숫자는 : " + num1);
                return num1;
            }
            else if (num2 < num1)
            {
                Console.WriteLine("더 작은 숫자는 : " + num2);
                return num2;
            }
            else
            {
                Console.WriteLine("두 수는 같습니다");
                return num1;
            }
        }
        static void print_arr()
        {
            int[] num = new int[20];
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
                num[i] = rand.Next(0, 101);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (i == 0 && (j % 2 == 1))
                        Console.WriteLine(j+"번째 : " +num[j]);
                    else if (i == 1 && (j % 2 == 0))
                        Console.WriteLine(j + "번째 : "+num[j]);
                }
            }      

            
        }
        static void A_B()
        {
            double[] arr = new double[5];
            double num1 = 0;
            double num = 99;
            double num3 = 99;
            double tmp = 0;
            int b = 1;
            for (int i = 0;i<5;i++)
            {
                num1 = num / 2;
                arr[i] = num1;
                tmp = num / 2;
                num = tmp;
                Console.WriteLine(num1);
            }
            for(int i = 0; i<4; i++)
            {
                Console.WriteLine(arr[i] + " * " + b + " + " + b +"*" + arr[i]+ "= " + num3 );
                b *= 2;
            }
        }
        static void randem()
        {
            int select;
            Random rand = new Random();
            int num = rand.Next(0, 100);

            while (true)
            {
                Console.Write("숫자 입력 : ");
                string str = Console.ReadLine();
                select = Int32.Parse(str);

                if (select < num)
                    Console.Write("더 높게");
                else if (select > num)
                    Console.Write("더 낮게");
                else
                {
                    Console.Write("정답입니다. 종료y,다시n");
                    str = Console.ReadLine();
                    if (str == "y")
                        break;
                    else if (str == "n")
                        num = rand.Next(0, 100);
                }
            }
        }
        static void sum()
        {
            int num1,num2;
            int sum = 0;
            Console.Write("숫자 입력 : ");
            string str = Console.ReadLine();
            num1 = Int32.Parse(str);

            Console.Write("숫자 입력 : ");
            str = Console.ReadLine();
            num2 = Int32.Parse(str);

            if (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                    sum += i;
            } 
            else if(num1 > num2)
            {
                for(int i = num2; i <= num1;i++ )
                    sum += i;
            }
            Console.WriteLine("총합 : " + sum);
        }
        static void test7()
        {
            Console.Write("숫자 or 알파벳 입력 : ");
            string str = Console.ReadLine();
            if (str[0] >= 48 && str[0] <= 57)
                Console.WriteLine("숫자");
            else if (str[0] >= 65 && str[0] <= 90)
                Console.WriteLine("대문자");
            else if (str[0] >= 97 && str[0] <= 122)
                Console.WriteLine("소문자");
            else
                Console.WriteLine("숫자,알파벳 입력해주세요");
        }
        static void test9()
        {
            int num;
            int counter = 0;
            Console.Write("숫자 입력 : ");
            string str = Console.ReadLine();
            num = Int32.Parse(str);
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 2; j < num; j++)
                {
                    if (num % j == 0)
                        counter++;
                }
                if (counter >= 1 && i == 1)
                    Console.WriteLine(num + "은 소수아님");
                else if(counter == 0 && i == 1)
                    Console.WriteLine(num + "은 소수아님");
                else if (counter >= 1 && i > 1)
                    Console.WriteLine(num + "은 소수아님");
            }
        }
    }
}
