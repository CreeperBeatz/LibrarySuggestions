using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryWPF.Utils;
using LibraryWPF.Core;
using LibraryWPF.Model;
using System.Windows.Input;
using System.Collections.ObjectModel;
using LibraryWPF.Interfaces;
using LibraryWPF.SuggestBoxHelpers.Commands;

namespace LibraryWPF.SuggestBoxHelpers
{
    /// <summary>
    /// Make an instance of this class in your ViewModel(must inherit Observable Object)
    /// to bind a SuggestBox control.
    /// In the WPF View, bind the attributes as it follows:
    /// 
    /// <list type="number">
    /// <item>
    ///     Items="{Binding SuggestBoxCBInstance.Suggestions}"
    /// </item>
    /// <item>
    ///     ValueMember="{Binding SuggestBoxCBInstance.SuggestionPair}"
    /// </item>
    /// <item>
    ///     AutoSuggest="{Binding SuggestBoxCBInstance.BestSuggestion}"
    /// </item>
    /// <item>
    ///     Text="{Binding SuggestBoxCBInstance.SuggestionEntry, UpdateSourceTrigger=PropertyChanged, Mode=TwoWay}"
    /// </item>
    /// </list>
    /// 
    /// Possible improvements:
    /// Remove the need for SuggestionBase (remake of Utils/SuggestionFileManager will also be needed)
    /// </summary>
    public class SuggestBoxCB : ObservableObject, IViewModelSuggestions
    {
        #region PrivateProperties
        private string _suggestion;
        private readonly SuggestionFileManager _suggestionFileManager;
        private List<SuggestionBase> _allSuggestions;
        private List<SuggestionBase> _suggestions;
        private KeyValuePair<object, string> _suggestionPair;
        private string _bestSuggestion;
        private SuggestionBase _suggestionEntry;
        #endregion

        #region PublicProperties
        public ICommand CycleSuggestionCommand { get; set; }
        public int SuggestionIndex { get; set; }
        public bool IsCycling { get; set; }
        public string Suggestion { get { return _suggestion; } set { _suggestion = value; OnPropertyChanged(); } }
        public string BestSuggestion
        {
            get => _bestSuggestion;
            set
            {
                _bestSuggestion = value;
                OnPropertyChanged();
            }
        }
        public List<SuggestionBase> Suggestions
        {
            get => _suggestions;
            set
            {
                _suggestions = value;
                OnPropertyChanged();
                if (!_suggestions.Any())
                {
                    BestSuggestion = string.Empty;
                    return;
                }
                var _first = _suggestions.First();
                BestSuggestion = SuggestionEntry?.Suggestion?.Length >= 3 ? _first.Suggestion : string.Empty;
            }
        }
        public KeyValuePair<object, string> SuggestionPair
        {
            get => _suggestionPair;
            set
            {
                _suggestionPair = value;
                OnPropertyChanged();
            }
        }
        public SuggestionBase SuggestionEntry
        {
            get => _suggestionEntry;
            set
            {
                _suggestionEntry = value;
                if (_suggestionEntry != null)
                {
                    if (_suggestionEntry.Suggestion != null)
                        Suggestions = _allSuggestions.Where(s => s.Suggestion.Contains(_suggestionEntry.Suggestion)).ToList();
                }
                OnPropertyChanged();
            }
        }
        public void ExecuteCycleSuggestions(object parameter)
        {
            //TODO
        }
        #endregion

        public SuggestBoxCB(string suggestionFilePath)
        {
            _suggestionFileManager = new SuggestionFileManager(suggestionFilePath);
            _allSuggestions = _suggestionFileManager.GetSuggestions();
            SuggestionEntry = new SuggestionBase();
            Suggestions ??= new List<SuggestionBase>();
            SuggestionPair = new KeyValuePair<object, string>(_suggestionEntry, "Suggestion");
            CycleSuggestionCommand = new CycleSuggestionCommand(this);
        }

        /// <summary>
        /// Saves current value of SuggestionEntry as a new suggestion
        /// </summary>
        public void AddSuggestion()
        {
            _suggestionFileManager.AddSuggestion(SuggestionEntry); // add suggestion
            _allSuggestions = _suggestionFileManager.GetSuggestions(); //Update suggestions with new suggestion
        }
    }
}
