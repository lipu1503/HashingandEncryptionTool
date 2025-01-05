namespace HashingAndEncryption
{
    public interface IRijndael
    {
        string Encrypt(string planText);
        string Decrypt(string cipherText);
    }
}
