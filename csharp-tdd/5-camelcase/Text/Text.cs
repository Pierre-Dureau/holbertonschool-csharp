using System;

namespace Text
{
    public class Str
    {
        /// <summary>
        /// Determines how many words are in a string
        /// </summary>
        /// <param name="s"> The string </param>
        /// <returns> Number of words</returns>
        public static int CamelCase(string s) {

            int nbMaj = 0;

            if (s == "")
                return 0;

            foreach (var let in s)
            {
                if (let >= 'A' && let <= 'Z')
                    nbMaj += 1;
            }

            return nbMaj + 1;
        }
    }
}
