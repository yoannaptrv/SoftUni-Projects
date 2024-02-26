using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        double firstPointX = 1;
        double firstPointY = 1;
        double secondPointX = 2;
        double secondPointY = 2;

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        Assert.AreEqual("(1, 1)", result);

    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        double firstPointX = 2;
        double firstPointY = 2;
        double secondPointX = 1.5;
        double secondPointY = 1.5;

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        Assert.AreEqual("(1,5, 1,5)", result);
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        double firstPointX = 1;
        double firstPointY = 1;
        double secondPointX = 1;
        double secondPointY = 1;

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        Assert.AreEqual("(1, 1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {

        double firstPointX = -1;
        double firstPointY = -1;
        double secondPointX = 1;
        double secondPointY = 1;

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        Assert.AreEqual("(-1, -1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        double firstPointX = 1;
        double firstPointY = 1;
        double secondPointX = -1;
        double secondPointY = -1;

        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);

        Assert.AreEqual("(-1, -1)", result);
    }
}
