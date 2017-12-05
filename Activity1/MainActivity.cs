using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Widget;
using Android.Content;

namespace Activity1
{
    [Activity(Label = "Activity 1", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //EditText inputBill;
        //Button calculateButton;
        //TextView outputTip;
        //TextView outputTotal;
        TextView name;
        Button alertButton;
        Button activityButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            //inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            //calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            //outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            //outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            //calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            //calculateButton.Click += OnCalculateClick;
            
            name = FindViewById<TextView>(Resource.Id.name);
            alertButton = FindViewById<Button>(Resource.Id.alertButton);
            activityButton = FindViewById<Button>(Resource.Id.activityButton);

            alertButton.Click += OnAlertClick;
            activityButton.Click += OnActivityClick;
        }

        //void OnCalculateClick(object sender, EventArgs e)
        //{
        //    string text = inputBill.Text;
        //    var bill = double.Parse(text);

        //    var tip = bill * 0.15;
        //    var total = bill + tip;

        //    outputTip.Text = tip.ToString("C");
        //    outputTotal.Text = total.ToString("C");
        //}

        void OnAlertClick(object sender, EventArgs e)
        {
            AlertDialog.Builder alertDialog = new AlertDialog.Builder(this);
            alertDialog.SetTitle("Activity 1");
            alertDialog.SetMessage(name.Text);
            alertDialog.SetNeutralButton("Ok", delegate
            {
                alertDialog.Dispose();
            });

            alertDialog.Show();
        }

        void OnActivityClick(object sender, EventArgs e)
        {
            var otherActivity = new Intent(this, typeof(OtherActivity));
            otherActivity.PutExtra("name", name.Text);
            StartActivity(otherActivity);
        }
    }
}

