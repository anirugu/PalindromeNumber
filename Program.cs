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
            if (x == 0)
                return false;

            int reverse = 0;
            int palindrom = x;
            while (palindrom != 0)
            {
                int remainder = palindrom % 10;
                reverse = reverse * 10 + remainder;
                palindrom = palindrom / 10;
            }

            return reverse == x;
        }
    }
}
