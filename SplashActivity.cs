using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Firebase;
using Firebase.Database;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuaSeguraApp
{
    [Activity(Label = "@string/app_name", Icon = "@mipmap/ic_launcher", Theme = "@style/MyTheme.Splash", NoHistory = true, MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class SplashActivity : AppCompatActivity
    {
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //sdk firebase admin
            //FirebaseAdmin.FirebaseApp.Create(new AppOptions() { Credential = GoogleCredential.GetApplicationDefault(), ProjectId = "<ruasegura-326520>", });

            base.OnCreate(savedInstanceState);
            
            StartActivity(typeof(MainActivity));
            Finish();

            // Disable activity slide-in animation
            //OverridePendingTransition(0, 0);;
        }
        

    }
}
