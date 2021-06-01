using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_classToClass
{
    class FruitBuyer
    {
        string name;
        int myMoney = 0;
        int numOfApple = 0;

        public FruitBuyer(string name, int money)
        {
            this.name = name;
            this.myMoney = money;
        }
        public void buyApple(FruitSeller seller, int money)
        {
            this.numOfApple += seller.saleApple(money);
            this.myMoney -= money;
        }
        public void showBuyResult()
        {
            Console.WriteLine("=======구매자 : {0}=======", this.name);
            Console.WriteLine("현재 잔액 : " + this.myMoney);
            Console.WriteLine("사과 개수 : " + this.numOfApple);
        }
    }
}
