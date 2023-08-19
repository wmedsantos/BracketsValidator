using System;
using BracketValidatorLibrary;
class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a string with brackets as a command-line argument.");
            return;
        }

        string input = args[0];

        bool isValid = BracketValidator.ValidateBracketOrder(input);

        if (isValid)
        {
            Console.WriteLine("The bracket order is valid.");
        }
        else
        {
            Console.WriteLine("The bracket order is not valid.");
        }
    }
}
