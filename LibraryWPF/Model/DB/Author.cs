using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWPF.MVVM.Model.DB
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public Author(string name)
        {
            Name = name;
        }
#nullable disable

        public Author()
        {
            Name = "Default";
        }
    }
}
