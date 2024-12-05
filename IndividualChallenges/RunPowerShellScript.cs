public void RunPowerShellScript(string userInput)
{
    string command = $"powershell.exe {userInput}";

    Process process = new Process
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = "powershell.exe",
            Arguments = userInput,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        }
    };
    process.Start();
    string output = process.StandardOutput.ReadToEnd();
    Console.WriteLine(output);
}
