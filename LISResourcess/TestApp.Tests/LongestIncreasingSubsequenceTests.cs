using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        int[] input = null;

        Assert.That(() => LongestIncreasingSubsequence.GetLis(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        int[] input = Array.Empty<int>();

        string output = LongestIncreasingSubsequence.GetLis(input);

        Assert.That(output, Is.Empty);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        int[] input = new int[] {21};

        string output = LongestIncreasingSubsequence.GetLis(input);

        Assert.AreEqual(output, "21");
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        int[] input = new int[] { 1, 3, 4, 6, 2, 1 };

        string output = LongestIncreasingSubsequence.GetLis(input);

        Assert.That(output, Is.EqualTo("1 3 4 6"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        string output = LongestIncreasingSubsequence.GetLis(input);

        Assert.AreEqual(output, "1 2 3 4 5 6 7");
    }
}
