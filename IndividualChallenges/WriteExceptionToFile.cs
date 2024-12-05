public void WriteExceptionToFile(Exception ex)
{
    try
    {
        DoSomethingRisky();
    }
    catch (Exception caughtEx)
    {
        File.WriteAllText("error.log", caughtEx.ToString()); // Dumps exception to a file
    }
}
