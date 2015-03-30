using Android.App;
using Xamarin.Forms;
using XamarinFormsHelper;

namespace XamarinFormsAndroidExtension.Droid
{
    public static class PageDialogHelper
    {
        static AlertDialog _dialog;
        static Android.Views.View _dialogView;

        public static void ShowAsDialog (INavigation navigation, Page page, double height)
        {
            _dialogView = page.CreateView ();

            _dialog = new AlertDialog.Builder (Forms.Context).Create ();
            _dialog.SetView (_dialogView);
            _dialog.SetCanceledOnTouchOutside (false);
            _dialog.SetCancelable (false);
            _dialog.Show ();

            // this formula is from "Converting dp units to pixel units" section of http://developer.android.com/guide/practices/screens_support.htm
            var scale = Forms.Context.Resources.DisplayMetrics.Density;
            var heightInDp = (int)(height * scale + 0.5f);

            var layoutParams = _dialogView.LayoutParameters;
            layoutParams.Height = heightInDp;
            _dialogView.LayoutParameters = layoutParams;

        }

        public static void CloseLastDialog ()
        {
            if (_dialog != null) {
                _dialog.Dismiss ();
                _dialogView.Dispose ();
                _dialog.Dispose ();
                _dialogView = null;
                _dialog = null;
            }
        }
    }
}

