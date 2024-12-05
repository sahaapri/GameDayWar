public void HashWithMD5(byte[] data)
{
    var md5 = MD5.Create(); // Insecure hashing algorithm
    var hash = md5.ComputeHash(data);
    Console.WriteLine($"MD5 Hash: {Convert.ToHexString(hash)}");
}
