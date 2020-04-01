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

            // 
            // 0! = 1

            // A -- 1
            // 1! = 1

            // 0 A -- 2

            // 0 A
            // A 0
            // 2! = 1 x 2 = 2

            // 0 A B -- 3 = 3! = 3 x 2 x 1 = 6

            // 0 A B
            // 0 B A
            // A 0 B
            // A B 0
            // B A 0
            // B 0 A

            int number = 0;
            // scope
            do
            {
                Console.WriteLine("Enter number for factorial");

            }
            while (int.TryParse(Console.ReadLine(), out number) == false); // out int number -- scope inside loop only

            // 5 (number)
            // 1 x 2 x 3 x 4 x 5
            // before loop atz = 1
            // loop 1 -> 5 (number)
            // loop: 
            // atz = atz * index++
            // 0! = 1
            // 1! = 1 x 1
            // 2! = 1 x 2 = 2
            // 3! = 1 x 2 x 3 = 6
            int atz = 1;
            for (int i = 2; i <= number; i++)
            {
                atz = atz * i;
            }
            Console.WriteLine($"{number}! = {atz}");

        }
    }
}
