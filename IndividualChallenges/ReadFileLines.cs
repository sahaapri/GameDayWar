using System;
using System.IO;

public void ReadFileLines(string userInput)
{
    // Validate the user input to prevent path traversal attacks
    if (string.IsNullOrWhiteSpace(userInput) || !IsValidPath(userInput))
    {
        Console.WriteLine("Invalid file path.");
        return;
    }

    try
    {
        var lines = File.ReadAllLines(userInput);
        Console.WriteLine($"Read {lines.Length} lines from file: {userInput}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}

private bool IsValidPath(string path)
{
    try
    {
        var fullPath = Path.GetFullPath(path);
        return Path.IsPathRooted(fullPath) && !Path.GetInvalidPathChars().Any(path.Contains);
    }
    catch
    {
        return false;
    }
}

