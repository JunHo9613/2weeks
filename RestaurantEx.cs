using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_classRestaurant
{
    class Restaurant
    {
        // 필드는 기본권한을 private

        private string[] foods =
            {"냉면","칼국수","쌀국수","떡볶이","순대","튀김"};
        private string selfood = "";
        private int select = 0;

        // 메서드는 기본권한을 public
        public void questionOrder()
        {
            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i, foods[i]);
            }
        }
        public void selectFood()
        {
            Console.Write("어느 음식을 선택하실래요?");
            select = Int32.Parse(Console.ReadLine());
            selfood = foods[select];
        }
        public void deliveryFood()
        {
            Console.WriteLine("{0}이 나왔습니다", selfood);
            Console.WriteLine("맛있게 드세요 ^^");
        }
    }
    class RestaurantEx
    {
        static void Main(string[] arg)
        {
            Restaurant rest = new Restaurant();

            rest.questionOrder();
            rest.selectFood();
            rest.deliveryFood();

        }
    }
}
