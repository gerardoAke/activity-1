using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace Activity1
{
    [Activity(Label = "Oher Activity")]
    public class OtherActivity : Activity
    {
        TextView name;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Other);

            name = FindViewById<TextView>(Resource.Id.name);
            string textName = Intent.GetStringExtra("name");
            name.Text = textName;
        }
    }
}