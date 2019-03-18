using EncryptionDecryptionUsingSymmetricKey;
using System;
using System.Security.Cryptography;

namespace Encryption_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            Console.WriteLine("Şifrelenecek bir değer giriniz:");
            var str = Console.ReadLine();
            var encryptedString = MyClass.EncryptString(key, str);
            Console.WriteLine($"Şifrelenmiş = {encryptedString}");

            var decryptedString = MyClass.DecryptString(key, encryptedString);
            Console.WriteLine($"Çözülmüş = {decryptedString}");

            Console.ReadKey();
        }
    }
}
