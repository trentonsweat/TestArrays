using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrays
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] FirstExamGrades = new int[9]; //create new array

            for (int i = 0; i <= FirstExamGrades.Length-1; i++) // use for loop to count/increment multiple elements (students) the i equals the index
            {
                Console.WriteLine("Please enter a grade"); // asks for input

                FirstExamGrades[i] = int.Parse(Console.ReadLine()); // Parses the int index (i), reads the input, then returns the input

            }

            //sum all the elements of the array

            int Sum = 0; // initiate sum to zero 

            for (int i = 0; i <= FirstExamGrades.Length - 1; i++) // use for loop to add each element each time it loops 
            {

                Sum = Sum + FirstExamGrades[i]; // take sum (0) and add index (i) to it 

            }

            //find the largest element in the array

            int LargestElement = FirstExamGrades[0]; // assuming zero is the largest number 
            int SmallestElement = FirstExamGrades[0]; // assuming zero is smallest number

            for (int i = 0; i <= FirstExamGrades.Length - 1; i++) // for loop with nested if statement to calculate largest  and smallest number
            {

                if (FirstExamGrades[i] > LargestElement) // if statement analayzes index starting at zero 
                    LargestElement = FirstExamGrades[i]; // if one index is larger then output it 

                if (FirstExamGrades[i] > SmallestElement) // if statement analayzes index starting at zero 
                    SmallestElement = FirstExamGrades[i]; // if one index is smaller then output it 

            }

            //find the index of the largest element in the array (a little different from the actual element)
            int LargestIndex = 0;
            LargestElement = FirstExamGrades[0];
            // Find the index of the largest element
            for (int i = 0; i <= FirstExamGrades.Length - 1; i++)
            {
                if (FirstExamGrades[i] > LargestElement)
                    LargestIndex = i;
            }










            //for (int i = 0; i < FirstExamGrades.Length; i++)
            //{



            //}


        }
    }
}
