public void SaveFile(string userInput, byte[] fileContent)
{
    string filePath = "/uploads/" + userInput;
    File.WriteAllBytes(filePath, fileContent);
    Console.WriteLine($"File saved to {filePath}");
}
