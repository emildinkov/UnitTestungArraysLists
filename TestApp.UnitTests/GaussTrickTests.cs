using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> singleElement = new() { 42 };

        // Act
        List<int> result = GaussTrick.SumPairs(singleElement);

        // Assert
        CollectionAssert.AreEqual(singleElement, result);
    }

    
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 4 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expected = new() { 5, 5 };
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expected = new() { 4, 2 };
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 4, 5, 6, 7, 8 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expected = new() { 9, 9, 9, 9 };
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expected = new() { 10, 10, 10, 10, 5 };
        CollectionAssert.AreEqual(result, expected);
    }
}
