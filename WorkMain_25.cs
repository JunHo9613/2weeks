using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_05_25_HomeWork_Done
{
    class Studnet
    {

    }
    class ChinaFoods
    {
        private string[] foods = { "짜장면", "짬뽕", "탕수육", "마파두부", "울면", "깐풍기", "exit" };

        public void Foods()
        {
            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine(i + " " + foods[i]);
            }
        }
        public void OderMenu()
        {


            while (true)
            {
                Foods();
                Console.Write("주문을 하시려면 해당하는 번호를 입력하십시오: ");
                int a = Int32.Parse(Console.ReadLine());
                if (a == 6)
                {
                    Console.Clear();
                    Console.WriteLine("주문을 종료합니다.");
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine(foods[a] + "이/가 나왔습니다.");

                }
                Console.WriteLine("더 주문 하시겠습니까? (y/n): ");
                string str = Console.ReadLine();
                if (str == "n")
                {
                    Console.WriteLine("감사합니다. 또 오세요.");
                    break;
                }
                else if (str == "y")
                {
                    Console.Clear();
                }
            }
        }

        public void China()
        {
            OderMenu();
        }
    }
    class WorkMain_25
    {
        static void Time(int a)
        {
            int hour = 0, min = 0, sec = a;

            min = sec / 60;
            hour = min / 60;
            sec = sec % 60;
            min = min % 60;
            Console.WriteLine("{0}시 {1}분 {2}초", hour, min, sec);
        }
        //5.Array.Sort를 사용해서 오름차순 정렬하세요
        static void CopyArr()
        {
            //2. 2개의 새로운 int배열을 할당하고
            int[] num0 = new int[5];
            int[] num1 = new int[5];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                num0[i] = rand.Next(0, 10);
                num1[i] = num0[i];
            }
            for (int i = 0; i < num0.Length; i++)
            {
                Console.WriteLine("기존 배열" + num0[i]);
            }
            Console.WriteLine("-----------------------------------------------");
            //   값을 복사하세요
            for (int i = 0; i < num1.Length; i++)
            {

                Console.WriteLine("복사 배열" + num1[i]);
            }
            Console.WriteLine("-----------------------------------------------");
            //3. Array.Sort를 사용해서 오름차순 정렬하세요
            for (int i = 0; i < num0.Length; i++)
            {
                Array.Sort(num0);
                Console.WriteLine("오름차순 정렬: " + num0[i]);

            }
            Console.WriteLine("-----------------------------------------------");
            //4. 정렬을 하고 내림차순으로 출력하세요
            for (int i = 0; i < num1.Length; i++)
            {
                Array.Sort(num1);
                Array.Reverse(num1);    //내림차순을 위해서는 먼서 오름차순으로 정렬후 반대로 정렬해주면 된다.
                Console.WriteLine("내림차순 정렬: " + num1[i]);
            }
        }
        static void guguDan()
        {
            int[,] gugu = new int[8, 9];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    gugu[i, j] = (i + 2) * (j + 1);
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0, 2} ", gugu[j, i]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            //1.사용자로부터 초를 입력받은 후
            //이 초를[시간, 분, 초]로 출력하는 메서드를 제작해서 사용해보세요
            //예를 들어 3672를 입력하면[1시간, 1분, 12초]를 출력하면 됩니다.
            /*Console.WriteLine("초를 입력하시면 시간 분 초로 바꾸어 드립니다.");
            Console.Write("초 입력: ");
            int sec = Int32.Parse(Console.ReadLine());
            Time(sec);*/

            //2.구구단을 출력하세요
            //2x1 = 2 3x1 = 3 4x1 = 4... 9x1 = 9
            //2x2 = 4 3x2 = 6 4x2 = 8... 9x2 = 18...
            //2x9 = 18 3x9 = 27 4x9 = 36... 9x9 = 81
            //guguDan();

            //3.중화요리집을 임의대로 클래스로 자유롭게 만드세요
            ChinaFoods china = new ChinaFoods();
            //china.China();

            //4.학생이 아침에 일어나서 준비하고
            //  공부하다 가는 일과를 클래스로 자유롭게 만드세요.

            //5.Array.Sort를 사용해서 오름차순 정렬하세요
            //6.정렬을 하고 내림차순으로 출력하세요
            //CopyArr();

            Triangle tri = new Triangle();
            /*tri.updateBaseHight(1, 2);;
            
            Console.WriteLine(tri.TriArea(10, 20));*/

            song sg = new song();
            sg.setSongIngo("dancing queen", "ABBA", "어라이벌", 1976, 2);
            //sg.Show();

            Rectangle rec = new Rectangle();
            Rectangle rec1 = new Rectangle();
            rec.set(4, 6, 8, 3);
            rec1.set(4, 6, 8, 3);
            rec.show();
            rec1.show();

            Console.WriteLine(rec.equals(rec1));

            /*Work4_25_1 work4_1 = new Work4_25_1();
            Buyer buyer = new Buyer(10000);
            Seller seller = new Seller(2500, 10);
            *//*buyer.buy(seller, 2500);
            buyer.show();*//*

            Work4_25_2 work4_2 = new Work4_25_2();
            PenSeller penseller = new PenSeller(1500);
            PenBuyer penbuyer = new PenBuyer(7000);
            *//*penbuyer.BuyPen(penseller, 5500);*//*

            penbuyer.show();*/
        }
    }
}
