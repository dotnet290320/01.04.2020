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

            int a = 0;
            do
            {
                Console.WriteLine("Enter first numberl");
            }
            while (int.TryParse(Console.ReadLine(), out a) == false);

            int b = 0;
            do
            {
                Console.WriteLine("Enter 2nd numberl");
            }
            while (int.TryParse(Console.ReadLine(), out b) == false);

            // a [6] , b [4]
            // sum = 0
            // for 1 -> 4 [b]
            //    sum = sum + 6 [a]
            //    6 + 6 + 6 + 6 = 24
            int sum = 0;
            for (int i = 1; i <= b && a > 0 && b > 0; i++)
            {
                sum = sum + a;
            }
            Console.WriteLine($"{a} x {b} = {sum}");

        }
    }
}
