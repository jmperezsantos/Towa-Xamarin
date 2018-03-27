using System;
using System.Collections.Generic;
using ListViewExample.Model;
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

        //void ListViewItemSelected(object sender,
        //                          Xamarin.Forms.SelectedItemChangedEventArgs evnt)
        //{

        //    ListView listView = sender as ListView;
        //    listView.SelectedItem = null;

        //    BookModel model = evnt.SelectedItem as BookModel;

        //    System.Diagnostics.Debug.WriteLine("Seleccinó: " + model);
        //}

        void ListItemTapped(object sender,
                            Xamarin.Forms.ItemTappedEventArgs evnt)
        {
            ListView listView = sender as ListView;
            listView.SelectedItem = null;

            BookModel model = evnt.Item as BookModel;

            System.Diagnostics.Debug.WriteLine("Seleccinó: " + model);
        }
    }
}
