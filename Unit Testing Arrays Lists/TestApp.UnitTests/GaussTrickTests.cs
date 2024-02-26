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

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> input = new() { 42 };

        // Act
        List<int> result = GaussTrick.SumPairs(input) ;

        // Assert
        CollectionAssert.AreEqual(input, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> input = new() { 1, 2, 3, 4 };

        // Act
        List<int> result = GaussTrick.SumPairs(input);

        // Assert
        List<int> result2 = new List<int>() { 5, 5 };
        CollectionAssert.AreEqual(result, result2);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> input = new() { 1, 2, 3, 4, 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(input);

        // Assert
        List<int> result2 = new List<int>() { 6, 6, 3 };
        CollectionAssert.AreEqual(result, result2);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> input = new() { 1, 2, 3, 4, 5, 6 };

        // Act
        List<int> result = GaussTrick.SumPairs(input);

        // Assert
        List<int> result2 = new List<int>() { 7, 7, 7 };
        CollectionAssert.AreEqual(result, result2);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> input = new() { 1, 2, 3, 4, 5, 6, 7 };

        // Act
        List<int> result = GaussTrick.SumPairs(input);

        // Assert
        List<int> result2 = new List<int>() { 8, 8, 8, 4  };
        CollectionAssert.AreEqual(result, result2);
    }
}
