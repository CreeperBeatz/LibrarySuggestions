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
using LibraryWPF.ViewModels;
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

        
        public void PerformBindings(ObservableObject viewModel,
                                    string placeholderText,
                                    string autoSuggestPropertyName,
                                    string textPropertyName,
                                    string valueMemberPropertyName,
                                    string itemsPropertyName)
        {
            //Remove any objects that are in the UserControl
            this.Controls.Remove(host);

            //Bind all the parameters
            suggestTextBox.Placeholder = placeholderText;

            suggestTextBox.SetBinding(SuggestTextBox.AutoSuggestProperty, new System.Windows.Data.Binding()
            {
                Mode = BindingMode.TwoWay,
                Source = viewModel,
                Path = new PropertyPath(autoSuggestPropertyName)
            });

            suggestTextBox.SetBinding(SuggestTextBox.TextProperty, new System.Windows.Data.Binding()
            {
                Mode = BindingMode.TwoWay,
                Source = viewModel,
                Path = new PropertyPath(textPropertyName)
            });

            suggestTextBox.SetBinding(SuggestTextBox.ValueMemberProperty, new System.Windows.Data.Binding()
            {
                Mode = BindingMode.TwoWay,
                Source = viewModel,
                Path = new PropertyPath(valueMemberPropertyName)
            });

            suggestTextBox.SetBinding(SuggestTextBox.ItemsProperty, new System.Windows.Data.Binding()
            {
                Mode = BindingMode.TwoWay,
                Source = viewModel,
                Path = new PropertyPath(itemsPropertyName)
            });


            //add the binded SuggestBox to the WinForms control
            host.Child = suggestTextBox;
            this.Controls.Add(host);
        }
    }
}
