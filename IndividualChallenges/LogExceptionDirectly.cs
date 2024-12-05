public void LogExceptionDirectly()
{
    try
    {
        int result = 10 / 0; // Force a divide-by-zero exception
    }
    catch (Exception e)
    {
        Console.WriteLine(e); // Directly printing exception details
    }
}
