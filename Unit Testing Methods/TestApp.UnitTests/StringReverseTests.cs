using NUnit.Framework;
using System.Linq;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange

        // Act
        //StringReverse.Reverse(input);

        // Assert
        //Assert.AreEqual();
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // TODO: Write your test here...
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string input = "yoanna";

        string result = StringReverse.Reverse(input);

        Assert.AreEqual(input.Length, result.Length);
        Assert.AreEqual("annaoy", result);
    }
}
