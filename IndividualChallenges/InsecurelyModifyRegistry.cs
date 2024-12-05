public void InsecurelyModifyRegistry()
{
    // Insecure: Sets a registry key value that enables administrative access
    Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\App", "AdminAccess", "true");
    Console.WriteLine("Set registry key AdminAccess to true.");
}
