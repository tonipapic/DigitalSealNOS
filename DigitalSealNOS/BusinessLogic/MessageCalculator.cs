using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSealNOS.BusinessLogic
{
    public class MessageCalculator
    {
        public void CalculateMessageSummary(string inputFilePath, string outputFilePath)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                using (FileStream fsInput = new FileStream(inputFilePath, FileMode.Open))
                {
                    byte[] hash = sha256.ComputeHash(fsInput);
                    string hashString = BitConverter.ToString(hash).Replace("-", "");
                    File.WriteAllText(outputFilePath, hashString);
                }
            }
        }
    }
}
