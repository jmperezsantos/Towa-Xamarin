﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation.ObjectHydrator;
using ListViewExample.Model;

namespace ListViewExample.ViewModel
{
    public class BookListViewModel : INotifyPropertyChanged
    {
        IList<BookModel> lstBooks;

        public IList<BookModel> LstBooks
        {
            get
            {
                return lstBooks;
            }

            set
            {
                lstBooks = value;
                this.PropertyChanged?
                    .Invoke(this,
                            new PropertyChangedEventArgs("LstBooks"));
            }
        }

        public BookListViewModel()
        {
            //this.LstBooks = this.generateDummies(50);

            Hydrator<BookModel> hydrator = new Hydrator<BookModel>()
                .With<string>(x => x.Image, "https://placeimg.com/100/100")
                .WithFirstName(x => x.Author)
                .WithCompanyName(x => x.Title);

            this.LstBooks = hydrator.GetList(50);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private IList<BookModel> generateDummies(int quantity)
        {

            IList<BookModel> books = new List<BookModel>();

            for (int i = 0; i < quantity; i = i + 1)
            {

                BookModel book = new BookModel("" + i,
                                               "Title " + i,
                                               "Author " + i,
                                               "https://placeimg.com/100/100");

                books.Add(book);

            }

            return books;

        }
    }
}
