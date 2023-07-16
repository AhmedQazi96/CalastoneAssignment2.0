using SimpleInjector;
using TextFilter;

try
{
    var container = ConfigureContainer();

    var textFilterApp = container.GetInstance<TextFilterApp>();

    container.Dispose();

    textFilterApp.Run();
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}

static Container ConfigureContainer()
{
    var container = new Container();
    container.Register<TextFilterApp>();
    container.Register<TextFilterProcessor>();
    container.Register<ITextReader, TextFilter.TextReader>();
    container.Collection.Register<ITextFilter>(typeof(VowelInMiddleFilter), typeof(LengthFilter), typeof(LetterTFilter));

    container.Verify();

    return container;
}