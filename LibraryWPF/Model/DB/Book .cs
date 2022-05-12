using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWPF.MVVM.Model.DB
{
    public class Book
    {
        [Key]
        public int MagazineId { get; set; }
        public string Title { get; set; }
#nullable enable
        public List<Author> Authors { get; set; }

        public Book(string title, List<Author> authors)
        {
            Title = title;
            Authors = authors;
        }

    }
}
