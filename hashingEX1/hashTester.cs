using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hashingEX1
{
    public class hashTester
    {
        private List<string> knownHashes = new List<string>();

        public hashTester()
        {
        }
        public string EncodeHash(string username ,string password)
        {
            string toHash = username + password;
            byte[] hashable = Encoding.UTF8.GetBytes(toHash);
            string result = "";
            SHA256 sha256 = SHA256.Create();
            result = Encoding.UTF8.GetString(sha256.ComputeHash(hashable));
            knownHashes.Add(result);
            return result;
        }
        public bool VerifyHash(string username ,string password)
        {
            string toHash = username + password;
            byte[] hashable = Encoding.UTF8.GetBytes(toHash);
            SHA256 sha256 = SHA256.Create();
            string result = Encoding.UTF8.GetString(sha256.ComputeHash(hashable));
            foreach (string key in knownHashes) {
                if (key.Equals(result)) { return true; }
            }
            return false;
        }
        public int GetCount()
        {
            return knownHashes.Count;
        }
    }
}
