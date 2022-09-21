using System;

namespace TopSeller
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Initialize counter to zero.
             * Declare largest seller name and quantity.
             * While counter is not five.
             * Get user input for seller name.
             * Get user input for quantity of sells.
             * Determine if seller has sold the most and store their information if so.
             * Increment the counter.
             * End while loop.
             * Output the result of the seller who has the most sells.
             */
            Console.WriteLine("Hello World!");
            // Initialize counter to zero.
            int counter = 0;
            // Declare largest seller name and quantity.
            string largestSellerName = "";
            int largestSoldQuantity = -1;
            // While counter is not five.
            while (counter < 5)
            {
                // Get user input for seller name.
                Console.Write("Please enter seller name: ");
                string sellerName = Console.ReadLine();
                // Get user input for quantity of sells.
                Console.Write("Please enter sold quantity: ");
                int soldQuantity = int.Parse(Console.ReadLine());
                // Determine if seller has sold the most and store their information if so.
                if (largestSoldQuantity < soldQuantity)
                {
                    largestSoldQuantity = soldQuantity;
                    largestSellerName = sellerName;
                }
                // Validate the input.
                if (soldQuantity < 0 || soldQuantity > 100)
                {
                    Console.WriteLine("Please enter valid input (i.e. 0 - 100).");
                    // Continue with next iteration of while loop.
                    continue;
                }
                // End validation.
                // Increment the counter.
                counter++;
            }
            // End while loop.
            // Output the result of the seller who has the most sells.
            Console.WriteLine($"The winner is {largestSellerName} having sold {largestSoldQuantity} units.");
        }
    }
}
