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

            // 1 create generator engine for random numbers (only once)
            // Random [name-i-give-to-engine] = new Random();
            Random rnd_generator = new Random(); // chinese

            // 2 to generate a number use Next
            // [name-i-give-to-engine].Next(maxValue);
            // [name-i-give-to-engine].Next(minValue, maxValue);
            int random_number1 = rnd_generator.Next(1, 100);


            while (true)
            {

                // read number from user
                int number = 0;
                string input_from_user = "hello";
                do
                {
                    Console.WriteLine("guess number:");
                    input_from_user = Console.ReadLine();
                }
                while (int.TryParse(input_from_user, out number) == false); // is input-valid == false?

                if (number == random_number1)
                {
                    Console.WriteLine($"Correct! the number was {number}");
                    break;
                }

                if (number > random_number1)
                {
                    Console.WriteLine("your number is too big...");
                    continue;
                }

                Console.WriteLine("your number is too small...");
            }

            // .....

        }
    }
}
