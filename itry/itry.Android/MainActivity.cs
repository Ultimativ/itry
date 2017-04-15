using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace itry.Droid
{
	[Activity (Label = "itry.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		EditText edt;
        TextView res;
        

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btn_submit = FindViewById<Button>(Resource.Id.button1);
            edt = FindViewById<EditText>(Resource.Id.editText1);
            res = FindViewById<TextView>(Resource.Id.textView3);


            btn_submit.Click += Btn_Click;
		}

        private void Btn_Click(object sender, EventArgs e)
        {
            string s = edt.Text.ToString();
            res.Text = "Willkommen " + s;

        }
    }
}


