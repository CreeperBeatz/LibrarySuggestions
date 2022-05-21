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

namespace LibraryWPF.ViewModels
{
    public class SearchAuthorVM : ObservableObject, IViewModelSuggestions
    {
        #region PrivateProperties
        private string _authorName;
        private BookService _bookService;
        private readonly SuggestionFileManager _suggestionFileManager;
        private List<AuthorSearchSuggestion> _allSuggestions;
        private List<AuthorSearchSuggestion> _suggestions;
        private KeyValuePair<object, string> _authorPair;
        private string _bestSuggestion;
        private AuthorSearchSuggestion _suggestionEntry;
        //private AuthorSearchSuggestion _selectedAuthor;
        private IViewModel _currentViewModel;
        private IViewModel _currentViewModelParent;
        #endregion

        #region PublicProperties
        public ICommand CycleSuggestionCommand { get; set; }
        public int SuggestionIndex { get; set; }
        public bool IsCycling { get; set; }
        public ICommand SearchCommand { get; set; }
        public string AuthorName { get { return _authorName; } set { _authorName = value; OnPropertyChanged(); } }
        public string BestSuggestion
        {
            get => _bestSuggestion;
            set
            {
                _bestSuggestion = value;
                OnPropertyChanged();
            }
        }
        public List<AuthorSearchSuggestion> Suggestions
        {
            get => _suggestions;
            set
            {
                _suggestions = value;
                OnPropertyChanged();
                if (!_suggestions.Any())
                {
                    BestSuggestion = string.Empty;
                    return;
                }
                var _first = _suggestions.First();
                BestSuggestion = SuggestionEntry?.Name?.Length >= 3 ? _first.Name : string.Empty;
            }
        }
        public KeyValuePair<object, string> AuthorPair
        {
            get => _authorPair;
            set
            {
                _authorPair = value;
                OnPropertyChanged();
            }
        }
        /*
        public AuthorSearchSuggestion SelectedAuthor
        {
            get => _selectedAuthor;
            set
            {
                _selectedAuthor = value;
                this.AuthorName = value.Name;
                OnPropertyChanged();
            }
        }*/
        public AuthorSearchSuggestion SuggestionEntry
        {
            get => _suggestionEntry;
            set
            {
                _suggestionEntry = value;
                if(_suggestionEntry != null)
                {
                    if(_suggestionEntry.Name != null)
                        Suggestions = _allSuggestions.Where(s => s.Name.Contains(_suggestionEntry.Name)).ToList();
                }
                OnPropertyChanged();
            }
        }
        public ObservableCollection<KeyValuePair<string, string>> SearchResults { get; set; }
        public IViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }
        public IViewModel CurrentViewModelParent
        {
            get => _currentViewModelParent;
            set { _currentViewModelParent = value; OnPropertyChanged(); }
        }
        #endregion

        public SearchAuthorVM()
        {
            _suggestionFileManager = new SuggestionFileManager();
            _allSuggestions = _suggestionFileManager.GetSuggestions();
            SuggestionEntry = new AuthorSearchSuggestion();
            Suggestions ??= new List<AuthorSearchSuggestion>();
            AuthorPair = new KeyValuePair<object, string>(_suggestionEntry, "AuthorName");
            CurrentViewModelParent = this;
            CurrentViewModel = this;
            SearchCommand = new SearchCommand(this);
            SearchResults = new ObservableCollection<KeyValuePair<string, string>>();
            _bookService = new BookService(new LibraryContext());
            CycleSuggestionCommand = new CycleSuggestionCommand(this);
        }

        public bool CanExecute()
        {
            return SuggestionEntry != null
                && !string.IsNullOrEmpty(SuggestionEntry.Name);
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

        public void ExecuteCycleSuggestions(object parameter)
        {
            /*
            if (!_suggestions.Any()) return;
            int index = SuggestionIndex + int.Parse((string)parameter);
            index = index % Math.Min(5, _suggestions.Count); //HARD CODED, replace 5 with settings
            IsCycling = true;
            if (index < 0)
                index = _suggestions.Count - 1;
            SuggestionEntry = _suggestions[index];
            SuggestionIndex = index;
            BestSuggestion = _suggestions[index];
            */
        }
    }
}
