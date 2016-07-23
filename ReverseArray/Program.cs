using System;
using System.Collections.Generic;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string Wrod = Console.ReadLine();
            Char[] newWord = ReverseArray(Wrod);
            Console.WriteLine(newWord);
            Console.ReadLine();
        }

        static Char[] ReverseArray(string s)
        {
            Char[] ReverseWrod = new Char[s.Length];
            Char[] newS = s.ToCharArray();

            for (int x=s.Length-1; x>=0 ; x--)
            {
                ReverseWrod[s.Length - 1 - x] = newS[x];
            }

            return (ReverseWrod);
        }     
    }
}
