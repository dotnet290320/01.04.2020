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



            // 1 not prime
            // 5 [a]
            // 2 --> 5 [a] 
            // while indexer modolu != 0 -> proceed
            //   a   indexer
            //   5 %    2   != 0 
            //   5 %    3   != 0
            //   5 %    4   != 0
            //   5 %    5   == 0
            // 
            //   5 == 5 ?  a == indexer ? is prime
            //
            //  9 [a]
            // 2 --> 9 [a]
            //   a     indexer
            //   9  %  2     != 0
            //   9  %  3     == 0 
            //  3  == 9 ? a == indexer ? NOT -- not prime

            // indexer = 2
            // while (number % indexer != 0) -- indexer is not a value which the number could divide without reminder
            // {
            //    indexer++;
            // }
            // if (indexer == number) ? yes: prime no:not-prime

            int number = 0;
            string input_from_user = "hello";
            do
            {
                Console.WriteLine("Enter number:");
                input_from_user = Console.ReadLine();
            }
            while (int.TryParse(input_from_user, out number) == false); // is input-valid == false?

            int indexer = 2;
            while (number % indexer != 0 && indexer < number)
            {
                indexer++;
            }
            if (indexer == number)
            {
                Console.WriteLine($"{number} is a prime number");
            }
            else
            {
                Console.WriteLine($"{number} is NOT a prime number");
            }


            number = 0;
            input_from_user = "hello";
            do
            {
                Console.WriteLine("Enter number (again):");
                input_from_user = Console.ReadLine();
            }
            while (int.TryParse(input_from_user, out number) == false); // is input-valid == false?

            // same as while 
            int i = 0;
            for (i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"not a prime number");
                    break;
                }
            }
            if (i == number)
            {
                Console.WriteLine($"{number} is a prime number");
            }

        }
    }
}
