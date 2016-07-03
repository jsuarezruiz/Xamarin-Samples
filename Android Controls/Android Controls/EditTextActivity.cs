using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Android_Controls
{
    [Activity(Label = "EditText")]
    public class EditTextActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.EditText);

            AddKeyListener();
        }

        public void AddKeyListener()
        {
            EditText edittext = FindViewById<EditText>(Resource.Id.TextEditText);

            KeyListner keyListner = new KeyListner(this);
            edittext.SetOnKeyListener(keyListner);
        }
    }

    public class KeyListner : Java.Lang.Object, View.IOnKeyListener
    {
        private EditTextActivity view;

        public KeyListner(EditTextActivity view)
        {
            this.view = view;
        }

        public bool OnKey(View v, [GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
            if (e.Action == KeyEventActions.Down 
                && keyCode.Equals(Keycode.Enter))
            {
                Toast.MakeText(
                    view.ApplicationContext, 
                    view.FindViewById<EditText>(Resource.Id.TextEditText).Text, 
                    ToastLength.Long).Show();

                return true;
            }

            return false;
        }
    }
}