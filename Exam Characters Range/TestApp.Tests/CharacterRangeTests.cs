using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Security.Cryptography;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        char a = 'a';
        char b = 'b';

        string result = CharacterRange.GetRange(a, b);
        string expected = string.Empty;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        char b = 'b';
        char a = 'a';

        string result = CharacterRange.GetRange(b, a);
        string expected = string.Empty;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        char a = 'a';
        char c = 'c';

        string result = CharacterRange.GetRange(a, c);

        Assert.AreEqual("b", result);
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        char d = 'd';
        char g = 'g';

        string result = CharacterRange.GetRange(d, g);

        Assert.AreEqual("e f", result);
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        char x = 'x';
        char z = 'z';

        string result = CharacterRange.GetRange(x, z);

        Assert.AreEqual("y", result);
    }
}
