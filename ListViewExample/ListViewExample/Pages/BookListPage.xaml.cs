using System;
using System.Collections.Generic;
using ListViewExample.ViewModel;
using Xamarin.Forms;

namespace ListViewExample.Pages
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
