namespace TextFilter
{
    public class LengthFilter : ITextFilter
    {
        public bool Filter(string word)
        {
            return word.Length < 3;
        }
    }
}