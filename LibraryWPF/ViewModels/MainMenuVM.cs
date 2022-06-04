using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryWPF.Core;
using LibraryWPF.Model.DB;
using LibraryWPF.Utils;
using System.Windows.Input;
using LibraryWPF.ViewModels.Commands;
using LibraryWPF.Views;
using System.Windows;

namespace LibraryWPF.ViewModels
{
    public class MainMenuVM : ObservableObject
    {
        public ICommand OpenAuthorCommand {get; set;}
        public ICommand OpenBookCommand { get; set;}
        public ICommand OpenSearchCommand { get; set;}
        public MainMenuVM()
        {
            this.OpenAuthorCommand = new OpenAuthorCommand(this);
            this.OpenBookCommand = new OpenBookCommand(this);
            this.OpenSearchCommand = new OpenSearchCommand(this);
        }

        public void OpenAuthor()
        {
            AddAuthor addAuthor = new AddAuthor();
            addAuthor.Show();
        }

        public void OpenBook()
        {
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        public void OpenSearch()
        {
            SearchAuthor searchAuthor = new SearchAuthor();
            searchAuthor.Show();
        }

    }
}
