using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LibraryWPF.Core;
using LibraryWPF.DAL;
using LibraryWPF.ViewModels.Commands;

namespace LibraryWPF.ViewModels
{
    public class AddAuthorVM : ObservableObject//, IViewModelSuggestions
    {
        private string _authorName;

        public ICommand AddAuthorCommand { get; set; }

        public string AuthorName { get { return _authorName; } set { _authorName = value; OnPropertyChanged(); } }

        public AddAuthorVM()
        {
            this.AddAuthorCommand = new AddAuthorCommand(this);
        }

        public void AddAuthor()
        {
            //TODO add author to DB
            //TODO add author name to suggestions on success 
        }
    }
}
