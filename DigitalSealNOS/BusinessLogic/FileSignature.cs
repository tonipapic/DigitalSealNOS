using DigitalSealNOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSealNOS.BusinessLogic
{
    public class FileSignature
    {
        public void SignFile(string inputFilePath, string signatureFilePath)
        {
            byte[] privateKey = Convert.FromBase64String(File.ReadAllText(FilePaths.PrivateKeyPath));
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportRSAPrivateKey(privateKey, out _);
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] data = File.ReadAllBytes(inputFilePath);
                    byte[] hash = sha256.ComputeHash(data);
                    byte[] signature = rsa.SignHash(hash, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                    File.WriteAllBytes(signatureFilePath, signature);
                }
            }
        }

        public bool VerifyFileSignature(string inputFilePath, string signatureFilePath)
        {
            byte[] publicKey = Convert.FromBase64String(File.ReadAllText(FilePaths.PublicKeyPath));
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportRSAPublicKey(publicKey, out _);
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] data = File.ReadAllBytes(inputFilePath);
                    byte[] hash = sha256.ComputeHash(data);
                    byte[] signature = File.ReadAllBytes(signatureFilePath);
                    return rsa.VerifyHash(hash, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                }
            }
        }
    }
}
