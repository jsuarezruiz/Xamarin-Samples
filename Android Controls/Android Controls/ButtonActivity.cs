using Android.App;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Widget;

namespace Android_Controls
{
    [Activity(Label = "Button")]
    public class ButtonActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Button);

            Button button = FindViewById<Button>(Resource.Id.Button);
            button.Click += (sender, e) => {
                Intent browserIntent =
                    new Intent(Intent.ActionView, Uri.Parse("http://www.campusmvp.es"));
                StartActivity(browserIntent);
            };
        }
    }
}