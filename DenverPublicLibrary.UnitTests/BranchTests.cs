using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenverPublicLibrary.UnitTests
{
    public class BranchTests
    {
        [Fact]
        public void IsCreatedWithOneArgument()
        {
            var branch = new Branch("Belmar");

            Assert.Equal("Belmar", branch.Name);
            Assert.Equal(new List<Book>(), branch.Books);
        }

        [Fact]
        public void AddBookAddsBookObjectToListOfBooks()
        {
            var branch = new Branch("Belmar");
            var book1 = new Book("Good Omens", "Terry Pratchett Neil Gaiman");
            var book2 = new Book("the Martian", "Andy Weir");

            branch.AddBook(book1);
            branch.AddBook(book2);

            Assert.Equal(book1, branch.Books[0]);
            Assert.Equal(book2, branch.Books[1]);
        }

        [Fact]
        public void AllAuthorsReturnsListOfAllBooksAuthors()
        {
            var branch = new Branch("Belmar");
            var book1 = new Book("Good Omens", "Terry Pratchett Neil Gaiman");
            var book2 = new Book("the Martian", "Andy Weir");

            branch.AddBook(book1);
            branch.AddBook(book2);

            var expected = new List<string>() { "Terry Pratchett Neil Gaiman", "Andy Weir" };

            Assert.Equal(expected, branch.AllAuthors());
        }
    }
}
