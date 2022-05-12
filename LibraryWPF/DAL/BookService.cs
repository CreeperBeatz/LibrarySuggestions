using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using LibraryWPF.MVVM.Model.DB;
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
    }
}
