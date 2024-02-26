using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        int[] numbers = {42, 22};

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        int[] numbers = { 42, 22, 42, 23 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert

        Assert.That(result, Is.EqualTo(new int[] { 42, 22, 23 }));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        int[] numbers = { 42, 42};

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert

        Assert.That(result, Is.EqualTo(new int[] { 42}));
    }
}
