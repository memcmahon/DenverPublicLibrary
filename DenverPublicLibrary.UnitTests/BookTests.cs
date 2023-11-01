namespace DenverPublicLibrary.UnitTests
{
    public class BookTests
    {
        [Fact]
        public void IsCreatedWithTwoArguments()
        {
            var book = new Book("Good Omens", "Terry Pratchett Neil Gaiman");

            Assert.Equal("Good Omens", book.Title);
            Assert.Equal("Terry Pratchett Neil Gaiman", book.Author);

        }
    }
}