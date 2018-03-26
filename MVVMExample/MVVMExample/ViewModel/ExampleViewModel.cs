using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MVVMExample.ViewModel
{
    public class ExampleViewModel : INotifyPropertyChanged
    {
        private string _message;

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;

                this.PropertyChanged?.Invoke(this,
                                             new PropertyChangedEventArgs("Message"));
            }
        }

        public Command ButtonPressedCommand { get; set; }

        public ExampleViewModel()
        {
            this.ButtonPressedCommand = new Command(this.performButtonPress);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void performButtonPress(object obj)
        {

            System.Diagnostics.Debug.WriteLine("Hola Mundo desde MVVM");

            this.Message = "Otra cosa";

        }
    }
}
