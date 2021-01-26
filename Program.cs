/*
 Author: Mark Haxton
 Date: 1/26/2021
 Comments: This C# Console application is part 2 of week 3 assignment, practice iteration/loop
*/

using System;

namespace ClassProjectDeliverable2IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Enter an integer value between 1 and 100...");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather the user input
                Console.Write("INPUT: ");
                string input = Console.ReadLine();
                /* 
                   This variable will be used to store the integer
                   after the input variable is parsed to decimal
                 */
                decimal integer = decimal.Parse(input);

                // the following tests for the correct integer entry value range

                if ((integer < 1) || (integer > 100))
                {
                    Console.WriteLine("The number entered is not between 1 and 100, please try again.");
                }
                // the following is the while loop

                else // if integer is between 1 and 100)
                    Console.WriteLine(" ");
                    Console.WriteLine("OUTPUT: ");
                {
                    int count = 1; // set the counter to 1
                    while (count <= integer) // this is the count up to the entered value ticker
                    {
                        Console.WriteLine(" ");  // adds a blank line
                        // this line prints the output.
                        Console.WriteLine("You have entered " + integer + "." + "This is the current integer value in the loop: " + count);
                        count = count + 1; // adds one to count to increment by 1 each loop
                    } // end of counter
                } //end of if and loop statements
            } // end of try
            catch // The catch entry errors portion.
            {
                Console.WriteLine("Please use an integer for your choice next time...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // end of catch     
        } // end of Main
    } // end of class
} // end of namespace


