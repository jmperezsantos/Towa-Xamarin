using System;
using System.Collections.Generic;
using System.ComponentModel;
using NetworkingExample.Model;
using NetworkingExample.RestClient;

namespace NetworkingExample.ViewModel
{
    public class BookListViewModel : INotifyPropertyChanged
    {

        private IList<BookModel> _books;
        public IList<BookModel> Books
        {
            get
            {
                return this._books;
            }

            set
            {
                this._books = value;
                this.PropertyChanged?.Invoke(this,
                                             new PropertyChangedEventArgs("Books"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public BookListViewModel()
        {

            BookDAO.getAllBooksAsync(
                (remoteBooks) =>
                {
                    this.Books = remoteBooks;
                },
                (error) =>
                {
                    System.Diagnostics.Debug.WriteLine(error);
                }
            );

        }


    }
}
