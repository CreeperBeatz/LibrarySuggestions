using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LibraryWPF.Core;

namespace LibraryWPF.Interfaces
{
    /// <summary>
    /// Class for setting up at least 1 suggestion box
    /// </summary>
    public abstract class SuggestionVMBase : ObservableObject, IViewModelSuggestions
    {
        public ICommand CycleSuggestionCommand { get; set; }
        public int SuggestionIndex { get; set; }
        public bool IsCycling { get; set; }
        public abstract void ExecuteCycleSuggestions(object parameter);

        public SuggestionBase SuggestionEntry;
    }
}
