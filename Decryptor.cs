using System.Text;
using System.Configuration;
using System.Security.Cryptography;

namespace DoggyDaycare
{
    internal static class Decryptor
    {
        public static string Decrypt(string encryptedBase64)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedBase64);
            string privateKeyPath = GetPrivateKeyPath();

            if (!File.Exists(privateKeyPath))
                throw new FileNotFoundException("RSA private key file not found at given path: ", privateKeyPath);

            string privateKeyXml = File.ReadAllText(privateKeyPath);

            using (RSA rsa = RSA.Create())
            {
                try
                {
                    rsa.FromXmlString(privateKeyXml);
                    byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, RSAEncryptionPadding.OaepSHA256);
                    return Encoding.UTF8.GetString(decryptedBytes);
                }
                catch (CryptographicException ex)
                {
                    throw new InvalidOperationException("Decryption failed. Check if the private key is correct and matches the public key used for encryption.", ex);
                }
            }
        }

        private static string GetPrivateKeyPath()
        {
            System.Collections.Specialized.NameValueCollection appSettings = ConfigurationManager.AppSettings;

            string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string? privateKeyPath = appSettings["RsaPrivateKeyPath"];

            if (string.IsNullOrWhiteSpace(privateKeyPath))
                throw new InvalidOperationException("RsaPrivateKeyPath not set in app.config.");

            privateKeyPath = Path.Combine(userProfilePath, privateKeyPath);

            return privateKeyPath;
        }

    }
}
