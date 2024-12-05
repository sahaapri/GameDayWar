public bool IsDefaultPassword(string password)
{
    if (string.IsNullOrEmpty(password))
    {
        return false;
    }

    //return password == "default"; // Hardcoded default password
}
