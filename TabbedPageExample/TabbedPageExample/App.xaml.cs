using TabbedPageExample.Pages;
using Xamarin.Forms;

namespace TabbedPageExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            TabbedPage tabbed = new TabbedPage();
            tabbed.Children.Add(new FirstPage());
            tabbed.Children.Add(new SecondPage());

            MainPage = tabbed;
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
