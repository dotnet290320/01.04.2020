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

            bool bool1 = true;// 1; // true or false
            bool1 = false;
            bool1 = !bool1; // true --> false, false --> true

            int x = 5 + 1; // 6
            bool cond1 = x > 2; // true? or false?
            // if (bool)
            // out means the function will 100% return a value into this argument [unless crash]
            // int tar3_1; // no need
            if (int.TryParse("5", out int tardemo)) // int.TryParse("5", out int tar3_1) == true
            {
                // true
                // can parse to int
                // tardemo will have the paresedn string 
            }
            else
            {
                // false
                // cannot parse to int
            }
            Console.WriteLine(tardemo); // can access

            //int val1 = Convert.ToInt32(Console.ReadLine()); // exception

            //Console.WriteLine("enter 2 numbers for reminder check");

            // "123" --> 123
            // float.TryParse "1.8" --> 1.8f

            // int.TryParse(Console.ReadLine(), out int tar3_1)
            // 1) read number/string from keyboard 
            // 2) try to convert the input to an integer number
            // 3) define int varaibale named tar3_1
            // 4) if success return true + parsed number will be inside tar3_1
            // 5) if failed return false

            // "abc"
            if (int.TryParse(Console.ReadLine(), out int tar3_1) && int.TryParse(Console.ReadLine(), out int tar3_2))
            {
                if (tar3_1 == 0 || tar3_2 == 0)
                {
                    Console.WriteLine("cannot divide by zero"); // 0 / 8 -- 0
                }
                else if (tar3_1 > tar3_2)
                {
                    if (tar3_1 % tar3_2 == 0)
                    {
                        Console.WriteLine($"{tar3_1} / {tar3_2} without reminder");
                    }
                    else
                    {
                        Console.WriteLine($"{tar3_1} / {tar3_2} with reminder");
                    }
                }
                else
                {
                    if (tar3_2 % tar3_1 == 0)
                    {
                        Console.WriteLine($"{tar3_2} / {tar3_1} without reminder");
                    }
                    else
                    {
                        Console.WriteLine($"{tar3_2} / {tar3_1} with reminder");
                    }
                }
            }

            // 8 x 3
            // 8 + 8 + 8

            if (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b))
            {
                int sum = a + b;
                double avg = sum / 2.0;
                Console.WriteLine($"sum : {sum} , avarege : {avg}");
            }
        }
    }
}
