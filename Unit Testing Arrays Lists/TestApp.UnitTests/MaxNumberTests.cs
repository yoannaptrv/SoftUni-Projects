using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> nullList = null;

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
        List<int> input = new List<int>() { 42 };

        int result = MaxNumber.FindMax(input);

        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> input = new List<int>() { 1, 2, 3, 42 };

        int result = MaxNumber.FindMax(input);

        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        List<int> input = new List<int>() { -1, -2, -3, 42 };

        int result = MaxNumber.FindMax(input);

        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> input = new List<int>() { -1, 22, -5, 42 };

        int result = MaxNumber.FindMax(input);

        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> input = new List<int>() { 42, 42 };

        int result = MaxNumber.FindMax(input);

        Assert.That(result, Is.EqualTo(42));
    }
}
