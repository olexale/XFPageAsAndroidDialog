using System;

using Xamarin.Forms;

namespace XamarinFormsAndroidExtension.Pages
{
    public class SecondPage : ContentPage
    {
        public SecondPage ()
        {
            Title = "Second page";

            Content = new StackLayout { 
                Children = {
                    new Label { Text = "Hello from Second page!" }
                }
            };
        }
    }
}


