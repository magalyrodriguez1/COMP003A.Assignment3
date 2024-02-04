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
            double numericGrade = Convert.ToDouble(gradeInput);
                   
            if (numericGrade >= 0 && numericGrade <= 100)
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
    }
}
