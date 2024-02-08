using System.Security.Cryptography;
using System.Text;

namespace EncryptionDemo
{
    internal class SymmetricEncryption
    {
        public static byte[] Encrypt(string password, string dataToEncrypt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] key = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.Mode = CipherMode.CBC;

                    //// Using Empty IV
                    //aes.IV = new byte[16];

                    // Using random IV
                    aes.GenerateIV();


                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (StreamWriter writer = new StreamWriter(cryptoStream))
                            {
                                writer.Write(dataToEncrypt);
                            }
                            //// Using Empty IV
                            return memoryStream.ToArray();

                            // Using random IV
                            //return GetEncryptedDataIncludedIV(memoryStream.ToArray(), aes.IV);
                        }
                    }
                }
            }
        }

        public static string Decrypt(string password, byte[] encryptedData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] key = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.Mode = CipherMode.CBC;

                    // Using Empty IV
                    aes.IV = new byte[16];

                    //// Using random IV
                    //byte[] tempEncryptedData;
                    //(aes.IV, tempEncryptedData) = GetIV(encryptedData);
                    //encryptedData = tempEncryptedData;

                    using (MemoryStream memoryStream = new MemoryStream(encryptedData))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cryptoStream))
                            {
                                return reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }
        private static byte[] GetEncryptedDataIncludedIV(byte[] encryptedData, byte[] iv)
        {
            byte[] result = new byte[iv.Length + encryptedData.Length];
            Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
            Buffer.BlockCopy(encryptedData, 0, result, iv.Length, encryptedData.Length);
            return result;
        }

        private static (byte[], byte[]) GetIV(byte[] encryptedDataIncludingIV)
        {
            byte[] iv = new byte[16];
            byte[] encryptedData = new byte[encryptedDataIncludingIV.Length - 16];
            Buffer.BlockCopy(encryptedDataIncludingIV, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(encryptedDataIncludingIV, iv.Length, encryptedData, 0, encryptedData.Length);
            return (iv, encryptedData);
        }
    }
}
