using TextFilter;

class TextFilterApp
{
    private readonly ITextReader _reader;
    private readonly TextFilterProcessor _filterProcessor;

    public TextFilterApp(ITextReader reader, TextFilterProcessor filterProcessor)
    {
        _reader = reader;
        _filterProcessor = filterProcessor;
    }

    public void Run()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string relativeFilePath = "Texts/TextInput.txt";
        string absoluteFilePath = Path.Combine(currentDirectory, relativeFilePath);

        string fileContents = string.Empty;

        try
        {
            fileContents = _reader.ReadText(absoluteFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while reading the file: " + ex.Message);
            return;
        }

        string filteredText = _filterProcessor.ApplyFilters(fileContents);

        Console.WriteLine(filteredText);
    }
}