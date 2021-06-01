using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataType
{
    class DataTypes
    {
        // System.Int32 num0 = 10           
        // System.double dNum = 3.14;                   
        // System.char ch = 'a';                          
        // System.string name = "albert";


        // 변수 : 값을 저장하는 이름붙인 공간
        // 자료형(DataType) : 변수를 만들때 사용하는 약속 기호 
        // 관습 - 많이 쓰는 자료형 
        static void Main(string[] args)
        {
            int num = 100;                          // 정수
            double dNum = 3.14;                     // 실수(소수점)
            char ch = 'a';                          // 문자
            string name = "albert";                 // 문자열
            Console.WriteLine("{0}, {1}, {2}, {3}", num, dNum, ch, name);
        }
    }
}
