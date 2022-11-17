using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace Assignment8
{
    internal class Encryption
    {
        // Encrypt a file.
        public static void AddEncryption(string FileName)
        {

            File.Encrypt(FileName);
        }

        // Decrypt a file.
        public static void RemoveEncryption(string FileName)
        {
            File.Decrypt(FileName);
        }
    }
}
