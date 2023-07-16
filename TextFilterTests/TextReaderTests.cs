namespace TextFilterTests
{
    [TestClass]
    public class TextReaderTests
    {
        private TextFilter.TextReader _textReader;
        private string _testFilePath;

        [TestInitialize]
        public void Initialize()
        {
            _textReader = new TextFilter.TextReader();

            string currentDirectory = Directory.GetCurrentDirectory();
            string relativeFilePath = "TestTexts\\TestInputText.txt";
            _testFilePath = Path.Combine(currentDirectory, relativeFilePath);
        }

        [TestMethod]
        public void ReadText_FileFound_ReturnsExpectedString()
        {
            // Arrange
            string expectedText = "Line 1\r\nLine 2\r\n";

            // Act
            string result = _textReader.ReadText(_testFilePath);

            // Assert
            Assert.AreEqual(expectedText, result);
        }
    }
}