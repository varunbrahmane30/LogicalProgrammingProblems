using System;
using System.Collections.Generic;
using System.Text;

namespace D6LogicalProblems
{
    class PerfectNumber
    {
        public static void calPerfectNumber()
        {
            // variables
            long  sum = 0;
            int i = 1;

            //taking user input number
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
           
           
            // implementation
            while (i <= number / 2)
            {
                if (number % i == 0)
                { 
                    sum = sum + i;
                } 
                i++;
            } 
            if (sum == number)
            {

                Console.WriteLine(number + " is a perfect number.");
            }  
            else
                 
                Console.WriteLine(number + " is not a perfect number.");
        }
    }
}

