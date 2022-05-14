using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryWPF.ViewModels.Commands
{
    public class AddAuthorCommand : ICommand
    {
        private readonly AddAuthorVM _addAuthorVM;

        public AddAuthorCommand(AddAuthorVM addAuthorVM)
        {
            _addAuthorVM = addAuthorVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._addAuthorVM.AddAuthor();
        }
    }
}
