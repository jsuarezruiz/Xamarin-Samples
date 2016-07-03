using Android.App;
using Android.OS;
using Android.Widget;

namespace Android_Controls
{
    [Activity(Label = "ListView")]
    public class ListViewActivity : Activity
    {
        ListView listView;

        static string[] Fruits = new string[] { "Apple", "Avocado", "Banana",
            "Blueberry", "Coconut", "Durian", "Guava", "Kiwifruit",
            "Jackfruit", "Mango", "Olive", "Pear", "Sugar-apple" };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ListView);

            listView = FindViewById<ListView>(Resource.Id.ListView);

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this,
                 Resource.Layout.ListItem, Fruits);

            listView.Adapter = adapter;
        }
    }
}