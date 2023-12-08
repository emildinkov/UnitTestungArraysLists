using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> singleElement = new() { 9 };

        // Act
        int result = MaxNumber.FindMax(singleElement);

        // Assert
        Assert.That(result, Is.EqualTo(9));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { 10, 20, 30, 50 };

        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.That(result, Is.EqualTo(50));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { -1, -30, -10 };

        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { -10, -50, 30, 50 };

        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.That(result, Is.EqualTo(50));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new() { 100, 30, 20, 100};

        // Act
        int result = MaxNumber.FindMax(list);

        // Assert
        Assert.That(result, Is.EqualTo(100));
    }
}
