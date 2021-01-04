using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
           UserString I = new UserString();

           I.GetInput();

           Console.WriteLine(I.Input);
        }
    }
}