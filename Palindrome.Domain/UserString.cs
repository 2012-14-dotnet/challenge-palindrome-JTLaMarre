using System;

namespace Palindrome.Domain
{
    public class UserString
    {
        public string Input {get;set;}

        public string GetInput(){
            Input = Console.ReadLine();
            return Input;
        }
    }
}