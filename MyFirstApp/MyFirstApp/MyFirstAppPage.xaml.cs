using MyFirstApp.Pages;
using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class MyFirstAppPage : ContentPage
    {
        public MyFirstAppPage()
        {
            InitializeComponent();

            this.Title = "Mi Primer Page";

            this.theLabel.Text = "Hola Mundo";

            this.theButton.Clicked += (sender, e) =>
            {

                System.Diagnostics
                      .Debug.WriteLine("Hola Mundo desde Xamarin.Forms!");

                this.theLabel.Text = this.theEntry.Text;

                this.theEntry.Text = "";

            };
        }

        public void ManejadorDeClic(object sender, System.EventArgs e)
        {

            System.Diagnostics
                      .Debug.WriteLine("Hola Mundo desde Xamarin.Forms!");

            string message = this.theEntry.Text;
            SecondPage second = new SecondPage(message);
            this.Navigation.PushModalAsync(second);
        }
    }
}
