using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryWPF.Core;
using LibraryWPF.Model.DB;
using LibraryWPF.Utils;
using LibraryWPF.DAL;
using System.Windows.Input;
using LibraryWPF.ViewModels.Commands;
using System.Collections.ObjectModel;

namespace LibraryWPF.ViewModels
{
    public class SearchAuthorVM : ObservableObject//, IViewModelSuggestions
    {
        private string _authorName;
        private BookService _bookService;
        public ICommand SearchCommand { get; set; }
        public string AuthorName { get { return _authorName;} set { _authorName = value; OnPropertyChanged(); } }
        
        //TODO bind properly to view
        public ObservableCollection<KeyValuePair<string, string>> SearchResults;

        public SearchAuthorVM()
        {
            this.SearchCommand = new SearchCommand(this);
            this.SearchResults = new ObservableCollection<KeyValuePair<string, string>>();
            this._bookService = new BookService(new LibraryContext());
        }

        public void Search()
        {
            this.SearchResults.Clear();

            StringBuilder authors = new StringBuilder();

            foreach(var book in this._bookService.BooksByAuthor(AuthorName)){
                authors.Clear(); //reset string builder
                foreach(var author in book.Authors)
                {
                    authors.Append(author.Name + ", ");
                }
                //remove last ,
                authors.Length -= 2;


                this.SearchResults.Add(new KeyValuePair<string, string>(authors.ToString(), book.Title));
            }
        }
    }
}
