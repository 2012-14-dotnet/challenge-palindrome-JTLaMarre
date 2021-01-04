using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
        public static  UserString I = new UserString();

        

        static void Main(string[] args)
        {
           IsPal();
           
        }
        public static  void IsPal()
        {
            Console.WriteLine("Type a string to see if is palindrome");
            I.GetInput();
            
        }
    }
}