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

            int sum = 0;

            do
            {
                int number = 0;

                do
                {
                    Console.WriteLine("Enter number:");
                }
                while (int.TryParse(Console.ReadLine(), out number) == false);

                if (number < 0)
                    break;

                sum = sum + number;
            }
            while (true);

            Console.WriteLine($"sum : {sum}");

        }
    }
}
