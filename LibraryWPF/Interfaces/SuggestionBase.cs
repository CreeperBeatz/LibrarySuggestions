using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryWPF.Core;

namespace LibraryWPF.Interfaces
{
    /// <summary>
    /// The class needs a public
    /// </summary>
    public abstract class SuggestionBase : ObservableObject
    {
        /// <summary>
        /// Test if an object is of the same type AND has the same values
        /// </summary>
        /// <param name="obj">Object to be tested</param>
        /// <returns></returns>
        public abstract bool Equals(object obj);

        /// <summary>
        /// Public property that will be used as a middleman, between the WPF Suggest Box control, and the ViewModel.
        /// You need to override it with your own object.
        /// You MUST include OnPropertyChanged() in the set method!
        /// </summary>
        public object Suggestion { 
            get 
            { 
                throw new NotImplementedException("Please override the property!"); 
            } 
            set
            { 
                OnPropertyChanged();
                throw new NotImplementedException("Please override the property!"); 
            } 
        }

        private object _suggestion;
        
    }
}
