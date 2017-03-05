using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encryption
{
    public class EncryptionSHA
    {
        private static string addedPassword = "^Y8~JJ@sha";

        public string getHashedPassword(string rawPassword)
        {
            string password = "";
            SHA512 sha = SHA512.Create();
            byte[] result = sha.ComputeHash(Encoding.UTF8.GetBytes(rawPassword + addedPassword));
            password = Encoding.UTF8.GetString(result);
            return password;
        }

        public bool doesPasswordMatch(string rawPassword, string destinationPassword)
        {
            string tmp = getHashedPassword(rawPassword);
            return tmp.Equals(destinationPassword);
        }
    }
}
