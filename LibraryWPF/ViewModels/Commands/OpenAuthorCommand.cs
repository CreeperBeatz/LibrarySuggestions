using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryWPF.ViewModels.Commands
{
    public class OpenAuthorCommand : ICommand
    {
        private readonly MainMenuVM _mainMenuVM;

        public OpenAuthorCommand(MainMenuVM mainMenuVM)
        {
            _mainMenuVM = mainMenuVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._mainMenuVM.OpenAuthor();
        }
    }
}
