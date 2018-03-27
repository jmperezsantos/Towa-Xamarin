using System;
using DependencyService.Dependency;
using DependencyService.iOS.Dependency;

[assembly: Xamarin.Forms.Dependency(typeof(ShowNativeMessageiOS))]
namespace DependencyService.iOS.Dependency
{
    public class ShowNativeMessageiOS : IShowNativeMessage
    {
        public ShowNativeMessageiOS()
        {
        }

        public void sayHello()
        {
            System.Diagnostics.Debug.WriteLine("Hola desde iOS");
        }
    }
}
