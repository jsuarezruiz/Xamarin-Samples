using Android.App;
using Android.OS;

namespace Android_Controls
{
    [Activity(Label = "ToggleButton")]
    public class ToggleButtonActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ToggleButton);
        }
    }
}