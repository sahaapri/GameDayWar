public void InsecureBase64Encryption(string data)
{
    var encryptedData = Convert.ToBase64String(Encoding.UTF8.GetBytes(data)); // Not encryption
    Console.WriteLine($"Base64 Encrypted Data: {encryptedData}");
}
