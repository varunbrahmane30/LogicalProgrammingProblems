using System;
using System.Collections.Generic;
using System.Text;

namespace D6LogicalProblems
{
    class FebonacciSeries
    {
        public static void calFebonacciSeries()
        {
			// variables
			int a = 0;
			int b = 1;
			int c = 0;
			

			// taking user input 
            Console.WriteLine("How many Iteration do you want: ");
			int input =  int.Parse(Console.ReadLine());

            //implementation
            Console.WriteLine("Febonacci Series : ");
			for (int i = 1; i <= input; i++)
			{
				Console.Write(a + "  ");
				c = a + b;
				a = b;
				b = c;
			}
		}
    }
}
