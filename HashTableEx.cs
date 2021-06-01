using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_HashTable
{
    class HashTableEx
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("boy", "소년");
            ht.Add("girl", "소녀");
            ht.Add("school", "학교");
            Console.WriteLine(ht["boy"]);
            Console.WriteLine(ht["girl"]);
            Console.WriteLine(ht["school"]);

            ht["의적"] = "홍길동";
            Console.WriteLine(ht["의적"]);
        }
    }
}