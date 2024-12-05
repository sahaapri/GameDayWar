public void UseHardcodedWindowsIdentity()
{
    // Insecure: Creates a Windows identity with hardcoded credentials
    // Uses the current Windows identity instead
    WindowsIdentity identity = WindowsIdentity.GetCurrent();
    Console.WriteLine("Using Windows identity: " + identity.Name);
}
