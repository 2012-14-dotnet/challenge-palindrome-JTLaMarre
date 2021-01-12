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
           string a = I.GetInput();
           char[] ch = a.ToCharArray();
           Array.Reverse(ch);
           string rev = new string(ch);
           Console.WriteLine(rev);

           if(rev == a)
           {
               Console.WriteLine("It's a Palidrome!!");
               Console.WriteLine("1 to check an other word 0 to exit");
               int.TryParse(System.Console.ReadLine(), out int input);
               if(input == 1)
               {
                   IsPal();
               }
               else
               {
                   Console.WriteLine("goodbye...");
               }
           }
           else
           {
               Console.WriteLine("not a Palidrome bud :( ");
               Console.WriteLine("1 to check an other word 0 to exit");
               int.TryParse(System.Console.ReadLine(), out int input);
               if(input == 1)
               {
                   IsPal();
               }
               else
               {
                   Console.WriteLine("goodbye...");
               }
           }

            
        }
    }
}