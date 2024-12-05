public void ReadLogFile(string filename)
{
    string filePath = "C:\\logs\\" + filename;
    string content = File.ReadAllText(filePath);
    Console.WriteLine($"File Content: {content}");
}
