using System;
using System.Collections.Generic;
using System.Text;

namespace D6LogicalProblems
{
	class PrimeNumber
	{
		public static void checkPrimeNUm()
		{
            // variables
            int i = 2;
            int count = 0;

            // taking user input 
            Console.WriteLine("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());

            // implementation 
            while (i <= number / 2)
            {
                // condition for nonprime number
                if (number % i == 0)
                {
                    count++;
                    break;
                }

                ++i;
            }

            if (count != 0)
                Console.WriteLine(number + " is not a prime number.");
            else
                Console.WriteLine(number + " is  a prime number.");
        }
    }
			
}



