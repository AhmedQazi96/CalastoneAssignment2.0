namespace TextFilter
{
    public class TextFilterProcessor
    {
        private readonly IList<ITextFilter> _filters;

        public TextFilterProcessor(IList<ITextFilter> filters)
        {
            _filters = filters;
        }

        public string ApplyFilters(string fileContents)
        {
            string[] words = fileContents.Split(' ');

            var filteredWords = words.Where(word => _filters.All(filter => !filter.Filter(word)));

            string filteredText = string.Join(" ", filteredWords);

            return filteredText;
        }
    }
}