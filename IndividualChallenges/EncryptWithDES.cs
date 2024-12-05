public void EncryptWithDES(byte[] data, byte[] key, byte[] iv)
{
    var des = DES.Create(); // Insecure encryption algorithm
    des.Key = key;          // Must be 8 bytes
    des.IV = iv;            // Must be 8 bytes

    using (var encryptor = des.CreateEncryptor())
    {
        var encryptedData = encryptor.TransformFinalBlock(data, 0, data.Length);
        Console.WriteLine($"Encrypted Data (DES): {Convert.ToBase64String(encryptedData)}");
    }
}
