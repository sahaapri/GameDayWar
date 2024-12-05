public void ReadFileFromFixedDirectory(string filename)
{
    // Opens a file based on user input without validating the filename
    using (var stream = File.OpenRead("C:\\uploads\\" + filename))
    {
        Console.WriteLine("Opened file: " + filename);
    }
}