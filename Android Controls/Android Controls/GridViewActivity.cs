using Android.App;
using Android.OS;
using Android.Widget;

namespace Android_Controls
{
    [Activity(Label = "GridView")]
    public class GridViewActivity : Activity
    {
        GridView gridView;

        static string[] Numbers = new string[] {
            "A", "B", "C", "D", "E",
            "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O",
            "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z"};

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.GridView);

            gridView = FindViewById<GridView>(Resource.Id.GridView);

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this,
                 Resource.Layout.ListItem, Numbers);

            gridView.Adapter = adapter;
        }
    }
}