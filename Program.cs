using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicount_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the total shopping amount
            Console.WriteLine("Enter the total shopping amount in dollars:");
            double totalAmount = Convert.ToDouble(Console.ReadLine());

            // Declare a variable to store the discount percentage
            double discountPercentage = 0;

            // Apply discount tiers based on the total amount
            if (totalAmount >= 1000)
            {
                discountPercentage = 20; // 20% discount for $1000 or more
            }
            else if (totalAmount >= 500)
            {
                discountPercentage = 10; // 10% discount for $500 or more
            }
            else if (totalAmount >= 100)
            {
                discountPercentage = 5; // 5% discount for $100 or more
            }
            else
            {
                Console.WriteLine("No discount available.");
            }

            // Calculate the discount amount
            double discountAmount = (totalAmount * discountPercentage) / 100;

            // Calculate the final amount after the discount
            double finalAmount = totalAmount - discountAmount;

            // Display the final amount after applying the discount
            Console.WriteLine("The final amount after applying a {0}% discount is: ${1}", discountPercentage, finalAmount);
        }
    }
}
