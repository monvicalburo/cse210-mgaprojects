using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine();

        Console.Write("Enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        Console.WriteLine();

        int grade = int.Parse(gradePercentage);
        string letter = "";

        if ( grade >= 90)
        {
            letter = "A";
        }
        else if ( grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course. ");
        }
        else
        {
            Console.WriteLine ("You failed the course. Study harder to pass next time! ");
        }


    }
}