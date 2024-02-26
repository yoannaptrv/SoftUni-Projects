using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_NegativeInput()
    {
        // Arrange
        int n = -1;

        // Act & Assert
        Assert.That(() => Fibonacci.CalculateFibonacci(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        int n = 0;

        int output = Fibonacci.CalculateFibonacci(n);

        Assert.That(output, Is.Zero);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int n = 2;

        int output = Fibonacci.CalculateFibonacci(n);

        Assert.That(output, Is.EqualTo(1));
    }
}