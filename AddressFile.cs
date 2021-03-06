using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_AddressClass
{
    class AddressFile
    {
       
        AddressFile addrFile = new AddressFile();
        ArrayList arrayList = new ArrayList();

        void loadFileAddress(ArrayList arrayList)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader("address.txt");
                Address address = null;
                int step = 0;
                while (sr.Peek() >= 0)  //읽을 내용이 있다.                    
                {
                    string str = sr.ReadLine();
                    if (step == 0)
                    {
                        address = new Address();
                        address.Name = str;
                        step++;
                    }
                    else if (step == 1)
                    {
                        address.Phone = str;
                        step++;
                    }
                    else if (step == 2)
                    {
                        address.Addr = str;
                        step++;
                    }
                    else
                    {
                        step = 0;
                        arrayList.Add(address);
                    }
                }
            }
            catch (Exception e) // 예외 에러를 잡는다
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally // 정상, 예외든 무조건 마무리한다.
            {
                if (sr != null)
                    sr.Close();
            }
        }
    }

    private void saveFileAddress(ArrayList arrayList)
    {
        StreamWriter sw = new StreamWriter("Address.txt");
        for (int i = 0; i < arrayList.Count; i++)
        {
            Address address = (Address)arrayList[i];
            sw.WriteLine(address.Name);
            sw.WriteLine(address.Phone);
            sw.WriteLine(address.Addr);
            sw.WriteLine();
        }

        Console.WriteLine("");
    }
}
