using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;

namespace RuaSeguraApp
{
    [Activity(Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            //Xamarin.FormsGoogleMaps.Init(this, savedInstanceState); // inicia o Xamarin.Forms.GoogleMaps

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

        }
<<<<<<< Updated upstream
=======
        void Initializedatabase()
        {
            // ainda testando implementação para modelo NoSQL de coleções //
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
>>>>>>> Stashed changes
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}