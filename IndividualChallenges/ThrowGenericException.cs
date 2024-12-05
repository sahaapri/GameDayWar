public void ThrowGenericException(Exception ex)
{
    try
    {
        DoSomethingRisky();
    }
    catch (Exception innerEx)
    {
        throw new Exception("Error: " + innerEx.Message); // Concatenating exception details
    }
}

private void DoSomethingRisky()
{
    throw new ArgumentNullException("Parameter cannot be null.");
}
