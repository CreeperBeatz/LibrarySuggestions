using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryWPF.Model;
using LibraryWPF.SuggestBoxHelpers;

namespace LibraryWPF.Utils
{
    public class SuggestionFileManager
    {
        private string _filePath;
        public List<SuggestionBase> GetSuggestions()
        {
            var data = File.ReadAllText(_filePath);
            var lines = data.Split('\n');
            List<SuggestionBase> suggestions = new List<SuggestionBase>();
            foreach (var line in lines)
            {
                if (line == String.Empty)
                    continue;
                var uls = new SuggestionBase(line);
                suggestions.Add(uls);
            }

            return suggestions;
        }

        public void SetSuggestions(List<SuggestionBase> suggestions)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var suggestion in suggestions)
            {
                sb.Append(suggestion.Suggestion);
                sb.Append("\n");
            }
            File.WriteAllText(_filePath, sb.ToString());
        }

        public void AddSuggestion(SuggestionBase suggestion)
        {
            var list = GetSuggestions() ?? new List<SuggestionBase>();
            if (!list.Contains(suggestion))
                list.Add(suggestion);
            SetSuggestions(list);
        }

        public SuggestionFileManager(string filePath)
        {
            _filePath = filePath;
        }
    }
}
