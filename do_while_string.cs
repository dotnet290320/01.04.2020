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

            int number = 0;
            string input_from_user ="hello";
            input_from_user = "1";

            // readline a string from the user
            // if the string could NOT be parsed to int --> do it again
            // a9
            do
            {
                Console.WriteLine("Enter number:");
                input_from_user = Console.ReadLine();
            }
            while (int.TryParse(input_from_user, out number) == false); // is input-valid == false?

            //do
            //{
                // code to be done
            //}
            //while (what is the condition to do the loop again)

            // .... input is valid

        }
    }
}
