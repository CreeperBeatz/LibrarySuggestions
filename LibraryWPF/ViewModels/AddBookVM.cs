using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LibraryWPF.Core;
using LibraryWPF.DAL;
using LibraryWPF.MVVM.Model.DB;
using LibraryWPF.ViewModels.Commands;

namespace LibraryWPF.ViewModels
{
    public class AddBookVM : ObservableObject//, IViewModelSuggestions
    {
        private string _bookName;
        private string _authors;

        public ICommand AddBookCommand { get; set; }
        public string BookName { get { return _bookName; } set { _bookName = value; OnPropertyChanged(); } }
        public string Authors { get { return _authors; } set { _authors = value; OnPropertyChanged(); } }

        public AddBookVM()
        {
            this.AddBookCommand = new AddBookCommand(this);
        }

        public void AddBook()
        {
            //TODO add book in db
        }

        private List<Author> delimitAuthors()
        {
            //delimit _authors
        }

    }
}
