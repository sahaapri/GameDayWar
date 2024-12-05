public void DeleteFile(string userInput)
{
    if (File.Exists(userInput))
    {
        File.Delete(userInput);
        Console.WriteLine($"Deleted file: {userInput}");
    }
    else
    {
        Console.WriteLine($"File not found: {userInput}");
    }
}
