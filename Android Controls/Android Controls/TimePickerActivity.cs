using Android.App;
using Android.OS;

namespace Android_Controls
{
    [Activity(Label = "TimePicker")]
    public class TimePickerActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TimePicker);
        }
    }
}