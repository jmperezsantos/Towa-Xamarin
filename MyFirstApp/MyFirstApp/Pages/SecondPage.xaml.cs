using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyFirstApp.Pages
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();

            this.btnBack.Clicked += (sender, e) =>
            {
                this.Navigation.PopModalAsync(false);
            };

        }

        public SecondPage(string message) : this()
        {

            this.lbMessage.Text = message;

        }
    }
}
