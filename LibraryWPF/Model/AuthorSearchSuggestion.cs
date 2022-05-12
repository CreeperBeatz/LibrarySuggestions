using LibraryWPF.Core;

namespace LibraryWPF.Model
{
    public class AuthorSearchSuggestion : ObservableObject
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public AuthorSearchSuggestion(string name)
        {
            Name = name;
        }

        public AuthorSearchSuggestion()
        {
        }

        public override bool Equals(object obj)
        {
            if (obj is AuthorSearchSuggestion other)
            {
                return Name == other.Name;
            }

            return false;
        }
    }
}