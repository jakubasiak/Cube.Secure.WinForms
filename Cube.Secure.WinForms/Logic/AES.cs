using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Cube.Secure.WinForms.Logic
{
    public partial class AES : ICryptoProvider
    {
        private readonly AesCryptoServiceProvider aes;

        public AES()
        {
            this.aes = new AesCryptoServiceProvider();
            this.aes.KeySize = 256;
            this.aes.BlockSize = 128;
        }
        public AES(AESKeySize keySize)
        {
            this.aes = new AesCryptoServiceProvider();
            this.aes.KeySize = (int)keySize;
        }


        public byte[] ConvertFile(byte[] plain, string password, AESProcess process)
        {
            try
            {
                using (var pass = new PasswordDeriveBytes(password, this.GenerateSalt(this.aes.BlockSize / 8, password)))
                {
                    using (var stream = new MemoryStream())
                    {
                        this.aes.Key = pass.GetBytes(this.aes.KeySize / 8);
                        this.aes.IV = pass.GetBytes(this.aes.BlockSize / 8);

                        var proc = (process == AESProcess.Encryption) ? this.aes.CreateEncryptor() : this.aes.CreateDecryptor();
                        using (var crypto = new CryptoStream(stream, proc, CryptoStreamMode.Write))
                        {
                            crypto.Write(plain, 0, plain.Length);
                            crypto.Clear();
                            crypto.Close();
                        }
                        stream.Close();
                        return stream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public byte[] Encrypt(byte[] encrypted, string password)
        {
            return this.ConvertFile(encrypted, password, AESProcess.Encryption);
        }

        public byte[] Decrypt(byte[] encrypted, string password)
        {
            return this.ConvertFile(encrypted, password, AESProcess.Decryptopn);
        }

        public string EncryptString(string plainText, string password, bool withCompression)
        {
            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = this.ConvertFile(data, password, AESProcess.Encryption);
            return Convert.ToBase64String(cypher);
        }

        public string DecryptString(string cypherText, string password, bool withCompression)
        {
            var data = Convert.FromBase64String(cypherText);
            var plainText = this.ConvertFile(data, password, AESProcess.Decryptopn);
            return Encoding.Unicode.GetString(plainText);
        }

        private byte[] GenerateSalt(int size, string password)
        {
            var buffer = new byte[size];
            var passBytes = ASCIIEncoding.ASCII.GetBytes(password);

            if (passBytes.Length > buffer.Length) Array.Copy(passBytes, buffer, buffer.Length);
            else Array.Copy(passBytes, buffer, passBytes.Length);

            return buffer;
        }
    }
}
