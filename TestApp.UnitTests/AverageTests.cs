using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    
    [Test]
    public void Test_CalculateAverage_InputIsEmptyArray_ShouldThrowArgumentException()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act & Assert
        Assert.That(() => Average.CalculateAverage(emptyArray), Throws.ArgumentException);
       
    }

    
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] positiveNumbers = { 1, 2, 3, 4, 5 };

        // Act
        double result = Average.CalculateAverage(positiveNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] negativeNumbers = { -1, -2, -3, -4, -5 };

        // Act
        double result = Average.CalculateAverage(negativeNumbers);

        // Assert
        Assert.That(result,Is.EqualTo(-3));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] mixNumbers = { 5, 2, -2, -1 };

        // Act
        double result = Average.CalculateAverage(mixNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
}
