using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Plugin.FirebasePushNotification;
using Android;

namespace POC_Pushnotif.Droid
{
    [Activity(Label = "POC_Pushnotif", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnStart()
        {
            base.OnStart();

            const int requestLocationId = 0;

            string[] notiPermission =
            {
                Manifest.Permission.PostNotifications
            };

            if ((int)Build.VERSION.SdkInt < 33) return;

            if (CheckSelfPermission(Manifest.Permission.PostNotifications) != Permission.Granted)
            {
                RequestPermissions(notiPermission, requestLocationId);
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            FirebasePushNotificationManager.ProcessIntent(this, Intent);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}