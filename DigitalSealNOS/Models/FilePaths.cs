using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSealNOS.Models
{
    public static class FilePaths
    {
        public static string SecretKeyPath { get; } = "tajni_kljuc.txt";
        public static string PublicKeyPath { get; } = "javni_kljuc.txt";
        public static string PrivateKeyPath { get; } = "privatni_kljuc.txt";
    }
}
