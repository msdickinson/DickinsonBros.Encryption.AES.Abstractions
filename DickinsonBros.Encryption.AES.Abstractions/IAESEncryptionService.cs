using System;
using System.Collections.Generic;
using System.Text;

namespace DickinsonBros.Encryption.AES.Abstractions
{
    public interface IAESEncryptionService<T>
    {
        string Decrypt(byte[] encrypted);
        byte[] Encrypt(string rawString);
    }
}
