using System;
using System.Linq;

namespace Recursive_Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            //To generate unique input numbers;
            var numbers = GeneratesInputNumbers(length);

            //Print the generated numbers
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //number to be searched for
            int searchItem = new Random().Next(1,100);
            Console.WriteLine(searchItem);

            //Make sure the numbers are stored in a sorted order
            numbers = numbers.OrderBy(i => i).ToArray();

            //return the position of the searchItem
            int position = RecursiveLinearSearch(numbers, searchItem, 0);

        }

        private static int RecursiveLinearSearch(int[] numbers,int searchItem,int index)
        {
             int position = 0;

            //Search the serachItem at the index value
            if(numbers[index] == searchItem)
            {
                position = index + 1;
                
            }
            else
            {
                if (index < numbers.Count() - 1)
                {
                    position = RecursiveLinearSearch(numbers, searchItem, index + 1);
                }
            }
            return position;
        }

        private static int[] GeneratesInputNumbers(int length)
        {
            int[] numbers = new int[length];
            var randomNumberGenerator = new Random();
            int number ;
            for (int i = 0; i < length; i++)
            {                
                //generates random numbers from 1 - 100
                Generate:
                number = randomNumberGenerator.Next(1, 100);

                if(!numbers.Contains(number))
                {
                    numbers[i] = number;
                }
                else
                {
                    goto Generate;
                }

            }

            return numbers;
        }
    }
}
