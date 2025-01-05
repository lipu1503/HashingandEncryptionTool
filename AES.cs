using System.Security.Cryptography;

namespace HashingAndEncryption
{
    public class AES : IAES
    {
        private readonly int _saltSize = 32;
        public string Decrypt(string cihertext, string passPhrase)
        {
            if (string.IsNullOrEmpty(cihertext))
            {
                throw new ArgumentNullException(cihertext);
            }
            if (string.IsNullOrEmpty(passPhrase))
            {
                throw new ArgumentNullException(passPhrase);
            }
            var allTheBytes = Convert.FromBase64String(cihertext);
            var saltBytes = allTheBytes.Take(_saltSize).ToArray();
            var ciphertextBytes = allTheBytes.Skip(_saltSize).Take(allTheBytes.Length - _saltSize).ToArray();
            using (var keyDerivationFunction = new Rfc2898DeriveBytes(passPhrase, saltBytes))
            {
                var keyBytes = keyDerivationFunction.GetBytes(32);
                var ivBytes = keyDerivationFunction.GetBytes(16);
                return DecryptWithAES(ciphertextBytes, keyBytes, ivBytes);
            }
        }



        private string DecryptWithAES(byte[] ciphertextBytes, byte[] keyBytes, byte[] ivBytes)
        {
            using (var aesManaged = new AesManaged())
            {
                using (var decryptor = aesManaged.CreateDecryptor(keyBytes, ivBytes))
                {
                    MemoryStream memoryStream = null;
                    CryptoStream cryptoStream = null;
                    StreamReader streamReader = null;
                    try
                    {
                        memoryStream = new MemoryStream(ciphertextBytes);
                        cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                        streamReader = new StreamReader(cryptoStream);
                        return streamReader.ReadToEnd();
                    }
                    finally
                    {
                        if (memoryStream is not null)
                        {
                            memoryStream?.Dispose();
                            memoryStream = null;
                        }
                    }
                }
            }
        }
        private string WriteMemoryStream(string plainText, ref byte[] saltBytes, ICryptoTransform encryptor, ref MemoryStream? memoryStream, ref CryptoStream? cryptoStream)
        {
            try
            {
                memoryStream = new MemoryStream();
                try
                {
                    cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                    using (var streamWriter = new StreamWriter(memoryStream))
                    {
                        streamWriter.Write(plainText);
                    }

                }
                finally
                {
                    if(cryptoStream is not null)
                    {
                        cryptoStream.Dispose();
                    }

                }
                var cipherTextBytes = memoryStream.ToArray();
                Array.Resize(ref saltBytes, saltBytes.Length + cipherTextBytes.Length);
                Array.Copy(cipherTextBytes, 0, saltBytes, _saltSize, cipherTextBytes.Length);
                return Convert.ToBase64String(saltBytes);
            }
            finally
            {
                if(memoryStream is not null)
                {
                    memoryStream.Dispose();
                }

            }

        }
        public string Encrypt(string plainText, string passPhrase)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                throw new ArgumentNullException(plainText);
            }
            if (string.IsNullOrEmpty(passPhrase))
            {
                throw new ArgumentNullException(passPhrase);
            }
            using (var keyDerivationFunction = new Rfc2898DeriveBytes(passPhrase, _saltSize))
            {
                byte[] saltBytes = keyDerivationFunction.Salt;
                byte[] keyBytes = keyDerivationFunction.GetBytes(32);
                byte[] ivBytes = keyDerivationFunction.GetBytes(32);
                using (var aesManaged = new AesManaged())
                {
                    aesManaged.KeySize = 256;
                    using (var encryptor = aesManaged.CreateEncryptor(keyBytes, ivBytes))
                    {
                        MemoryStream memoryStream = null;
                        CryptoStream cryptoStream = null;
                        return WriteMemoryStream(plainText, ref saltBytes, encryptor, ref memoryStream, ref cryptoStream);
                    }

                }
            }
        }

    }
}

       
    
