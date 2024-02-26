using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        decimal money = 100;
        List<int> initialQuality = new() { 2, 3 };
        List<string> commands = new() { "1", "1" };

        Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        decimal money = 100;
        List<int> initialQuality = new() { 2, 3 };
        List<string> commands = new() { "Number did not parse correctly!" };

        Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 100;
        List<int> initialQuality = new() { 3, 4 };
        List<string> commands = new() { "1", "1", "Hit it again, Gabsy!" };

        string expected = "1 2\nGabsy has 100,00lv.";

        string output = DrumSet.Drum(money, initialQuality, commands);

        Assert.AreEqual(expected, output);
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 0;
        List<int> initialQuality = new() { 3, 4, 5 };
        List<string> commands = new() { "2", "2", "Hit it again, Gabsy!" };

        string expected = "1\nGabsy has 0,00lv.";

        string output = DrumSet.Drum(money, initialQuality, commands);

        Assert.AreEqual(expected, output);
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 0;
        List<int> initialQuality = new() { 3, 4 };
        List<string> commands = new() { "2", "2", "Hit it again, Gabsy!" };

        string expected = "\nGabsy has 0,00lv.";

        string output = DrumSet.Drum(money, initialQuality, commands);

        Assert.AreEqual(expected, output);
    }
}
