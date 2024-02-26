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

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] input = new int[] { 2, 4, 6, 8 };

        // Act
        int result = EvenOddSubtraction.FindDifference(input);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        int[] input = new int[] { 1, 5, 5, 9 };

        // Act
        int result = EvenOddSubtraction.FindDifference(input);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        int[] input = new int[4] { 9, 10, 11, 12 };

        // Act
        int result = EvenOddSubtraction.FindDifference(input);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
}
