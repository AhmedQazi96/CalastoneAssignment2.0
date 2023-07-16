namespace TextFilterTests
{
    [TestClass]
    public class LetterTFilterTests
    {
        private LetterTFilter _filter;

        [TestInitialize]
        public void Initialize()
        {
            _filter = new LetterTFilter();
        }

        [TestMethod]
        public void Filter_ReturnsTrue_WhenWordContainsUppercaseT()
        {
            // Arrange
            string word = "Test";

            // Act
            bool result = _filter.Filter(word);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Filter_ReturnsTrue_WhenWordContainsLowercaseT()
        {
            // Arrange
            string word = "test";

            // Act
            bool result = _filter.Filter(word);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Filter_ReturnsFalse_WhenWordDoesNotContainT()
        {
            // Arrange
            string word = "none";

            // Act
            bool result = _filter.Filter(word);

            // Assert
            Assert.IsFalse(result);
        }
    }
}