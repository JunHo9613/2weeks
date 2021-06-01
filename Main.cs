using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_classToClass
{
    class Buyer
    {
        string name;
        int myMoney = 0;
        int numOfPear = 0;

        public Buyer(string name, int money)
        {
            this.name = name;
            this.myMoney = money;
        }
        public void Buyer1(string name, int money)
        {
            this.name = name;
            this.myMoney = money;
        }
        public void buyApple(Seller seller, int money)
        {
            this.myMoney -= money;
        }
        public void showBuyResult()
        {
            Console.WriteLine("손님은 배를" + this.name+ "원을 주고");
            Console.WriteLine("거스름돈 " + this.myMoney +" 을 받았다. ");

        }
    }
    class Seller
    {
        string name;

        int myMoney;    // 보유한 돈
        readonly int APPLE_PRICE;  // 사과가격

        public Seller(string name, int money)
        {
            this.name = name;

            this.myMoney = money;

        }
        public int saleApple(int money)
        {
            int num = money;
 
            this.myMoney -= money;
            return num;
        }
        
    }
    class Basic
    {
        static void Main(string[] args)
        {
            Buyer buyer = new Buyer("손님", 5000);
            Seller seller = new Seller("사장", 2500);

            buyer.Buyer1(Buyer, 2500);
            buyer.buyApple(seller, 2500);
            buyer.showBuyResult();
        }
    }
}
