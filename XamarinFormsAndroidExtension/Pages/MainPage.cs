using System;

using Xamarin.Forms;
using XamarinFormsAndroidExtension.Droid;

namespace XamarinFormsAndroidExtension.Pages
{
    public class MainPage : ContentPage
    {
        public MainPage ()
        {
            Title = "Main page";

            var simplePageButton = new Button { Text = "Open page" };
            simplePageButton.Clicked += async (sender, e) => await Navigation.PushAsync (new SecondPage ());

            var dialogPageButton = new Button { Text = "Open dialog page" };
            dialogPageButton.Clicked += (sender, e) => PageDialogHelper.ShowAsDialog (new SecondPage ());

            var dialogPageWithHeightButton = new Button { Text = "Open dialog page with custom height" };
            dialogPageWithHeightButton.Clicked += (sender, e) => PageDialogHelper.ShowAsDialog (new SecondPage (), 180);

            Content = new StackLayout { 
                Children = {
                    simplePageButton,
                    dialogPageButton,
                    dialogPageWithHeightButton
                }
            };
        }
    }
}


