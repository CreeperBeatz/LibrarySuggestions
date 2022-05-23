namespace LibraryWinforms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            var addBook = new AddBook();
            addBook.Show();
        }

        private void SearchAuthorButton_Click(object sender, EventArgs e)
        {
            SearchAuthor searchAuthorWindow = new SearchAuthor();
            searchAuthorWindow.Show();
        }
    }
}