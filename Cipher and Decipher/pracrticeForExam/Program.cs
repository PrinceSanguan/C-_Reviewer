using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracrticeForExam
{
    internal class Program
    {

        static string Encrypt(string text, int shift)
        {
            string result = string.Empty;

            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    char encryptedChar = (char)(((ch + shift - offset) % 26) + offset);
                    result += encryptedChar;
                }
                else
                {
                    result += ch; // Non-alphabetical characters are not changed
                }
            }

            return result;
        }

        static string Decrypt(string cipherText, int shift)
        {
            string result = string.Empty;

            foreach (char ch in cipherText)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    char decryptedChar = (char)(((ch - shift - offset + 26) % 26) + offset);
                    result += decryptedChar;
                }
                else
                {
                    result += ch; // Non-alphabetical characters are not changed
                }
            }

            return result;
        }

        static void Main()
        {
            string cipherText = "Khoor, Zruog!";
            string message = "Hello, World!";
            int shift = 3;

            string plainText = Decrypt(cipherText, shift);
            string decipherText = Encrypt(message, shift);

            Console.WriteLine("Ciphertext: " + decipherText);
            Console.WriteLine("Decrypted text: " + plainText);
        }
    }

}
