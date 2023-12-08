using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenNum = { 10, 10 };

        // Act
        int result = EvenOddSubtraction.FindDifference(evenNum);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] oodNum = { 1, 3, 5, 1 };

        // Act
        int result = EvenOddSubtraction.FindDifference(oodNum);

        // Assert
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] mixNum = { 1, 2, 3, 4 };

        // Act
        int result = EvenOddSubtraction.FindDifference(mixNum);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
}
