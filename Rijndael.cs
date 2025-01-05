using System.Security.Cryptography;
using System.Text;
namespace HashingAndEncryption
{
    public class Rijndael : IRijndael
    {
        private string passPhrase = "PACSAPP.Key";
        private string saltValue = "s@Value";
        private string hasAlgorithm = "SHA1";
        private int PasswordIterations = 2;
        private string initVector = "@1B2c3D4e5F6g7H8";
        private int keySize = 256;

        private byte[] initVectorbytes;
        private byte[] saltValuebytes;
        private byte[] keyBytes;
        private PasswordDeriveBytes password;
        private AesManaged symmetricKey;

        public Rijndael()
        {
            initVectorbytes = Encoding.ASCII.GetBytes(initVector);
            saltValuebytes = Encoding.ASCII.GetBytes(saltValue);

            password = new PasswordDeriveBytes(passPhrase, saltValuebytes, hasAlgorithm, PasswordIterations);
            keyBytes = password.GetBytes(keySize / 8);
            symmetricKey = new AesManaged();
            symmetricKey.Mode = CipherMode.CBC;
        }
        public Rijndael(string passPhrase)
        {
            initVectorbytes = Encoding.ASCII.GetBytes(initVector);
            saltValuebytes = Encoding.ASCII.GetBytes(saltValue);

            password = new PasswordDeriveBytes(passPhrase, saltValuebytes, hasAlgorithm, PasswordIterations); ;
            keyBytes = password.GetBytes(keySize / 8);
            symmetricKey = new AesManaged();
            symmetricKey.Mode = CipherMode.CBC;

        }
        

        public string Encrypt(string planText)
        {
            byte[] planTextBytes = Encoding.UTF8.GetBytes(planText);
            byte[] cipherTextBytes;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorbytes);
            using MemoryStream memorystream = new MemoryStream();
            using CryptoStream   cryptoStream = new CryptoStream(memorystream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(planTextBytes,0, planTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            cipherTextBytes = memorystream.ToArray();
            cryptoStream.Close();
            string cipherText = Convert.ToBase64String(cipherTextBytes);
            return cipherText;
        }
        public string Decrypt(string cipherText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            byte[] planTextBytes;
            int decryptedByteCount;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorbytes);
            using MemoryStream memorystream = new MemoryStream();
            using CryptoStream cryptoStream = new CryptoStream(memorystream, decryptor, CryptoStreamMode.Read);
            planTextBytes = new byte[cipherTextBytes.Length];
            decryptedByteCount = cryptoStream.Read(planTextBytes, 0, planTextBytes.Length);
            cryptoStream.Close();
            string plainText = Encoding.UTF8.GetString(planTextBytes,0,decryptedByteCount);
            return plainText;
        }
    }
}
