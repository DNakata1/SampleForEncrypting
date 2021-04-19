using System;
using System.Collections.Generic;

namespace Crypting
{
    class Program
    {
        class Encrypting
        {
            public char RandomNum(char random)
            {
                Random rand = new Random();
                int rnd = rand.Next(-7, 7);
                char result;
                return result = (char)(random + rnd);
            }
            public void EncryptFun(String Str)
            {
                char[] charOf = Str.ToCharArray();
                char EmptyChar;
                List<char> CharOutput = new List<char>();
                foreach (char x in charOf)
                {
                    EmptyChar = RandomNum(x);
                    CharOutput.Add(EmptyChar);
                }
                Console.WriteLine("Encrypted: "+String.Join("", CharOutput));
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the string here:");
            String input = Console.ReadLine();
            Encrypting En = new Encrypting();
            En.EncryptFun(input);
            Console.Read();
        }
    }
}
