using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWPF.Model.DB
{
    public class Settings
    {
        [Key]
        public int SettingsId { get; set; }
        public int SuggestionsCount { get; set; } = 5;
        public bool AutoComplete { get; set; } = false;
        public int InputLengthThreshold { get; set; }
        public Settings()
        {
            InputLengthThreshold = 1;
        }
    }
}
