using Android.App;
using Xamarin.Forms;
using XamarinFormsHelper;

namespace XamarinFormsAndroidExtension.Droid
{
    public static class PageDialogHelper
    {
        static AlertDialog _dialog;

        public static void ShowAsDialog (Page page)
        {
            CreateAndShowDialog (page);
        }

        public static void ShowAsDialog (Page page, int requestedHeight)
        {
            var dialogView = CreateAndShowDialog (page);

            var layoutParams = dialogView.LayoutParameters;
            layoutParams.Height = requestedHeight;
            dialogView.LayoutParameters = layoutParams;
        }

        static Android.Views.View CreateAndShowDialog (Page page)
        {
            var dialogView = page.CreateView ();

            _dialog = new AlertDialog.Builder (Forms.Context).Create ();
            _dialog.SetView (dialogView);
            _dialog.Show ();

            return dialogView;
        }
    }
}

