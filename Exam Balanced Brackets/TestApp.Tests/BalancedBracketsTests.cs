using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        string[] input = new string[] { };

        bool expected = BalancedBrackets.IsBalanced(input);

        Assert.IsTrue(expected);
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        string[] input = new string[] { "0" };

        bool expected = BalancedBrackets.IsBalanced(input);

        Assert.IsTrue(expected);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        string[] input = new string[] { ")" };

        bool expected = BalancedBrackets.IsBalanced(input);

        Assert.IsFalse(expected);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        string[] input = new string[] { ")", ")" };

        bool expected = BalancedBrackets.IsBalanced(input);

        Assert.IsFalse(expected);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        string[] input = new string[] { "(" };

        bool expected = BalancedBrackets.IsBalanced(input);

        Assert.IsFalse(expected);
    }
}
