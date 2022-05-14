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
    public class MainMenuVM : ObservableObject//, IViewModelSuggestions
    {
        private IViewModel _currentViewModel;
        public ICommand OpenAuthorCommand {get; set;}
        public ICommand OpenBookCommand { get; set;}
        public ICommand OpenSearchCommand { get; set;}

        public MainMenuVM()
        {
            this.OpenAuthorCommand = new OpenAuthorCommand(this);
            this.OpenBookCommand = new OpenBookCommand(this);
            this.OpenSearchCommand = new OpenSearchCommand(this);
        }

        public void OpenAuthor()
        {
            //TODO open author add window
        }

        public void OpenBook()
        {
            //TODO open book add menu
        }

        public void OpenSearch()
        {
            //TODO open search menu
        }

    }
}
