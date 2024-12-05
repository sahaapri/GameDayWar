public void EncryptWithHardcodedKey(string data)
{
    var secretKey = Encoding.UTF8.GetBytes("mysecretkey"); // Insecure: Hardcoded key
    Console.WriteLine("Encrypting data with hardcoded key.");

    using (var aes = Aes.Create())
    {
        aes.Key = secretKey;
        aes.GenerateIV();

        var encryptor = aes.CreateEncryptor();
        var inputData = Encoding.UTF8.GetBytes(data);
        var encryptedData = encryptor.TransformFinalBlock(inputData, 0, inputData.Length);

        Console.WriteLine("Encrypted data: " + Convert.ToBase64String(encryptedData));
    }
}
