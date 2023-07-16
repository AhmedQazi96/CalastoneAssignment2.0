using System.Text.RegularExpressions;

namespace TextFilter
{
    public class VowelInMiddleFilter : ITextFilter
    {
        public bool Filter(string word)
        {
            int length = word.Length;
            bool isEvenLength = length % 2 == 0;

            if (isEvenLength)
            {
                return CheckMiddleCharacters(word, length / 2 - 1, 2);
            }
            else
            {
                return CheckMiddleCharacters(word, length / 2, 1);
            }
        }

        private bool CheckMiddleCharacters(string word, int startIndex, int length)
        {
            string middleChars = word.Substring(startIndex, length);
            return Regex.IsMatch(middleChars, @"[aeiouAEIOU]");
        }
    }
}