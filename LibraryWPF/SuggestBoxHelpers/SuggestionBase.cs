using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryWPF.Core;

namespace LibraryWPF.SuggestBoxHelpers
{
    /// <summary>
    /// Class for storing a single String value as a suggestion
    /// </summary>
    public class SuggestionBase : ObservableObject
    {
        private string _suggestion;

        public string Suggestion
        {
            get => _suggestion;
            set
            {
                _suggestion = value;
                OnPropertyChanged();
            }
        }

        public SuggestionBase(string suggestion)
        {
            _suggestion = suggestion;
        }

        public SuggestionBase()
        {
        }

        public override bool Equals(object obj)
        {
            if (obj is SuggestionBase other)
            {
                return Suggestion == other.Suggestion;
            }

            return false;
        }
    }
}
