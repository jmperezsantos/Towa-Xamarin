using System;
using System.ComponentModel;
using NetworkingExample.Model;
using NetworkingExample.RestClient;
using Xamarin.Forms;

namespace NetworkingExample.ViewModel
{
    public class BookFormViewModel : INotifyPropertyChanged
    {

        private IBookFormViewModelListener listener;

        private Boolean isLoading;
        public Boolean IsLoading
        {
            get
            {
                return this.isLoading;
            }
            set
            {
                this.isLoading = value;

                this.PropertyChanged?.Invoke(this,
                                             new PropertyChangedEventArgs("IsLoading"));
            }
        }

        private BookModel book;
        public BookModel Book
        {
            get
            {
                return book;
            }
            set
            {
                book = value;

                this.PropertyChanged?.Invoke(this,
                                             new PropertyChangedEventArgs("Book"));
            }
        }

        public Command SaveCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public BookFormViewModel(BookModel book, IBookFormViewModelListener listener)
        {

            this.listener = listener;
            this.Book = book;

            this.SaveCommand = new Command(this.performSaveCommand);
        }

        private void performSaveCommand(object obj)
        {
            if (this.Book.Title.Length > 0 &&
               this.Book.Author.Length > 0 &&
               this.Book.Image.Length > 0)
            {

                this.IsLoading = true;

                BookDAO.saveBookAsync(
                    this.Book,
                    (createdBook) =>
                    {
                        this.IsLoading = false;
                        this.listener.removeView();
                    },
                    (error) =>
                    {
                        this.IsLoading = false;
                        this.listener.showError(error);
                    });


            }
        }
    }

    public interface IBookFormViewModelListener
    {
        void removeView();
        void showError(string error);
    }
}
