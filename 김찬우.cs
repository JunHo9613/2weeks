using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_05_24
{
    class Q1
    {

        //1. 정수 10개를 입력받아 배열에 저장하고, 이 정수중에서 3의 배수만 출력하세요

        /*
            
        static void Main(string[] args)
        {
            int[] arr;
            arr = new int[10];

            for(int i=0; i < arr.Length; i++)
            {
                Console.Write("{0} 번째정수 입력 : ", i+1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int j = 0; j < arr.Length; j++)
            {
                if(arr[j] % 3 == 0)
                Console.WriteLine("{0} 번째 번호 3의 배수 출력 : {1}", j+1, arr[j]);
                
            }
        
         */






        //2. 1부터 10까지 곱해서 그 결과를 출력하는 메서드를 만들고 사용하는 프로그램을 작성하세요

        /*
        static int totalMul(int a, int b)
        {
            int total = a;
            for (; a <= b; a++)
            {
                total = a * total;
            }
            return total ;
        }

        static void Main(string[] args)
        {
            int result = totalMul(1, 10);
            Console.WriteLine("result=" + result);
        }
        */





        //3. 2개의 정수를 입력받고 큰 값을 반환하는 메서드와
        //   작은 값을 반환하는 메서드를 작성하고 사용하세요

        /*
        static int MaxNum(int a1, int b1)
        {
            int MaxResult = 0;
            if (a1 > b1)
                MaxResult = a1;
            else if (a1 < b1)
                MaxResult = b1;
            else if (a1 == b1)
                MaxResult = a1;

            return MaxResult;

        }

        static int MinNum(int a2, int b2)
        {
            int MinResult = 0;
            if (a2 > b2)
                MinResult = b2;
            else if (a2 < b2)
                MinResult = a2;
            else if (a2 == b2)
                MinResult = a2;

            return MinResult;
                
        }

        static void Main(string[] args)
        {
            int small = 0, big = 0;
            
            Console.Write("1번째 정수 입력: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("2번째 정수 입력: ");
            int num2 = Int32.Parse(Console.ReadLine());
            
            small = MinNum(num1, num2);
            big = MaxNum(num1, num2);
            Console.WriteLine("두 정수 중 큰 값: {0} 이고 작은 값: {1}", big, small);
        }
        */


        //3. 20개 배열을 선언하세요
        //    20개의 값을 난수를 이용해서 0 ~ 100까지의 값으로 채워넣고
        //    먼저 인덱스의 홀수번째는 앞에서부터 출력하고
        //    짝수번째는 뒤에서부터 출력하세요



        /*static void Main(string[] args)

        {


            int[] arr20;
            arr20 = new int[20];
            Random rand = new Random();
            int randNum = 0;

            for (int i = 0; i < arr20.Length; i++)
            {
                randNum = rand.Next(0, 100);
                arr20[i] = randNum;
            }

            for (int j = 0; j < arr20.Length; j++)
            {
                Console.Write("  {0}", arr20[j]);

            }
            Console.WriteLine();

            for (int odd = 0; odd < 19; odd += 2)
            {
                Console.Write("  {0}", arr20[odd]);
            }

            for (int even = 19; even > 0; even -= 2)
            {
                Console.Write("  {0}", arr20[even]);
            }
            Console.WriteLine();
        }


*/





        //4. AB + BA = 99 를 만족하는 모든 A와 B의 조합을 구하는 프로그램을 작성하세요



        //5. 0~99까지 임의의 수를 생성합니다 -> 0~99 난수
        //   사용자로부터 숫자를 입력받습니다 -> 숫자 입력
        //   사용자가 임의의 수보다 낮은 값을 입력하면 "더 높게"를 출력하고
        //   높은 값을 입력하면 "더 낮게"를 출력합니다
        //   정답을 맞추면 "맞았습니다"를 출력합니다.
        //   y/n을 묻고 y를 입력하면 다시 게임을 진행하고
        //   n을 입력하면 종료합니다

        /*
        static void Main(string[] args)
        {


            int randNum = 0;

            Random rand = new Random();
            randNum = rand.Next(0, 99);

            while (true)
            {


                Console.Write("숫자 입력 : ");
                int inputNum = Int32.Parse(Console.ReadLine());

                if (inputNum < randNum)
                {
                    Console.WriteLine();
                    Console.WriteLine("더 높게!");
                    Console.WriteLine();
                    Console.Write("다시? (y/n) : ");
                    string ask = Console.ReadLine();

                    if (ask == "y")
                        continue;
                    if (ask == "n")
                        break;
                }
                else if (inputNum > randNum)
                {
                    Console.WriteLine();
                    Console.WriteLine("더 낮게!");
                    Console.WriteLine();
                    Console.Write("다시? (y/n) : ");
                    string ask = Console.ReadLine();
                    if (ask == "y")
                        continue;
                    if (ask == "n")
                        break;
                }

                else if (inputNum == randNum)
                {
                    Console.WriteLine();
                    Console.WriteLine("맞았습니다!");
                    Console.WriteLine();
                    Console.Write("다시? (y/n) : ");
                    string ask = Console.ReadLine();
                    if (ask == "y")
                        continue;
                    if (ask == "n")
                        break;
                }
            }

        }
        */






        //6. 두 개의 정수를 입력받습니다.
        //   두 정수를 포함한 사이의 정수의 합을 출력하세요
        //   예를 들면 3과 5를 입력하면 3+4+5의 합을 출력하면 됩니다.

        /* 
         static void Main(string[] args)
         {

             int Max = 0, Min = 0; // a, b 대소 비교하여 각각 넣을 예정

             int[] arr;
             int Total = 0;

             Console.Write("첫번째 숫자 입력 : ");
             int a = Int32.Parse(Console.ReadLine());
             Console.Write("두번째 숫자 입력 : ");
             int b = Int32.Parse(Console.ReadLine());


             if (a > b)
             {
                 Max = a;
                 Min = b;
             }

             else
             {
                 Max = b;
                 Min = a;
             }

             int arrNum = Max - Min + 1;
             arr = new int[arrNum];

             for( int i=0; i < arr.Length; i++)
             {
                 arr[i] = Min + i;
             }

             for (int j=0; j < arr.Length; j++)
             {
                 Total = Total + arr[j];
             }

             Console.WriteLine("{0}에서 {1}의 총합은 {2}입니다.", Min, Max, Total);


         }
        */
        //7. /* 영문자와 숫자를 입력받고
        //   * "대문자", "소문자", "숫자"를
        //   * 판단하는 메서드를 제작하고
        //   * 사용해보세요
        //   * 아스키코드테이블 참조
        //   * */

        // 메서드로 나타내기..
        /*static ChOrInt (string input)
        {
            string str = Console.ReadLine();
            char realCh;
            bool CHK = Char.TryParse(str, out realCh);
            


            if (CHK)
            {
                              
                int num = Convert.ToInt32(realCh);

                Console.WriteLine("아스키 코드: {0}", num);

                if (num >= 97 && num <= 122)
                {
                    Console.WriteLine("숫자가 아닌 소문자입니다.");
                }

                else if (num >= 65 && num <= 90)
                {
                    Console.WriteLine("숫자가 아닌 대문자입니다.");
                }
            }

            if (!CHK)
            {
                Console.WriteLine("숫자입니다.");
            }

            

        }*/




        //8. 두 수를 입력받고 최대 공약수를 출력하세요


        //9. 전달된 값이 소수인지 아닌지 판단하여, 소수인 경우 true를, 소수가 아닌 경우 false를 반환하는 메서드를 정의하고
        //이를 이용해서 1이상 100이하의 소수가 전부 출력할 수 있도록 코드를 구성하세요
        //소수는 1외에 자기자신으로만 나뉘어지는 수입니다


        //10. 구구단을 출력하세요
        //2x1= 2 3x1= 3 4x1= 4... 9x1= 9
        //2x2= 4 3x2= 6 4x2= 8... 9x2= 18...
        //2x9= 18 3x9= 27 4x9= 36... 9x9= 81



        //11. 세개의 정수를 매개변수로 받아서
        //  가장 큰 수를 반환하는 메서드와
        //  가장 작은 수를 반환하는 메서드를 제작해서 사용해보세요

        /* static int threeMax(int[] numArr) // 3개중 최대값
         {
             int result = 0;
             if (numArr[0] > numArr[1] && numArr[0] > numArr[2])
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

         static int threeMin(int[] numArr) // 3개중 최소값
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
             int[] numArr4 = new int[3];
             for (int i = 0; i < numArr4.Length; i++)
             {
                 Console.WriteLine(i + "번째 정수 입력(총3개): ");
                 numArr4[i] = Int32.Parse(Console.ReadLine());
             }

             Console.Write("큰수:" + threeMax(numArr4));
             Console.Write("작은수:" + threeMin(numArr4));
         }
     }
 }*/


        //12. 사용자로부터 초를 입력받은 후
        //  이 초를 [시간, 분, 초] 로 출력하는 메서드를 제작해서
        //  사용해보세요
        //  예를 들어 3672를 입력하면 [1시간, 1분, 12초]를
        //  출력하면 됩니다.
       /* static int[] TimeDisplay(int TotalSec)
        {
            int[] timeD = new int[3];
            int Hour = TotalSec / 3600;
            int Min = TotalSec % 3600 / 60;
            int Sec = TotalSec - Hour * 3600 - Min * 60;
            Hour = timeD[0];
            Min = timeD[1];
            Sec = timeD[3];
             return timeD;
        }

        static void Main (string[] args)
        {
            Console.WriteLine("초 입력:");
            int TotalT = Int32.Parse(Console.ReadLine());
            int[] timeArr = TimeDisplay(TotalT);
            Console.WriteLine("{0}시간, {1}분, {2}초", timeArr[0], timeArr[1], timeArr[2]);

        }

*/
    }
}
//11,12 풀이




