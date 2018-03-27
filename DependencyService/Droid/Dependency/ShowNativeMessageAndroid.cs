using System;
using DependencyService.Dependency;
using DependencyService.Droid.Dependency;

[assembly: Xamarin.Forms.Dependency(typeof(ShowNativeMessageAndroid))]
namespace DependencyService.Droid.Dependency
{
    public class ShowNativeMessageAndroid : IShowNativeMessage
    {
        public ShowNativeMessageAndroid()
        {
        }

        public void sayHello()
        {
            System.Diagnostics.Debug.WriteLine("Hola desde Android");
        }
    }
}
