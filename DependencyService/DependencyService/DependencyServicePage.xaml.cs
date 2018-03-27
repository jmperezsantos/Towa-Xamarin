using DependencyService.Dependency;
using Xamarin.Forms;

namespace DependencyService
{
    public partial class DependencyServicePage : ContentPage
    {
        public DependencyServicePage()
        {
            InitializeComponent();
        }

        void SayHelloButton(object sender, System.EventArgs e)
        {

            IShowNativeMessage nativeMessage =
                Xamarin.Forms.DependencyService.Get<IShowNativeMessage>();

            nativeMessage.sayHello();

        }
    }
}
