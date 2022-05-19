using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using LibraryWPF.Model.DB;
using LibraryWPF.Utils;

namespace LibraryWPF.DAL
{
    public class BookService
    {
        private readonly LibraryContext _libraryContext;

        public BookService(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public void AddBook(Book book)
        {
            _libraryContext.Books.Add(book);
            _libraryContext.SaveChanges();
        }

        public bool BookExists(Book book)
        {
            return _libraryContext.Books.Any(x => x.Title == book.Title);
        }

        public IEnumerable<Book> BooksByAuthor(string authorName)
        {
            var query = from book in _libraryContext.Books.Include(m => m.Authors) 
                        where book.Authors.Any(author => author.Name == authorName)
                        select book;

            return query.ToList();
        }
    }
}
