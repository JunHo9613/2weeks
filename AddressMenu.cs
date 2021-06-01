using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_AddressClass
{
    class AddressMenu
    {
        AddressManager addressManager = new AddressManager();
        
        public void initAddress()
        {

        }

        public void mainLoop()
        {
            addressManager.initAddress();

            bool isRun = true;
            while (isRun)
            {
                clearScreen();
                printMenu();
                int sel = selectMenu();

                clearScreen();
                switch (sel)
                {
                    case 1:
                        addressManager.insertAddress();
                        break;
                    case 2:
                        addressManager.searchAddress();
                        break;
                    case 3:
                        addressManager.updateAddress();
                        break;
                    case 4:
                        addressManager.deleteAddress();
                        break;
                    case 5:
                        addressManager.printAllAddress();
                        break;
                    case 6:
                        addressManager.programExit();
                        isRun = false;
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
        }
        public void printMenu()
        {
            Console.WriteLine("1.주소 입력");
            Console.WriteLine("2.주소 검색");
            Console.WriteLine("3.주소 수정");
            Console.WriteLine("4.주소 삭제");
            Console.WriteLine("5.주소 전체 출력");
            Console.WriteLine("6.종료");
        }
        public int selectMenu()
        {
            int sel = 0;
            Console.Write("메뉴 선택 >> ");
            sel = Int32.Parse(Console.ReadLine());
            return sel;
        }

        public static void clearScreen()
        {
            Console.Clear();
        }
    }
}
