using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();

        //Followed Core Requriements 1 and 2 before doing part 3:

        //Console.Write("What is the magic number? ");
        //string number = Console.ReadLine();
        //int magicNumber = int.Parse(number);
        
        Random randomeGenerator = new Random();
        int magicNumber = randomeGenerator.Next(1, 100);

        int guessNumber = 0;

        Console.WriteLine("What is the magic number game:");

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();

            guessNumber = int.Parse(guess);

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.Write("You guessed it right!");
            }
        }

    }
}