public void SwallowException()
{
    try
    {
        DoSomething(); // This method might throw an exception
    }
    catch
    {
        // Silently swallow the exception
        // Log the exception
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}

private void DoSomething()
{
    throw new InvalidOperationException("An error occurred in DoSomething.");
}
