using Android.App;
using Android.Widget;
using Android.OS;

namespace Android_Controls
{
    [Activity(Label = "Android_Controls", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
                      
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.Button);
            button.Click += delegate { StartActivity(typeof(ButtonActivity)); };

            Button editText = FindViewById<Button>(Resource.Id.EditText);
            editText.Click += delegate { StartActivity(typeof(EditTextActivity)); };

            Button checkBox = FindViewById<Button>(Resource.Id.CheckBox);
            checkBox.Click += delegate { StartActivity(typeof(CheckBoxActivity)); };

            Button radioButton = FindViewById<Button>(Resource.Id.RadioButton);
            radioButton.Click += delegate { StartActivity(typeof(RadioButtonActivity)); };

            Button toggleButton = FindViewById<Button>(Resource.Id.ToggleButton);
            toggleButton.Click += delegate { StartActivity(typeof(ToggleButtonActivity)); };

            Button spinner = FindViewById<Button>(Resource.Id.Spinner);
            spinner.Click += delegate { StartActivity(typeof(SpinnerActivity)); };

            Button datePicker = FindViewById<Button>(Resource.Id.DatePicker);
            datePicker.Click += delegate { StartActivity(typeof(DatePickerActivity)); };

            Button timePicker = FindViewById<Button>(Resource.Id.TimePicker);
            timePicker.Click += delegate { StartActivity(typeof(TimePickerActivity)); };

            Button listView = FindViewById<Button>(Resource.Id.ListView);
            listView.Click += delegate { StartActivity(typeof(ListViewActivity)); };

            Button gridView = FindViewById<Button>(Resource.Id.GridView);
            gridView.Click += delegate { StartActivity(typeof(GridViewActivity)); };

            Button webView = FindViewById<Button>(Resource.Id.WebView);
            webView.Click += delegate { StartActivity(typeof(WebViewActivity)); };
        }
    }
}

