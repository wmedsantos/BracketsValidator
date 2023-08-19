# Bracket Validator

This is a .NET Core project that provides a utility to validate the order of brackets like (, ), {, }, [, or ] in a given string. 
A sequence of square brackets is valid if the following conditions are met answered:
   - Contains no unmatched brackets.
   - The subset of brackets within the bounds of a matching pair of brackets is also a pair of matching square brackets.
   
It includes two methods for bracket validation: `ValidateBracketOrder` and `ValidateBracketOrderByRegex`.

## Table of Contents

- [Project Structure](#project-structure)
- [How to Execute the Console Application](#how-to-execute-the-console-application)
- [How to Run the Tests](#how-to-run-the-tests)
- [Performance Comparison](#performance-comparison)

## Project Structure

The project is organized as follows:

- `BracketValidatorLibrary`: Contains the bracket validation logic shared by the console app and tests.
- `BracketValidatorApp`: Contains the console application for validating bracket orders.
- `BracketValidatorTests`: Contains xUnit tests for the bracket validation methods.
- `BracketValidatorSolution.sln`: The solution file that includes all projects.

## How to Execute the Console Application

To execute the console application and validate a bracket order, follow these steps:

1. Open a terminal and navigate to the `BracketValidatorApp` directory:

   ```bash
   cd BracketValidatorApp
   ```

2. Run the console application and provide a string with brackets as a command-line argument:

   ```bash
   dotnet run "({[()]})"
   ```

   Replace `"({[()]})"` with your desired input string.

## How to Run the Tests

To run the tests for bracket validation, follow these steps:

1. Open a terminal and navigate to the root directory of the project (where the solution file is located):

   ```bash
   cd path/to/BracketValidatorSolution
   ```

2. Run the tests using the `dotnet test` command:

   ```bash
   dotnet test
   ```

   This will execute the five xUnit tests in the `BracketValidatorTests` project.
   
   1º Test input (){}[] is valid
   2º Test input [{()}](){} is valid
   3º Test input []{() is not valid
   4º Test input [{)] is not valid
   5º Test is the performance comparison betwhen the two types.

## Performance Comparison

We have tested and compared the performance of two bracket validation methods: `ValidateBracketOrder` and `ValidateBracketOrderByRegex`.

- `ValidateBracketOrder`: This method uses a custom stack-based approach for bracket validation.

- `ValidateBracketOrderByRegex`: This method uses a regular expression to perform bracket validation.

We ran both methods with a large input string (containing more than a thousand brackets) and measured the elapsed time for validation. Here are the results:

- `ValidateBracketOrder` Elapsed time: 4886 tiks
- `ValidateBracketOrderByRegex` Elapsed time: 3328771 tiks

As you can see, the `ValidateBracketOrder` method significantly outperformed the `ValidateBracketOrderByRegex` method in terms of execution time with a large string.

For large-scale bracket validation tasks, it is recommended to use the `ValidateBracketOrder` method due to its better performance.

Feel free to explore the code and further customize it to suit your needs.
[label](../RicksFriends/.gitignore)