using System;
using System.Collections.Generic;
using NetworkingExample.Model;
using NetworkingExample.ViewModel;
using Xamarin.Forms;

namespace NetworkingExample.Pages
{
    public partial class BookFormPage : ContentPage, IBookFormViewModelListener
    {
        public BookFormPage() : this(new BookModel())
        {

        }

        public BookFormPage(BookModel book)
        {

            InitializeComponent();

            this.BindingContext = new BookFormViewModel(book, this);

            if (book.Id != null && book.Id.Length > 0)
            {
                this.btnSave.Text = "Actualizar";
            }
            else
            {
                this.btnSave.Text = "Guardar";
            }
        }

        public void removeView()
        {
            this.Navigation.PopModalAsync();
        }

        public void showError(string error)
        {
            DisplayAlert("Error", error, "Aceptar");
        }

        void GoBack(object sender, System.EventArgs e)
        {
            this.Navigation.PopModalAsync(true);
        }
    }
}
