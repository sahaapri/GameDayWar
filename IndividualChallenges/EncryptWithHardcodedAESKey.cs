public void EncryptWithHardcodedAESKey(string data)
{
    var key = Encoding.UTF8.GetBytes("1234567890123456"); // Insecure: Hardcoded key
    var iv = Encoding.UTF8.GetBytes("1234567890123456");  // Example IV (also insecure)

    using (var aes = Aes.Create())
    {
        aes.Key = key;
        aes.IV = iv;

        using (var encryptor = aes.CreateEncryptor())
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(data);
            var encryptedData = encryptor.TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length);
            Console.WriteLine($"Encrypted Data (AES): {Convert.ToBase64String(encryptedData)}");
        }
    }
}
