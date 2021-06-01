using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HomeWork_01
{
    class chinese_Restaurant
    {
        private string[] foods = { "짜장면", "짬뽕", "탕수육", "깐풍기", "1인 세트" };
        private string selFood = " ";
        private int select;

        public void QuestionOrder()
        {
            for(int i=0;i<foods.Length;i++)
            {
                Console.WriteLine("{0}.{1}",i,foods[i]);
            }
        }
        public void SelectFood()
        {
            Console.WriteLine(" 메뉴를 선택해주세요.");
            select = Int32.Parse(Console.ReadLine());
            selFood = foods[select];
        }

        public void DeliveryFood()
        {
            Console.WriteLine(" {0} 나왔습니다.", selFood);
            Console.WriteLine(" 맛있게 드세요~!~! ");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            chinese_Restaurant rest = new chinese_Restaurant();
            rest.QuestionOrder();
            rest.SelectFood();
            rest.DeliveryFood();
        }
    }
}
