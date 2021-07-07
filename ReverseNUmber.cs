using System;
using System.Collections.Generic;
using System.Text;

namespace D6LogicalProblems
{
    class ReverseNUmber
    {
        public static void checkReverseNumber()
        {
            // variables
            int rem = 0;
            int rev = 0;

            // taking user input 
            Console.WriteLine("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());


            while (number != 0)
            {
                rem = number % 10;
                rev= rev * 10 + rem;
                number = number / 10;
            }

            Console.WriteLine(" Reverse number is : " + rev);
            
        }
    }
}
