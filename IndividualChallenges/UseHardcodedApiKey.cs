public void UseHardcodedApiKey()
{
    // fetch key from azure key vault
    
    string apiKey = FetchApiKeyFromKeyVault();
    Console.WriteLine("Using API key: " + apiKey);

    // Simulate API usage
    var client = new HttpClient();
    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
    var response = client.GetAsync("https://api.example.com/data").Result;
    Console.WriteLine("Response: " + response.StatusCode);
}

private void FetchApiKeyFromKeyVault()
{
    // Simulate fetching API key from Azure Key Vault
    // fetching from environment variable for now
    return Environment.GetEnvironmentVariable("API_KEY");
}
