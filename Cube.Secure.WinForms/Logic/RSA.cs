using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Cube.Secure.WinForms.Logic
{
    public class RSA : ICryptoProvider
    {
        private readonly RSACryptoServiceProvider rsa;

        public RSA()
        {
            this.rsa = new RSACryptoServiceProvider();
            this.rsa.KeySize = 2048;
        }

        public RSA(RSAKeySize keySize)
        {
            this.rsa = new RSACryptoServiceProvider();
            this.rsa.KeySize = (int)keySize;
        }

        public byte[] Decrypt(byte[] encrypted, string key)
        {
            this.rsa.FromXmlString(key);
            return this.rsa.Decrypt(encrypted, true);
        }

        public string DecryptString(string cypherText, string key)
        {
            this.rsa.FromXmlString(key);
            var data = Convert.FromBase64String(cypherText);
            var plainText = this.rsa.Decrypt(data, false);
            return Encoding.Unicode.GetString(plainText);
        }

        public byte[] Encrypt(byte[] encrypted, string key)
        {
            this.rsa.FromXmlString(key);
            return this.rsa.Encrypt(encrypted, true);
        }

        public string EncryptString(string plainText, string key)
        {
            this.rsa.FromXmlString(key);
            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = this.rsa.Encrypt(data, true);
            return Convert.ToBase64String(cypher);
        }

        public string GetPublicKey()
        {
            return this.rsa.ToXmlString(false);
        }

        public string GetPrivateKey()
        {
            return this.rsa.ToXmlString(true);
        }
    }
}
