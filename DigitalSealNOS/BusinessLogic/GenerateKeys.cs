using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DigitalSealNOS.BusinessLogic
{
    public class GenerateKeys
    {
        private readonly string symmetricKeyPath = "tajni_kljuc.txt";
        private readonly string publicKeyPath = "javni_kljuc.txt";
        private readonly string privateKeyPath = "privatni_kljuc.txt";

        private void Generate()
        {
            try
            {
                GenerateSymmetricKey();
                GenerateAsymmetricKeys();
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework)
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void GenerateSymmetricKey()
        {
            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                File.WriteAllBytes(symmetricKeyPath, aes.Key);
            }
        }

        private void GenerateAsymmetricKeys()
        {
            using (RSA rsa = RSA.Create())
            {
                
                string publicKey = Convert.ToBase64String(rsa.ExportRSAPublicKey());
                File.WriteAllText(publicKeyPath, publicKey);

           
                string privateKey = Convert.ToBase64String(rsa.ExportRSAPrivateKey());
                File.WriteAllText(privateKeyPath, privateKey);
            }
        }

        public void GenerateAndStoreKeys()
        {
            Generate();
        }
    }
}
