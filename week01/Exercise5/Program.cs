using System;
using System.Data;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine();

        DisplayWelcome();


        string name = PromptUsername();
        int number = PromptUserNumber();
        int numberSquare = SquareNumber(number);

        DisplayResult(name, numberSquare);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUsername()
    {
        Console.Write("What is your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        string numberReply = Console.ReadLine();

        int givenNumber = int.Parse(numberReply);
        return givenNumber;
    }
    static int SquareNumber(int squared)
    {
        int squaredResult = squared * squared;
        return squaredResult;
    }
    static void DisplayResult(string PromptUserName, int SquareNumber)
    {
        Console.WriteLine($"{PromptUserName}, the square of your number is {SquareNumber}");
    }
}