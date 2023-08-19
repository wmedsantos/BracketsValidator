namespace BracketValidatorTests;

using System;
using System.Diagnostics;
using Xunit;
using BracketValidatorLibrary;

public class BracketValidatorTests
{
    [Fact]
    public void Should_Return_True_For_Validation_1()
    {
        // Arrange
        string input = "(){}[]";

        // Act
        bool result = BracketValidator.ValidateBracketOrder(input);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Should_Return_True_For_Validation_2()
    {
        // Arrange
        string input = "[{()}](){}";

        // Act
        bool result = BracketValidator.ValidateBracketOrder(input);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Should_Return_False_For_Validation_3()
    {
        // Arrange
        string input = "[]{()";

        // Act
        bool result = BracketValidator.ValidateBracketOrder(input);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void PerformanceCompareWithRegex()
    {
        // Arrange
        string input = "[{)]";

        // Act
        bool result = BracketValidator.ValidateBracketOrder(input);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Should_Return_False_For_Validation_5()
    {
        // Arrange
        string input = "({[1234567890()]})({[1234567890()]})({[1234567890()]})({[1234567890()]})";
        for (var x=0;x==1000;x++) input += input;
        // Act

        // Measure the time it takes to validate
        var stopwatch = Stopwatch.StartNew();
        bool result = BracketValidator.ValidateBracketOrder(input);
        stopwatch.Stop();

        // Output the result and elapsed time
        Console.WriteLine($"Elapsed time: {stopwatch.ElapsedTicks} ms");

        var stopwatch2 = Stopwatch.StartNew();
        bool result2 = BracketValidator.ValidateBracketOrderByRegex(input);
        stopwatch2.Stop();
        Console.WriteLine($"RegEx Elapsed time: {stopwatch2.ElapsedTicks} ms");

        // Assert
        Assert.True(result);
    }
}
