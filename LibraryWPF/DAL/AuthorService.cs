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
    public class AuthorService
    {
        private readonly LibraryContext _libraryContext;
        public AuthorService(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public void AddAuthor(Author author)
        {
            _libraryContext.Authors.Add(author);
            _libraryContext.SaveChanges();
        }
    }
}
