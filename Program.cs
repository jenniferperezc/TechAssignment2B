using System;
using System.Security.Claims;

namespace TechAssignment2B
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for inout
            Console.WriteLine("Please enter desired grade...");
            /*
             Try catch block to validate user input.
             If the user provides bad input, the catch block
             will handle the error and a message will be displayed. 
            */
            try
            {
                //This varibale will gather the user input
                string input = Console.ReadLine();
                /*
                 This variable will be used to store grades
                 after the input variable is parsed to integers 
                */

                int grade = int.Parse(input);

                /* 
                    IF/ELSE IF/ELSE statement is used to conditionally test the user input. 
                    Depending on the amount the user entered a letter grade will be displayed.
                */
                if (grade >= 90)
                {
                    Console.WriteLine("Your letter grade will be A");
                }
                else if ((grade >= 80) && (grade < 90))
                {
                    Console.WriteLine("Your letter grade will be B");
                }
                else if(( grade >= 70) && ( grade < 80))
                {
                    Console.WriteLine("Your letter grade will be C");
                }
                else if(( grade >= 60) && ( grade < 70))
                {
                    Console.WriteLine("Your letter grade will be D");
                }
                else if ( grade < 60)
                {
                    Console.WriteLine("Your letter grade will be F");
                }// end of IF
            }// end of TRY
            catch
            {
                Console.WriteLine("Please use an integer data type...");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
            }
        }
    }
}
