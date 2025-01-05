namespace HashingAndEncryption
{
    public interface IAES
    {
        string Decrypt(string cihertext, string key);
        string Encrypt(string plainText, string key);
    }
}
