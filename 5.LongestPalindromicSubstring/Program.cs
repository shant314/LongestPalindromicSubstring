using System;


namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            // To test, uncomment one of the given samples at a time or append the variable subject with a test sample.
            string subject =
          "aa";
          //"abbaxyxz";
          //"babad";
          //"zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz";
            var result = LongestPalindrome(subject);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static string LongestPalindrome(string s)
        {

            if (s.Length == 1)
                return s;

            string res = string.Empty;

            // one pair
            for (int i = 0; i < s.Length; i++)
            {
                var point = ExpandPalindrome(s, i, i);

                if (point.Length > res.Length)
                {
                    res = point;
                }
            }
            // two pairs
            for (int i = 0; i < s.Length - 1; i++)
            {
                var point = ExpandPalindrome(s, i, i + 1);

                if (point.Length > res.Length)
                {
                    res = point;
                }
            }

            return res;
        }

        public static string ExpandPalindrome(string array, int start, int end)
        {

            string res = string.Empty;

            while (start >= 0 && end < array.Length && array[start] == array[end])
            {
                res = array.Substring(start, end - start + 1);

                start--;
                end++;
            }
            return res;
        }
    }
}
/*5. Longest Palindromic Substring*/
/*Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

Example 1:

Input: "babad"
Output: "bab"
Note: "aba" is also a valid answer.
Example 2:

Input: "cbbd"
Output: "bb"*/
