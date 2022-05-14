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

namespace LibraryWPF.ViewModels
{
    public class SearchAuthorVM : ObservableObject//, IViewModelSuggestions
    {
        private string _authorName;

        public ICommand SearchCommand { get; set; }
        public string AuthorName { get { return _authorName;} set { _authorName = value; OnPropertyChanged(); } }

        public SearchAuthorVM()
        {
            this.SearchCommand = new SearchCommand(this);
        }

        public void Search()
        {
            //TODO filter based on authorname
        }
    }
}
