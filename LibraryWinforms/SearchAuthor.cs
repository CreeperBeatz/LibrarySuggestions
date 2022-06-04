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
    public partial class SearchAuthor : Form
    {
        private SearchAuthorVM vm { get; set; }

        public SearchAuthor()
        {
            vm = new SearchAuthorVM();
            InitializeComponent();
            PerformBindings();
            LoadDataGrid();
        }

        private void PerformBindings()
        {
            //Bind SuggestBox
            suggestionBoxWrapper1.PerformBindings(vm.AuthorSuggestBox, "Author Name");

            //Bind search button
            searchButton.Click += (sender, e) => { vm.Search(); LoadDataGrid(); };
        }

        private void LoadDataGrid()
        {
            DataTable temp = new DataTable();
            temp.Columns.Add("Authors", typeof(string));
            temp.Columns.Add("Book Title", typeof(string));
            foreach(var pair in vm.SearchResults)
            {
                temp.Rows.Add(pair.Key, pair.Value);
            }
            dataGridView.DataSource = temp;
        }

        #region generatedCode
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        private void suggestionBoxWrapper1_Load(object sender, EventArgs e)
        {

        }
    }
}
