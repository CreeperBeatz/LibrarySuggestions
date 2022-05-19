using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LibraryWPF.Core;
using LibraryWPF.DAL;
using LibraryWPF.Utils;
using LibraryWPF.ViewModels.Commands;
using LibraryWPF.Model;
using System.Windows;
using LibraryWPF.Model.DB;

namespace LibraryWPF.ViewModels
{
    public class AddAuthorVM : ObservableObject//, IViewModelSuggestions
    {
        private string _authorName;
        private AuthorService _authorService;
        private readonly SuggestionFileManager _suggestionFileManager;

        public ICommand AddAuthorCommand { get; set; }

        public string AuthorName { get { return _authorName; } set { _authorName = value; OnPropertyChanged(); } }

        public AddAuthorVM()
        {
            this.AddAuthorCommand = new AddAuthorCommand(this);
            this._suggestionFileManager = new SuggestionFileManager();
            this._authorService = new AuthorService(new LibraryContext());
        }

        public void AddAuthor()
        {
            try
            {
                Author author = new Author(AuthorName);
                if (this._authorService.AuthorExists(author) && AuthorName != "")
                {
                    MessageBox.Show("Author already exists!");
                    this.AuthorName = "";
                }
                else
                {
                    this._authorService.AddAuthor(author);
                    this._suggestionFileManager.AddSuggestion(new AuthorSearchSuggestion(AuthorName));
                    MessageBox.Show("Succesfully inserted Author!");
                    this.AuthorName = "";
                }
            } catch {
                MessageBox.Show("Error Occured");
            }
            //TODO add author to DB
            //TODO add author name to suggestions on success 
        }

        private void AddSuggestion(AuthorSearchSuggestion suggestion)
        {
            _suggestionFileManager.AddSuggestion(suggestion);
        }
    }
}
