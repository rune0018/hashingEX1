// See https://aka.ms/new-console-template for more information
using hashingEX1;
using System.Security.Cryptography;
using System.Text;
Console.WriteLine("please register Username then password:");
string username = Console.ReadLine();
string password = Console.ReadLine();
hashTester a = new hashTester();
a.EncodeHash(username, password);
Console.WriteLine("please re enter ur password");
string passwrd = Console.ReadLine();
Console.WriteLine("ur password was : "+  a.VerifyHash(username,passwrd));