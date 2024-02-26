using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        int input = 0;

        int result = Factorial.CalculateFactorial(input);

        Assert.AreEqual(1, result);

    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        int input = 3;

        int result = Factorial.CalculateFactorial(input);

        Assert.AreEqual(6, result);
    }

    [Test]
    public void Test_CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        int input = -1;

        Assert.Throws<ArgumentOutOfRangeException>(() => { Factorial.CalculateFactorial(input); });
    }
}
