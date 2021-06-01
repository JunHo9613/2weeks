using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_classToClass
{
    class FruitSeller
    {
        string name;
        int numOfapple; // 과일 개수
        int myMoney;    // 보유한 돈
        readonly int APPLE_PRICE;  // 사과가격

        public FruitSeller(string name, int money, int appleNum, int price)
        {
            this.name = name;
            this.numOfapple = appleNum;
            this.myMoney = money;
            this.APPLE_PRICE = price;
        }
        public int saleApple(int money)
        {
            int num = money / this.APPLE_PRICE;
            this.numOfapple -= num;
            this.myMoney += money;
            return num;
        }
        public void showSaleResult()
        {
            Console.WriteLine("=======판매자 : {0}=======", this.name);
            Console.WriteLine("남은 사과 : " + this.numOfapple);
            Console.WriteLine("판매 수익 : " + this.myMoney);
        }
    }
}
