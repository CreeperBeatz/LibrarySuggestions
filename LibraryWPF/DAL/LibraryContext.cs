using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryWPF.MVVM.Model.DB;
using LibraryWPF.Migrations;

namespace LibraryWPF.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryWPFDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LibraryContext, Configuration>());
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
