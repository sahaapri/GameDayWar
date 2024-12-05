public void ReadLogFile(string filename)
{
    // Validate the filename to ensure it does not contain invalid characters or path traversal sequences
    if (string.IsNullOrWhiteSpace(filename) || filename.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0 || filename.Contains(".."))
    {
        Console.WriteLine("Invalid filename.");
        return;
    }

    string filePath = Path.Combine("C:\\logs", filename);

    try
    {
        string content = File.ReadAllText(filePath);
        Console.WriteLine($"File Content: {content}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
    }
}
