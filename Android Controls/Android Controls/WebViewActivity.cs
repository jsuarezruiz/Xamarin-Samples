using Android.App;
using Android.OS;
using Android.Webkit;

namespace Android_Controls
{
    [Activity(Label = "WebView")]
    public class WebViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.WebView);

            WebView webView = FindViewById<WebView>(Resource.Id.WebView);

            webView.LoadUrl("http://www.campusmvp.es");
        }
    }
}