using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryWPF.ViewModels.Commands
{
    public class SearchCommand : ICommand
    {
        private readonly SearchAuthorVM _searchAuthorVM;

        public SearchCommand(SearchAuthorVM searchAuthorVM)
        {
            _searchAuthorVM = searchAuthorVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._searchAuthorVM.Search();
        }
    }
}
