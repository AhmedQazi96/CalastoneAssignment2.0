namespace TextFilterTests
{
    [TestClass]
    public class LengthFilterTests
    {
        private LengthFilter _filter;

        [TestInitialize]
        public void Initialize()
        {
            _filter = new LengthFilter();
        }

        [TestMethod]
        public void Filter_ReturnsTrue_WhenWordLengthIsLessThan3()
        {
            // Arrange
            string word = "hi";

            // Act
            bool result = _filter.Filter(word);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Filter_ReturnsFalse_WhenWordLengthIsEqualTo3()
        {
            // Arrange
            string word = "hey";

            // Act
            bool result = _filter.Filter(word);

            // Assert
            Assert.IsFalse(result);
        }
    }
}