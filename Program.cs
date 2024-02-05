/*
 * Author: Magaly Rodriguez
 * Course: COMP 003A
 * Purpose: Assigment 3: conditional statements for letter grades, and day of the week
 */

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeric to letter grade using an if-else statement");
            Console.WriteLine("Enter a numeric grade (0-100):");

            string gradeInput = Console.ReadLine();
            double numericGrade = Convert.ToDouble(gradeInput); //converts string to double 



            if (numericGrade >= 0 && numericGrade <= 100) //if condition for numbers 0-100; else will return invalid input
            {

                if (numericGrade >= 90)
                {
                    Console.WriteLine("Letter Grade: A");
                }

                else if (numericGrade >= 80)
                {
                    Console.WriteLine("Letter Grade: B");
                }

                else if (numericGrade >= 70)
                {
                    Console.WriteLine("Letter Grade: C");
                }

                else if (numericGrade >= 60)
                {
                    Console.WriteLine("Letter Grade: D");
                }

                else
                {
                    Console.WriteLine("Letter Grade: F");
                }
            }

            else
            {
                Console.WriteLine("Invalid input!");
            }

            Console.WriteLine("*************************************************");
            Console.WriteLine("Integer to string day using a switch statement");
            Console.WriteLine("Enter an integer day of the week (1-7): ");

            string integerInput = Console.ReadLine();
            int numericDay = Convert.ToInt32(integerInput); //converts string to int

            switch(numericDay)
            {
                case 1:
                    Console.WriteLine("String Day: Monday");
                    break;

                case 2: 
            }


        }
             


    }
}
