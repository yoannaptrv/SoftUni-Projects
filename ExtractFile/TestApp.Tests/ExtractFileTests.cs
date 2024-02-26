using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        string input = null;

        Assert.That(() => ExtractFile.GetFile(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        string input = string.Empty;

        Assert.That(() => ExtractFile.GetFile(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        string input = "C:\\Users\\demo.txt";
        string expected = "File name: demo\nFile extension: txt";

        string output = ExtractFile.GetFile(input);

        Assert.AreEqual(expected, output);
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        string input = "C:\\Users\\demo";
        string expected = "File name: demo";

        string output = ExtractFile.GetFile(input);

        Assert.AreEqual(expected, output);
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        string input = "C:\\Users\\demo!.txt";
        string expected = "File name: demo!\nFile extension: txt";

        string output = ExtractFile.GetFile(input);

        Assert.AreEqual(expected, output);
    }
}
