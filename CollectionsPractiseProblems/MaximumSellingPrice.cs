using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractiseProblems
{
    class MaximumSellingPrice
    {
        public static void FindindMaxPrice()
        {
            Console.WriteLine("Enter N and K value separated by a space:");
            string[] input1 = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input1[0]);
            int k = Convert.ToInt32(input1[1]);

            Console.WriteLine("Enter {0} values for basket A of fruit separated by a space:", n);
            int[] basketA = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            Console.WriteLine("Enter {0} values for basket B of fruit separated by a space:", n);
            int[] basketB = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
          
            // Swap K elements from basket A and basket B
            for (int i = 0; i < k; i++)
            {
                int maxIndex = Array.IndexOf(basketB, basketB.Max());
                int minIndex = Array.IndexOf(basketA, basketA.Min());

                int temp = basketA[minIndex];
                basketA[minIndex] = basketB[maxIndex];
                basketB[maxIndex] = temp;
            }

            Console.WriteLine("\nafter swaping basket A value is ");
            foreach (int value in basketA)
            {
                Console.Write(" " + value);
            }

            Console.WriteLine("\nafter swaping basket B value is ");
            foreach (int value in basketB)
            {
                Console.Write(" " + value);
            }

            // Calculate total selling price of basket A
            int totalSellingPrice = 0;
            foreach (int fruit in basketA)
            {
                totalSellingPrice += fruit;
            }

            // Output maximum selling price of basket A
            Console.WriteLine("\nMax Selling Price of basket A: {0}", totalSellingPrice);
        }
    }
}
