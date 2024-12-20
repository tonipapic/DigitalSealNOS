﻿using DigitalSealNOS.Models;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DigitalSealNOS.BusinessLogic
{
    public class GenerateKeys
    {
     

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
                File.WriteAllBytes(FilePaths.SecretKeyPath, aes.Key);
            }
        }

        private void GenerateAsymmetricKeys()
        {
            using (RSA rsa = RSA.Create())
            {
                
                string publicKey = Convert.ToBase64String(rsa.ExportRSAPublicKey());
                File.WriteAllText(FilePaths.PublicKeyPath, publicKey);

           
                string privateKey = Convert.ToBase64String(rsa.ExportRSAPrivateKey());
                File.WriteAllText(FilePaths.PrivateKeyPath, privateKey);
            }
        }

        public bool DoKeysExist()
        {
            return File.Exists(FilePaths.SecretKeyPath) || File.Exists(FilePaths.PublicKeyPath) || File.Exists(FilePaths.PrivateKeyPath);
        }
        public void GenerateAndStoreKeys()
        {
            Generate();
        }
    }
}
