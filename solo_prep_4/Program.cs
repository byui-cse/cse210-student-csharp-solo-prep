using System;
using System.Collections.Generic;

namespace solo_prep_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            // Please note we could use a do-while loop here instead
            int userNumber = -1;
            while (userNumber != 0)
            {
                Console.Write("Enter a number (0 to quit): ");
                
                string userResponse = Console.ReadLine();
                userNumber = int.Parse(userResponse);
                
                numbers.Add(userNumber);
            }

            // Part 1: Compute the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            // Part 2: Compute the average
            // Notice that I first cast the sum variable to be a float. Otherwise, because
            // both the sum and the count are integers, the computer will do integer division
            // and I will not get a decimal value (even though it puts the result into a float variable).
            // By making one of the variables a float first, the computer knows that it has to
            // do the floating point division, and I get the decimal value that I expect.
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Part 3: Find the max
            // There are several ways to do this, such as sorting the list
            
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    // if this number is greater than the max, we have found the new max!
                    max = number;
                }
            }

            Console.WriteLine($"The max is: {max}");
        }
    }
}
