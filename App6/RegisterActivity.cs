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
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        Button btnRegister;Button btnBack; EditText editCountry; EditText editPassword;EditText editFirstName; EditText editLastName;EditText editAddress;EditText editPhone;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Signup);
            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);
            btnBack = FindViewById<Button>(Resource.Id.btnBack);
            editCountry = FindViewById<EditText>(Resource.Id.editCountry);
            editPassword = FindViewById<EditText>(Resource.Id.editPassword);
            editFirstName = FindViewById<EditText>(Resource.Id.editFirstName);
            editLastName = FindViewById<EditText>(Resource.Id.editLastName);
            editAddress = FindViewById<EditText>(Resource.Id.editAddress);
            editPhone = FindViewById<EditText>(Resource.Id.editPhone);

            btnBack.Click += (sender, e) =>
            {
                Intent loginActivityIntent = new Intent(this, typeof(loginActivity));
                StartActivity(loginActivityIntent);
            };

        }
    }
}