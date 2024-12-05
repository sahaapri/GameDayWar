public void DeleteDirectory(string folderName)
{
    // Deletes a directory based on unvalidated user input
    Directory.Delete("C:\\Sensitive\\" + folderName, true);
    Console.WriteLine($"Deleted directory: C:\\Sensitive\\{folderName}");
}
