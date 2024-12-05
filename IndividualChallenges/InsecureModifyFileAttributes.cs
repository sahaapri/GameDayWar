public void InsecureModifyFileAttributes()
{
    // Insecure: Removes any special attributes from a secure file
    File.SetAttributes("C:\\SecureFile.txt", FileAttributes.Normal);
    Console.WriteLine("File attributes set to normal.");
}
