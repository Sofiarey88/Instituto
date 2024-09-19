using Android.App;
using Android.Content.PM;

namespace InstitutoApp;

[Activity(NoHistory = true, LaunchMode = LaunchMode.SingleTop, Exported = true)]
[IntentFilter(new[] { Android.Content.Intent.ActionView },
              Categories = new[] { Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable },
              DataScheme = CALLBACK_SCHEME)]
public class WebAuthenticationCallbackActivity : Microsoft.Maui.Authentication.WebAuthenticatorCallbackActivity
{
    const string CALLBACK_SCHEME = "com.googleusercontent.apps.1034708410824-rhiueoaper80k5f74kclf0f9epagcf6m";

}