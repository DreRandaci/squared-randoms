using System;
using System.Collections.Generic;

namespace squared_randoms
{
    class Program
    {
        static void Main(string[] args)
        {

            // Using the Random class, generate a list of 20 random numbers that are in the range of 1-50            
            Random random = new Random(50);

            // Create a list
            List<int> nums = new List<int>();

            // Populate the list
            for (int i = 0; i <= 20; i++)
            {
                nums.Add(random.Next(1, 50));
            }

            // With the resulting List, populate a new List that contains each number squared 
                // For example, if the original list is 2, 5, 3, 15, the final list will be 4, 25, 9, 225
            List<int> squared_randoms = new List<int>();

            foreach (int num in nums)
            {
                squared_randoms.Add(num * num);
            }


            foreach (int num in squared_randoms)
            {
                Console.WriteLine("all squared numbers: " + num);
            }
            
            // Then remove any number that is odd from the list of squared numbers  
            squared_randoms.RemoveAll(i => i % 2 == 1);

            foreach (int num in squared_randoms)
            {
                Console.WriteLine("even numbers: " + num);
            }

        }
    }
}
