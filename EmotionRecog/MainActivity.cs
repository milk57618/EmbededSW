using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Graphics;
using System.IO;
using Android.Content;
using Android.Provider;
using System;
using Android.Runtime;


namespace EmotionRecog
{
    [Activity(Label = "EmotionRecog", MainLauncher = true, Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        public CognitiveActivity cognitiveActivity;
        public ImageView logo;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            logo = FindViewById<ImageView>(Resource.Id.Logo);            

            var btnCamera = FindViewById<Button>(Resource.Id.btnCamera);
            btnCamera.Click += BtnCamera_Click;
        }

        private void BtnCamera_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(CognitiveActivity));
            StartActivity(intent);
        }
    }
}

