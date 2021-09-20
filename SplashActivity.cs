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
        FirebaseDatabase database;

        protected override void OnCreate(Bundle savedInstanceState)
        {

            FirebaseAdmin.FirebaseApp.Create(new AppOptions() { Credential = GoogleCredential.GetApplicationDefault(), ProjectId = "<ruasegura-326520>", });

            base.OnCreate(savedInstanceState);
            
            StartActivity(typeof(MainActivity));
            Finish();

            // Disable activity slide-in animation
            //OverridePendingTransition(0, 0);;
        }
        void Initializedatabase()
        {
            var app = Firebase.FirebaseApp.InitializeApp(this);

            if(app == null)
            {
                var options = new FirebaseOptions.Builder()

                .SetApplicationId("ruasegura-326520")
                .SetApiKey("AIzaSyAtQplmtZ5jh8aKAb8wE_lEH3Yx8yI8N8c")
                .SetDatabaseUrl("https://ruasegura-326520.firebaseio.com")
                .SetStorageBucket("ruasegura-326520.appspot.com")
                .Build();

                app = Firebase.FirebaseApp.InitializeApp(this, options);
                database = FirebaseDatabase.GetInstance(app);
            }
            else
            {
                database = FirebaseDatabase.GetInstance(app);
            }

            //DatabaseReference dbref = database.GetReference("UserSupport");
            //dbref.SetValue("Ticketl");


            //Toast.MakeText(this, "Completed", ToastLength.Short).Show();
        }

    }
}
