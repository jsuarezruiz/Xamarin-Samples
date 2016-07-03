using Android.App;
using Android.OS;

namespace Android_Controls
{
    [Activity(Label = "DatePicker")]
    public class DatePickerActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.DatePicker);
        }
    }
}