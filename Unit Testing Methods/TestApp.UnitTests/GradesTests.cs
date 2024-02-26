using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.0, "Fail")]
    [TestCase(3.0, "Average")]
    [TestCase(3.5, "Good")]
    [TestCase(4.0, "Very Good")]
    [TestCase(4.5, "Excellent")]

    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
