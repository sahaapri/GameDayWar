public void OpenFileStream(string filePath)
{
    // Opens a file using an unvalidated file path
    using (var fs = new FileStream(filePath, FileMode.Open))
    {
        Console.WriteLine("File opened successfully: " + filePath);
    }
}
