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
            string result = gethashedvalue(toHash);
            knownHashes.Add(result);
            return result;
        }
        public bool VerifyHash(string username ,string password)
        {
            string toHash = username + password;
            string result = gethashedvalue(toHash);
            foreach (string key in knownHashes) {
                if (key.Equals(result)) { return true; }
            }
            return false;
        }
        public void DeleteUser(string username,string password) 
        {
            string toremove = gethashedvalue(username + password);
            knownHashes.Remove(toremove);
        }

        private string gethashedvalue(string combined)
        {
            byte[] hashable = Encoding.UTF8.GetBytes(combined);
            SHA256 sha256 = SHA256.Create();
            return Encoding.UTF8.GetString(sha256.ComputeHash(hashable));
        }
        public int GetCount()
        {
            return knownHashes.Count;
        }
    }
}
