using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Firebase;
using Firebase.Database;
using Firebase.Firestore;

namespace RuaSeguraApp
{
    [Activity(Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        FirebaseDatabase database;
        Button testbutton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            //Xamarin.FormsGoogleMaps.Init(this, savedInstanceState); // inicia o Xamarin.Forms.GoogleMaps

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

        }
        void Initializedatabase()
        {
            // ainda testando implementação para modelo NoSQL de coleções
            //FirebaseFirestore.Instance.Collection("Teste").Document("teste1").Set({ "nome":"caneta" })
                //.document("teste1")
                //    .setData(
                //       {
                //          "nome":"caneta",
                //          "preco":3.45,
                //          "ativo":true
                //       }
                //    );

        }
        private void Testbutton_Click(object sender, System.EventArgs e)
        {
            Initializedatabase();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}


//savedInstanceState.collection("Teste")
//

//var app = Firebase.FirebaseApp.InitializeApp(this);

//if (app == null)
//{
//    var options = new FirebaseOptions.Builder()

//    .SetApplicationId("ruasegura-326520")
//    .SetApiKey("AIzaSyAtQplmtZ5jh8aKAb8wE_lEH3Yx8yI8N8c")
//    .SetDatabaseUrl("https://ruasegura-326520.firebaseio.com")
//    .SetStorageBucket("ruasegura-326520.appspot.com")
//    .Build();

//    app = Firebase.FirebaseApp.InitializeApp(this, options);
//    database = FirebaseDatabase.GetInstance(app);
//}
//else
//{
//    database = FirebaseDatabase.GetInstance(app);
//}

//DatabaseReference dbref = database.GetReference("UserSupport");
//dbref.SetValue("Ticketl");


//Toast.MakeText(this, "Completed", ToastLength.Short).Show();