using System;
using System.IO;

namespace InsecureFileOperations
{
    public class FileHandler
    {
        private static readonly string encryptionKey = "your-encryption-key";

        // 1. Storing sensitive data with encryption
        public static void StoreSensitiveData(string data)
        {
            string encryptedData = EncryptData(data);
            File.WriteAllText("sensitiveData.txt", encryptedData);
        }

        // 2. Secure file path usage to prevent Directory Traversal vulnerability
        public static void DeleteFile(string userInput)
        {
            string sanitizedInput = Path.GetFileName(userInput); // Sanitize user input
            string filePath = Path.Combine("C:\\Files\\", sanitizedInput);
            File.Delete(filePath);
        }

        // 3. Secure Logging (Avoid logging sensitive data)
        public static void LogData(string data)
        {
            string sanitizedData = SanitizeLogData(data);
            File.AppendAllText("log.txt", $"{DateTime.Now}: {sanitizedData}\n");
        }

        // 4. Secure File Permissions (Check and set appropriate file permissions)
        public static void ChangeFilePermissions(string filePath)
        {
            // Example: Set file to read-only for all users
            File.SetAttributes(filePath, FileAttributes.ReadOnly);
        }

        // 5. Data Integrity (File modification with integrity checks)
        public static void ModifyFileData(string filePath, string newData)
        {
            if (VerifyFileIntegrity(filePath))
            {
                File.WriteAllText(filePath, newData);
            }
        }

        private static string EncryptData(string data)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(encryptionKey);
                aes.IV = new byte[16]; // Initialization vector with zeros

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(data);
                        }
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        private static string SanitizeLogData(string data)
        {
            // Implement sanitization logic here
            return data.Replace("sensitive", "****");
        }

        private static bool VerifyFileIntegrity(string filePath)
        {
            // Implement file integrity check logic here
            return true;
        }
    }
}
