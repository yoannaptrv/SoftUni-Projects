using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act

        // Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> input = new List<int>() { 1, 2, 3, 4, 3, 5 };

        // Act
        string result = AdjacentEqual.Sum(input);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 3 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        List<int> input = new List<int>() { 1, 2, 2, 4, 3, 5 };

        // Act
        string result = AdjacentEqual.Sum(input);

        // Assert
        Assert.That(result, Is.EqualTo("1 8 3 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        List<int> input = new List<int>() { 1, 1, 2, 4 };

        // Act
        string result = AdjacentEqual.Sum(input);

        // Assert
        Assert.That(result, Is.EqualTo("8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        List<int> input = new List<int>() { 2, 2, 2, 4 };

        // Act
        string result = AdjacentEqual.Sum(input);

        // Assert
        Assert.That(result, Is.EqualTo("4 2 4"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        List<int> input = new List<int>() { 1, 1, 2, 2 };

        // Act
        string result = AdjacentEqual.Sum(input);

        // Assert
        Assert.That(result, Is.EqualTo("4 2"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        List<int> input = new List<int>() { 1, 1, 1, 4, 2 };

        // Act
        string result = AdjacentEqual.Sum(input);

        // Assert
        Assert.That(result, Is.EqualTo("2 1 4 2"));
    }
}
