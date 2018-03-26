using System;
using System.Collections.Generic;
using MVVMExample.ViewModel;
using Xamarin.Forms;

namespace MVVMExample.Pages
{
    public partial class ExamplePage : ContentPage
    {
        public ExamplePage()
        {
            InitializeComponent();

            this.BindingContext = new ExampleViewModel();
        }
    }
}
