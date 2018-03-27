using System;
using System.Collections.Generic;
using NetworkingExample.ViewModel;
using Xamarin.Forms;

namespace NetworkingExample.Pages
{
    public partial class BookListPage : ContentPage
    {
        public BookListPage()
        {
            InitializeComponent();

            this.BindingContext = new BookListViewModel();
        }
    }
}
