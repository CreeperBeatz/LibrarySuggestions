using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Windows.Data;
using System.Windows.Forms.Integration;
using LibraryWPF.Core;
using LibraryWPF.SuggestBoxHelpers;
using LibraryWPF.Controls;
using System.Windows;

namespace LibraryWinforms.SuggestionBoxUserControl
{
    public partial class SuggestionBoxWrapper : UserControl
    {
        private ElementHost host = new ElementHost();

        private SuggestTextBox suggestTextBox = new SuggestTextBox();
        public SuggestionBoxWrapper()
        {
            InitializeComponent();
        }

        private void SuggestionBoxWrapper_Load_1(object sender, EventArgs e)
        {
            //Add unbinded SuggestionBox
            host.Dock = DockStyle.Fill;
            host.Child = suggestTextBox;
            this.Controls.Add(host);
        }

        
        public void PerformBindings(SuggestBoxCB suggestBox, string placeholderText)
        {
            //Remove any objects that are in the UserControl
            this.Controls.Remove(host);

            //Bind all the parameters
            suggestTextBox.Placeholder = placeholderText;

            suggestTextBox.SetBinding(SuggestTextBox.AutoSuggestProperty, new System.Windows.Data.Binding()
            {
                Mode = BindingMode.TwoWay,
                Source = suggestBox,
                Path = new PropertyPath(nameof(suggestBox.BestSuggestion))
            });

            suggestTextBox.SetBinding(SuggestTextBox.TextProperty, new System.Windows.Data.Binding()
            {
                Mode = BindingMode.TwoWay,
                Source = suggestBox,
                Path = new PropertyPath(nameof(suggestBox.SuggestionEntry))
            });

            suggestTextBox.SetBinding(SuggestTextBox.ValueMemberProperty, new System.Windows.Data.Binding()
            {
                Mode = BindingMode.TwoWay,
                Source = suggestBox,
                Path = new PropertyPath(nameof(suggestBox.SuggestionPair))
            });

            suggestTextBox.SetBinding(SuggestTextBox.ItemsProperty, new System.Windows.Data.Binding()
            {
                Mode = BindingMode.TwoWay,
                Source = suggestBox,
                Path = new PropertyPath(nameof(suggestBox.Suggestions))
            });


            //add the binded SuggestBox to the WinForms control
            host.Child = suggestTextBox;
            this.Controls.Add(host);
        }
    }
}
