public void DeleteFile(string userInput)
{
    // Deletes a file based on unvalidated user input
    File.Delete(userInput); 
    Console.WriteLine($"Deleted file: {userInput}");
}
