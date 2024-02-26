using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputIsEmptyArray_ShouldThrowArgumentException()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act & Assert
        Assert.That(() => Average.CalculateAverage(emptyArray), Throws.ArgumentException);
       
    }

    // TODO: finish the test
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
        int[] input = { 2, 4, 6 };

        double result = Average.CalculateAverage(input);

        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        int[] input = { -2, -4, -6 };

        double result = Average.CalculateAverage(input);

        Assert.That(result, Is.EqualTo(-4));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        int[] input = { 1, -1, 0 };

        double result = Average.CalculateAverage(input);

        Assert.That(result, Is.EqualTo(0));
    }
}
