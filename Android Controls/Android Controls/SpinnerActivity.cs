using Android.App;
using Android.OS;

namespace Android_Controls
{
    [Activity(Label = "Spinner")]
    public class SpinnerActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Spinner);
        }
    }
}