using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_AddressClass
{
    class AddressManager
    {
        ArrayList arrayList = new ArrayList();

        public void initAddress()
        {
            Console.Write("초기화");
        }
        public void insertAddress()
        {

            Console.WriteLine("초기화");
            Console.Write("이름 입력 >>");
            string name = Console.ReadLine();
            Console.Write("전화 입력 >>");
            string phone = Console.ReadLine();
            Console.Write("주소이름 입력 >>");
            string addr = Console.ReadLine();

            Address address = new Address();
            address.Name = name;
            address.Phone = phone;
            address.Addr = addr;

            arrayList.Add(address);

        }
        public static void searchAddress()
        {
            Address address = searchAddress("주소 검색");
            if (address != null)

                address.showInfo();
            else
                Console.WriteLine("검색 대상이 없습니다...");

            address.showInfo();
            Console.ReadLine();
        }
        public Address searchAddress()
        {

            Console.WriteLine("--------{0}--------", title);
            Console.WriteLine("검색할 이름 입력 >>");
            string name = Console.ReadLine();
            for (int i = 0; i < arrayList.Count; i++)
            {
                Address address = (Address)arrayList[i];
                if (address.Name == name)
                {
                    return address;
                }
            }
            return null;
            Console.Write("주소 검색");
        }
        public void updateAddress()
        {
            Address address = searchAddress("주소 수정");
            if (address != null)
            {
                Console.Write("수정 이름:");
                string name = Console.ReadLine();
                Console.Write("수정 전화:");
                string phone = Console.ReadLine();
                Console.Write("수정 주소:");
                string addr = Console.ReadLine();
                address.Name = name;
                address.Phone = phone;
                address.Addr = addr;
                address.showInfo();
            }
            else
                Console.Write("수정 대상이 없습니다.:");

            Console.ReadLine();
            Console.Write("주소 수정");
        }
        public void deleteAddress()
        {
            Address address = searchAddress("주소 삭제");
            if (address != null)
            {
                address.showInfo();
                Console.Write("진짜 삭제하시겠습니까?");
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")

                    arrayList.Remove(address);

                else
                    Console.WriteLine("삭제 취소");
            }
            else
                Console.WriteLine("삭제 대상이 없습니다.");
            Console.Write("주소 삭제");
        }
        public void printAllAddress()
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Address address = (Address)arrayList[i];
                address.showInfo(i + 1);
            }
            Console.ReadLine();

        }
        public void programExit()
        {

            AddressFile.saveFileAddress(arrayList);
            Console.Write("프로그램 종료");
            Console.ReadLine();
        }
    }
}
