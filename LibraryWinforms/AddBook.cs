using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryWPF.ViewModels;

namespace LibraryWinforms
{
    public partial class AddBook : Form
    {
        private AddBookVM vm;
        public AddBook()
        {
            this.vm = new AddBookVM();
            InitializeComponent();
            PerformBinding();
        }

        public void PerformBinding()
        {
            bookTitleBox.DataBindings.Add("Text", vm, nameof(vm.BookName), false, DataSourceUpdateMode.OnPropertyChanged);
            authorsBox.DataBindings.Add("Text", vm, nameof(vm.Authors), false, DataSourceUpdateMode.OnPropertyChanged);

            addBookButton.Click += (sender, e) => vm.AddBook();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
