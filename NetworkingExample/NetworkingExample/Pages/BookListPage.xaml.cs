using System;
using System.Collections.Generic;
using NetworkingExample.Model;
using NetworkingExample.ViewModel;
using Xamarin.Forms;

namespace NetworkingExample.Pages
{
    public partial class BookListPage : ContentPage
    {
        public BookListPage()
        {
            InitializeComponent();

            //this.BindingContext = new BookListViewModel();
        }

		protected override void OnAppearing()
		{
            base.OnAppearing();

            this.BindingContext = new BookListViewModel();
		}

		void NewBook(object sender, System.EventArgs e)
        {
            BookFormPage page = new BookFormPage();
            this.Navigation.PushModalAsync(page);
        }

        void ListViewTapped(object sender, 
                            Xamarin.Forms.ItemTappedEventArgs e)
        {

            BookModel book = e.Item as BookModel;

            BookFormPage page = new BookFormPage(book);
            this.Navigation.PushModalAsync(page);

        }
    }
}
