namespace TextFilter
{
    public class LetterTFilter : ITextFilter
    {
        public bool Filter(string word)
        {
            return word.Contains('T') || word.Contains('t');
        }
    }
}