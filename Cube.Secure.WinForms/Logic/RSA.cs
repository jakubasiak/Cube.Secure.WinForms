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
            this.rsa = new RSACryptoServiceProvider(2048);
        }

        public RSA(RSAKeySize keySize)
        {
            this.rsa = new RSACryptoServiceProvider((int)keySize);
        }

        public byte[] Decrypt(byte[] encrypted, string key)
        {
            this.rsa.ImportRSAPrivateKey(this.ImportKey(key), out _);
            return this.rsa.Decrypt(encrypted, false);
        }

        public string DecryptString(string cypherText, string key, bool withCompressin)
        {
            this.rsa.ImportRSAPrivateKey(this.ImportKey(key), out _);
            var data = Convert.FromBase64String(cypherText);
            var plainText = this.rsa.Decrypt(data, false);
            return withCompressin ? ZipHelper.Unzip(plainText) : Encoding.Unicode.GetString(plainText);
        }

        public byte[] Encrypt(byte[] encrypted, string key)
        {
            this.rsa.ImportRSAPublicKey(this.ImportKey(key),  out _);
            return this.rsa.Encrypt(encrypted, false);
        }

        public string EncryptString(string plainText, string key, bool withCompressin)
        {
            this.rsa.ImportRSAPublicKey(this.ImportKey(key), out _);
            var data = withCompressin ? ZipHelper.Zip(plainText) : Encoding.Unicode.GetBytes(plainText);
            var cypher = this.rsa.Encrypt(data, false);
            return Convert.ToBase64String(cypher);
        }

        public string ExportPublicKey()
        {
            var key = Convert.ToBase64String(this.rsa.ExportRSAPublicKey());
            var sb = new StringBuilder();
            sb.AppendLine("-----BEGIN RSA PRIVATE KEY-----");
            sb.AppendLine(key);
            sb.AppendLine("-----END RSA PRIVATE KEY-----");
            return sb.ToString();
        }

        public string ExportPrivateKey()
        {
            var key = Convert.ToBase64String(this.rsa.ExportRSAPrivateKey());
            var sb = new StringBuilder();
            sb.AppendLine("-----BEGIN RSA PUBLIC KEY-----");
            sb.AppendLine(key);
            sb.AppendLine("-----END RSA PUBLIC KEY-----");
            return sb.ToString();
        }

        public byte[] ImportKey(string key)
        {
            var te = key.Split("\n")[1];
            return Convert.FromBase64String(te);
        }
    }
}
