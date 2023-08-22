using System;

namespace Text
{
    public class Str
    {
        /// <summary>
        /// Check if a string is a Palindrome
        /// </summary>
        /// <param name="s"> The string </param>
        /// <returns> Return true if the string is a Plaindrome </returns>
        public static bool IsPalindrome(string s) {
            string cleanStr = "";

            if (s == "")
                return true;

            s = s.ToLower();

            foreach (var let in s)
            {
                if (char.IsLetter(let))
                    cleanStr += let;
            }

            int i = 0;
            int j = cleanStr.Length - 1;

            for (; i < j; i++, j--)
            {
                if (cleanStr[i] != cleanStr[j])
                    return false;
            }

            return true;
        }
    }
}
