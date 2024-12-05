public void UseHardcodedWindowsIdentity()
{
    // Insecure: Creates a Windows identity with hardcoded credentials
    WindowsIdentity identity = new WindowsIdentity("Admin");
    Console.WriteLine("Using Windows identity: " + identity.Name);
}
