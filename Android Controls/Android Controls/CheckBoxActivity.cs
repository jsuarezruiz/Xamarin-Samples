using Android.App;
using Android.OS;

namespace Android_Controls
{
    [Activity(Label = "ChecBox")]
    public class CheckBoxActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CheckBox);
        }
    }
}