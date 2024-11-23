using DigitalSealNOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSealNOS.BusinessLogic
{
    internal class EncryptDecryptFiles
    {
        public void EncryptFile(string inputFilePath, string outputFilePath)
        {
            byte[] key = File.ReadAllBytes(FilePaths.SymmetricKeyPath);
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.GenerateIV();
                byte[] iv = aes.IV;

                using (FileStream fsOutput = new FileStream(outputFilePath, FileMode.Create))
                {
                    fsOutput.Write(iv, 0, iv.Length);
                    using (CryptoStream cs = new CryptoStream(fsOutput, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (FileStream fsInput = new FileStream(inputFilePath, FileMode.Open))
                        {
                            fsInput.CopyTo(cs);
                        }
                    }
                }
            }
        }

        public void DecryptFile(string inputFilePath, string outputFilePath)
        {
            byte[] key = File.ReadAllBytes(FilePaths.SymmetricKeyPath);
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;

                using (FileStream fsInput = new FileStream(inputFilePath, FileMode.Open))
                {
                    byte[] iv = new byte[aes.BlockSize / 8];
                    fsInput.Read(iv, 0, iv.Length);
                    aes.IV = iv;

                    using (CryptoStream cs = new CryptoStream(fsInput, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (FileStream fsOutput = new FileStream(outputFilePath, FileMode.Create))
                        {
                            cs.CopyTo(fsOutput);
                        }
                    }
                }
            }
        }
    }
}
