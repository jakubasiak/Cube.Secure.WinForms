namespace Cube.Secure.WinForms.Logic
{
    public interface ICryptoProvider
    {
        byte[] Decrypt(byte[] encrypted, string password);
        string DecryptString(string cypherText, string password);
        byte[] Encrypt(byte[] encrypted, string password);
        string EncryptString(string plainText, string password);
    }
}