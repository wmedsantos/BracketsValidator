namespace BracketValidatorLibrary;

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class BracketValidator
{
    public static bool ValidateBracketOrder(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char character in input)
        {
            if (character == '(' || character == '{' || character == '[')
            {
                // If an opening bracket is encountered, push it onto the stack.
                stack.Push(character);
            }
            else if (character == ')' || character == '}' || character == ']')
            {
                // If a closing bracket is encountered, check if it matches the top of the stack.
                if (stack.Count == 0)
                {
                    return false; // Unmatched closing bracket.
                }

                char openBracket = stack.Pop();

                // Check if the closing bracket matches the corresponding opening bracket.
                if ((character == ')' && openBracket != '(') ||
                    (character == '}' && openBracket != '{') ||
                    (character == ']' && openBracket != '['))
                {
                    return false; // Mismatched brackets.
                }
            }
        }

        // If the stack is empty, all brackets were closed in the correct order.
        return stack.Count == 0;
    }


    public static bool ValidateBracketOrderByRegex(string input)
    {
        string pattern = @"\(\)|\{\}|\[\]";
        Regex regex = new Regex(pattern);

        // Continue replacing matching bracket pairs until none are left
        while (true)
        {
            string previousInput = input;
            input = regex.Replace(input, "");
            
            if (input == previousInput)
            {
                // If no replacements were made in the last iteration, exit the loop
                break;
            }
        }

        // If the string is empty, all brackets were closed in the correct order
        return string.IsNullOrEmpty(input);
    }
}