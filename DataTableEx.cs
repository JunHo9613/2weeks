using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_DateTime
{
    class DataTableEx
    {
        static void Main(string[] args)
        {
            DateTime dtA = new DateTime(2010, 8, 29);
            DateTime dtB = new DateTime(2021, 5, 25);
            // 두 날짜 사이의 차이
            TimeSpan tsC = dtB - dtA;
            Console.WriteLine(tsC);

            // 1000일 후 날짜는?
            dtA = new DateTime(2021, 5, 25);
            tsC = new TimeSpan(1000, 0, 0, 0);
            dtB = dtA + tsC;
            Console.WriteLine(dtB);

        }
    }
}
