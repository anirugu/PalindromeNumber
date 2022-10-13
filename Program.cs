using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 121;
            IsPalindrome(x);
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            int palindrome = x;
            int reverse = 0;
            while (palindrome != 0)
            {
                int remainder = palindrome % 10;
                reverse = reverse * 10 + remainder;
                palindrome = palindrome / 10;
            }
            if (x == reverse)
                return true;
            return false;
        }
    }
}
