using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App6
{
    [Activity(Label = "loginActivity", MainLauncher = true)]
    public class loginActivity : Activity
    {
        Button btnsignup; EditText edun; EditText edpw; Button btnlogin;

        protected override void OnCreate(Bundle savedInstanceState)
        {


            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.login);

            btnsignup = FindViewById<Button>(Resource.Id.btnsignup);
            btnlogin = FindViewById<Button>(Resource.Id.btnlogin);
            edun = FindViewById<EditText>(Resource.Id.edun);
            edpw = FindViewById<EditText>(Resource.Id.edpw);

            btnsignup.Click += (sender, e) =>
            {
                Intent RegisterActivityIntent = new Intent(this, typeof(RegisterActivity));              
                StartActivity(RegisterActivityIntent);
            };

            btnlogin.Click += (sender, e) =>
            {
                Intent WelcomActivityIntent = new Intent(this, typeof(WelcomActivity));
                WelcomActivityIntent.PutExtra("Username", edun.Text);
                WelcomActivityIntent.PutExtra("Password", edpw.Text);
                StartActivity(WelcomActivityIntent);
            };

        }

        //public void btnlogin_Click(View v)//Object sender,EventArgs e)
        //{
        //    Intent WelcomActivityIntent = new Intent(this, typeof(WelcomActivity));
        //    WelcomActivityIntent.PutExtra("Username", edun.Text);
        //    WelcomActivityIntent.PutExtra("Password", edpw.Text);
        //    StartActivity(WelcomActivityIntent);
        //}

        //public void btnsignup_Click(View v)//Object sender,EventArgs e)
        //{
        //    Intent RegisterActivityIntent = new Intent(this, typeof(RegisterActivity));
            
        //    StartActivity(RegisterActivityIntent);
        //}
    }
}