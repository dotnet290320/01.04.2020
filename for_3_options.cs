using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0104
{
    class Program
    {
        static void Main(string[] args)
        {

            // print the numbers from 1 to 10
            // mone = 1
            // while (mone < 10) .. +1 // == for (; mone < 10 ;) 
            // { }

            // for - loop
            // 1. can create variables inside the loop
            // 2. add increment inside decleartion , what is the jumping rate
            // 3. first value in decleration
            // 4. condition could be complicated
            int number = 0; 

            for (int i = 1; i <= 5; i = i + 2)
            {
                //if (i == 2)
                //    continue;
                //int.TryParse(Console.ReadLine(), out number);

                Console.WriteLine($"i : {i}");

            }

            // order of operations [while]
            //for ( [1] int i = 1; [4, 8, 11 ...] i < 5; [3, 6, 7, 10 ...] i++)
            //{ [2, 5, 7 ...]
                // ...............
            //}

            // 1 while [condition will be checked before 1st iteration]
            // 2 do-while [condition will be checked after 1st iteration]
            // 3 for [run over sequence of numbers with similar gap "jump"] 
            // ?
        }
    }
}
