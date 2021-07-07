using System;
using System.Collections.Generic;
using System.Text;

namespace D6LogicalProblems
{
    class CoupanNumber
    {
        public static int generateRandom()
        {
            Random random = new Random();
            int value = random.Next(1,100);
            return value;
                  
        }

        public static void calDistinctNumber()
        {
            // taking user input 
            Console.WriteLine("Enter a 5 coupan Number between (1 to 100) : ");
            int number5 = int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3= int.Parse(Console.ReadLine());
            int number4= int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("....... Genrating Coupans Numbers ........");
            Console.WriteLine();

            // implementation 
            int i = 0;
            while ( i<=100 )
            {
                i++;
                int digit = generateRandom();

                if( digit == number1 || digit == number2 || digit == number3 || digit == number4 || digit == number5)
                {
                    Console.WriteLine("   Its a existing coupan code :: " + digit);
                }
                else
                {
                    Console.WriteLine("   New Coupan Number:  " + digit);
                }
            }

        }
    }
}
