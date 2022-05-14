using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryWPF.ViewModels.Commands
{
    public class AddBookCommand : ICommand
    {
        private readonly AddBookVM _addBookVM;

        public AddBookCommand(AddBookVM addBookVM) => _addBookVM = addBookVM;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._addBookVM.AddBook();
        }
    }
}
