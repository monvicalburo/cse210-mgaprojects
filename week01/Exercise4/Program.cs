using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int givenNumbers = -1;

        Console.WriteLine("Enter a lit of numbers, type 0 when finished.");

        while (givenNumbers != 0)
        {
            Console.Write("Enter number: ");
            string given = Console.ReadLine();

            givenNumbers = int.Parse(given);

            if (givenNumbers != 0)
            {
                numbers.Add(givenNumbers);
            }
        }
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }

        int count = numbers.Count;
        double average = ((double) total/count);

        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is {average}");

        int largestNumber = numbers.Max();
        Console.WriteLine($"The Largest Number is: {largestNumber}");


        
    }
}