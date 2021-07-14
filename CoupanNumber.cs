using System;
using System.Collections.Generic;
using System.Text;

namespace D6LogicalProblems
{
    class CoupanNumber
    {
        private static int totalCoupans;
        private static int count = 0;
        public static int generateaRandom()
        {
            count++;
            Random random = new Random();
            return random.Next(0,100);
        }
        
        public static void printArray(int[] arr)
        {
          
            for ( int i=0;i<arr.Length;i++)
            {
                Console.Write( arr[i] +"  ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
        }
        public static void calDistinctNumber()
        {
            

            // ask user for input

            Console.Write("Enter How many Coupans you want to Generate :   ");
            totalCoupans = int.Parse(Console.ReadLine());

            // array declaration

            int[] arr = new int[totalCoupans];                   // array used for total number of coupans.
            int size = arr.Length;
            int[] arr2 = new int[size];                           // array used to store new coupan       
            

            for (int i = 0; i < size; i++)
            {
                int value = generateaRandom();
                arr[i] = value;
            }

            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("Tokens are : ");
            printArray(arr);
            
            for (int i = 0; i < size; i++)
            {
                int newvalue = generateaRandom();
               
                if( arr[i] != newvalue)
                {
                    arr2[i] = newvalue;
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("Newly Generated Tokens are :  ");
            printArray(arr2);
            Console.WriteLine("Total random number needed to have all distinct numbers is : " + count);

        }
    }
}
