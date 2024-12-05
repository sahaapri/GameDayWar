public void ReadFileLines(string userInput)
{
    // Reads all lines from a file based on unvalidated user input
    var lines = File.ReadAllLines(userInput);
    Console.WriteLine($"Read {lines.Length} lines from file: {userInput}");
}
