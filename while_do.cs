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

            Console.WriteLine(8/4); // 2
            Console.WriteLine(9/4); // 2 {int} / {int} == {int} 2.25 --> 2
            Console.WriteLine(9/4.0);
            Console.WriteLine(9/Convert.ToDouble(4));

            // ---------------------- loop example (while)
            // print numbers from 1 to 4 
            //int mone1 = 0;
            //while (mone1 < 4)
            //{
            //    mone1++;
            //    Console.WriteLine(mone1);
            //}


            // ---------------------------------while do while------------------------------------------------
            // while -- duplicate code 
            /*
            int num_of_students = 0;

            Console.WriteLine("please enter the number of students");

            while (int.TryParse(Console.ReadLine(), out num_of_students) == false)
            {
                Console.WriteLine("please enter the number of students");
            }
            */

            // do-while -- without duplicate code 
            int num_of_students = 0;
            do // first iteration occurs and only then condition is checked
            {
                Console.WriteLine("please enter the number of students");
            }
            while (int.TryParse(Console.ReadLine(), out num_of_students) == false);
            // ---------------------------------------------------------------------------------

            // 1
            // loop logic 
            // teacher wants to calc avg grade of class
            // readline number of students
            // for each student readline his greade
            // sum = sum + grade ...
            // avg = sum / number-of-students
            int mone = num_of_students;
            int sum = 0;
            while (mone > 0) // condition is checked before 1st iteration
            {

                Console.WriteLine($"please enter student grade");

                if (int.TryParse(Console.ReadLine(), out int student_grade))
                {
                    sum = sum + student_grade;
                }
                else
                {
                    Console.WriteLine("wrong grade");
                    continue;
                }

                mone--; // mone = mone - 1;
                // mone++; // mone = mone + 1
            }

            double avg = sum / Convert.ToDouble(num_of_students);

            Console.WriteLine($"Statistics: number of students : {num_of_students} average : {avg}");


            // 2
            // loop logic 
            // teacher does not know how many students in class
            // teacher will enter grades until a negative grade will be input
            // do-while -- without duplicate code 
            int ex2_num_of_students = 0;
            int ex2_sum = 0;
            while (true)
            {
                Console.WriteLine($"please enter student grade");

                if (int.TryParse(Console.ReadLine(), out int student_grade))
                {
                    if (student_grade < 0)
                        break; // jumps out of loop 

                    ex2_sum = ex2_sum + student_grade;
                    ex2_num_of_students++;
                }
                else
                {
                    Console.WriteLine("wrong grade");
                    continue;
                }
            }
           
            double ex2_avg = ex2_sum / Convert.ToDouble(ex2_num_of_students); // 90.5

            Console.WriteLine($"Statistics: number of students : {ex2_num_of_students} average : {ex2_avg}");


        }
    }
}
