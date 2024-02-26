using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        List<string> palindrome = new() { "bob" };

        bool result = Palindrome.IsPalindrome(palindrome);

        Assert.IsTrue(result);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        bool result = Palindrome.IsPalindrome(words);

        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        List<string> palindrome = new() { "bob" };

        bool result = Palindrome.IsPalindrome(palindrome);

        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        List<string> palindrome = new() { "boba" };

        bool result = Palindrome.IsPalindrome(palindrome);

        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        List<string> palindrome = new() { "BoB" };

        bool result = Palindrome.IsPalindrome(palindrome);

        Assert.IsTrue(result);
    }
}
