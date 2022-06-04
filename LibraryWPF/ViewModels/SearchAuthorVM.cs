using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryWPF.Core;
using LibraryWPF.Model.DB;
using LibraryWPF.Model;
using LibraryWPF.Utils;
using LibraryWPF.DAL;
using System.Windows.Input;
using LibraryWPF.ViewModels.Commands;
using System.Collections.ObjectModel;
using LibraryWPF.Interfaces;
using LibraryWPF.SuggestBoxHelpers;

namespace LibraryWPF.ViewModels
{
    public class SearchAuthorVM : ObservableObject
    {
        #region PrivateProperties
        private BookService _bookService;
        private readonly SuggestionFileManager _suggestionFileManager;
        #endregion

        #region PublicProperties
        public ICommand SearchCommand { get; set; }
        public ObservableCollection<KeyValuePair<string, string>> SearchResults { get; set; }
        public SuggestBoxCB AuthorSuggestBox { get; set; } //MUST be a property
        #endregion

        public SearchAuthorVM()
        {
            AuthorSuggestBox = new SuggestBoxCB("authordata.dat");
            SearchCommand = new SearchCommand(this);
            SearchResults = new ObservableCollection<KeyValuePair<string, string>>();
            _bookService = new BookService(new LibraryContext());
        }

        public void Search()
        {
            this.SearchResults.Clear();
            StringBuilder authors = new StringBuilder();

            foreach(var book in this._bookService.BooksByAuthor(AuthorSuggestBox.SuggestionEntry.Suggestion)){
                authors.Clear(); //reset string builder
                foreach(var author in book.Authors)
                {
                    authors.Append(author.Name + ", ");
                }
                //remove last ,
                authors.Length -= 2;

                this.SearchResults.Add(new KeyValuePair<string, string>(authors.ToString(), book.Title));
            }

            if (SearchResults.Count > 0)
            {
                //Add current SuggestionEntry text as a new suggestion
                AuthorSuggestBox.AddSuggestion();
                //Reset SuggestionText
                AuthorSuggestBox.SuggestionEntry.Suggestion = String.Empty;
            }
        }

        public void ExecuteCycleSuggestions(object parameter)
        {
        }
    }
}
