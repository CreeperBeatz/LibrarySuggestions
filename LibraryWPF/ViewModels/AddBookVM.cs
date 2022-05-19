using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using LibraryWPF.Core;
using LibraryWPF.DAL;
using LibraryWPF.Model.DB;
using LibraryWPF.ViewModels.Commands;

namespace LibraryWPF.ViewModels
{
    public class AddBookVM : ObservableObject//, IViewModelSuggestions
    {
        private string _bookName;
        private string _authors;

        private AuthorService _authorService;
        private BookService _bookService;

        public ICommand AddBookCommand { get; set; }
        public string BookName { get { return _bookName; } set { _bookName = value; OnPropertyChanged(); } }
        public string Authors { get { return _authors; } set { _authors = value; OnPropertyChanged(); } }

        public AddBookVM()
        {
            var dbContext = new LibraryContext();
            this._authorService = new AuthorService(dbContext);
            this._bookService = new BookService(dbContext);
            this.AddBookCommand = new AddBookCommand(this);
        }

        public void AddBook()
        {
            try
            {
                //Create book instance
                Book book = new Book(BookName, delimitAuthors());
                if (this._bookService.BookExists(book))
                {
                    MessageBox.Show("Book already exists");
                }
                else
                {
                    this._bookService.AddBook(book);
                    MessageBox.Show("Succesfully added book!");

                    //Reset typing fields (WPF exclusive)
                    this.Authors = "";
                    this.BookName = "";
                }
            }
            catch
            {
                MessageBox.Show("Error occured!");
            }
        }

        private List<Author> delimitAuthors()
        {
            if (Authors == String.Empty)
            {
                return null;
            }

            List<Author> authors = new List<Author>();

            foreach (var authorName in Authors.Split(',').ToList())
            {
                authors.Add(new Author(authorName));
            }
            return authors;
        }
    }
}
