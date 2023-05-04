using Android.App;
using Android.Content.PM;
using IntentAlias = Android.Content.Intent;

namespace RD.Platforms.Android
{
    [Activity(NoHistory = true, LaunchMode = LaunchMode.SingleTop, Exported = true)]
    [IntentFilter(new[] { IntentAlias.ActionView },
              Categories = new[] { IntentAlias.CategoryDefault, IntentAlias.CategoryBrowsable },
              DataScheme = CALLBACK_SCHEME)]
    public class WebAuthenticationCallbackActivity : WebAuthenticatorCallbackActivity
    {
        const string CALLBACK_SCHEME = "myapp";

    }
}
