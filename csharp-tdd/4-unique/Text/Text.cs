using System;
namespace Text
{
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character of a string
        /// </summary>
        /// <param name="s"> The string </param>
        /// <returns> The index or -1 </returns>
        public static int UniqueChar(string s) {
            int count = 0;

            if (s == "")
                return -1;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        count++;
                }

                if (count == 1)
                    return i;
                else
                    count = 0;
            }

            return -1;
        }
    }
}
