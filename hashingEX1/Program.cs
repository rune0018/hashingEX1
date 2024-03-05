// See https://aka.ms/new-console-template for more information
using hashingEX1;

Console.WriteLine("please register Username then password:");
string username = Console.ReadLine();
string password = Console.ReadLine();
hashTester a = new hashTester();
a.EncodeHash(username, password);
Console.WriteLine("please re enter ur password");
string passwrd = Console.ReadLine();
Console.WriteLine("ur password was : "+  a.VerifyHash(username,passwrd));
Console.WriteLine("user to remove Requires username and password");
string username2 = Console.ReadLine();
string password2 = Console.ReadLine();
a.DeleteUser(username2,password2);
Console.WriteLine("remaining hashes are " + a.GetCount());