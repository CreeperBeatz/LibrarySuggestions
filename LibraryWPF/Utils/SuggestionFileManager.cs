using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryWPF.Model;

namespace LibraryWPF.Utils
{
    public class SuggestionFileManager
    {
        private const string filename = "authordata.dat";
        public List<AuthorSearchSuggestion> GetSuggestions()
        {
            var data = Cryptography.Decrypt(File.ReadAllText(filename));
            var lines = data.Split('\n');
            List<AuthorSearchSuggestion> suggestions = new List<AuthorSearchSuggestion>();
            foreach (var line in lines)
            {
                if (line == String.Empty)
                    continue;
                var uls = new AuthorSearchSuggestion(line);
                suggestions.Add(uls);
            }

            return suggestions;
        }

        public void SetSuggestions(List<AuthorSearchSuggestion> suggestions)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var suggestion in suggestions)
            {
                sb.Append(suggestion.Name);
                sb.Append("\n");
            }
            File.WriteAllText(filename, Cryptography.Encrypt(sb.ToString()));
        }

        public void AddSuggestion(AuthorSearchSuggestion suggestion)
        {
            var list = GetSuggestions() ?? new List<AuthorSearchSuggestion>();
            if (!list.Contains(suggestion))
                list.Add(suggestion);
            SetSuggestions(list);
        }

        public SuggestionFileManager()
        {
        }
    }
}
