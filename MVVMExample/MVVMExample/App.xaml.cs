﻿using MVVMExample.Pages;
using Xamarin.Forms;

namespace MVVMExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ExamplePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
