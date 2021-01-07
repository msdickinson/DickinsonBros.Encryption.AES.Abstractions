namespace DickinsonBros.Encryption.AES.Abstractions
{
    public interface IAESEncryptionService<T>
    {
        string Decrypt(byte[] encrypted);
        string Decrypt(string encrypted);
        string Encrypt(string unencrypted);
        byte[] EncryptToByteArray(string unencrypted);
    }
}
