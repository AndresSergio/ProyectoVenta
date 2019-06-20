using Xamarin.Forms;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Android.App;
using MiChofer.Models;
using MiChofer;
using MiChofer.Droid;
using Newtonsoft.Json;
using Xamarin.Auth;
using Xamarin.Forms.Platform.Android;
using Android.Content;

[assembly: ExportRenderer(typeof(LoginFacebookPage),
                          typeof(LoginFacebookRenderer))]

namespace MiChofer.Droid
{
    public class LoginFacebookRenderer :PageRenderer
    {
        
        public LoginFacebookRenderer()
        {
            var activity = this.Context as Activity;

            var auth = new OAuth2Authenticator(
                clientId: "353677225149886",
                scope: "",
                authorizeUrl: new Uri(
                    "https://www.facebook.com/v2.8/dialog/oauth"),
                redirectUrl: new Uri(
                    "http://www.facebook.com/connect/login_success.html"));

            auth.Completed += async (sender, eventArgs) =>
            {
                if (eventArgs.IsAuthenticated)
                {
                    var accessToken =
                        eventArgs.Account.Properties["access_token"].ToString();
                    var profile = await GetFacebookProfileAsync(accessToken);
                    App.LoginFacebookSuccess(profile);
                }
                else
                {
                    App.LoginFacebookFail();
                }
            };

            activity.StartActivity(auth.GetUI(activity));
        }

        async Task<FacebookResponses> GetFacebookProfileAsync(string accessToken)
        {
            var requestUrl = "https://graph.facebook.com/v2.8/me/?fields=" +
                "name,picture.width(999),cover,age_range,devices,email," +
                "gender,is_verified,birthday,languages,work,website," +
                "religion,location,locale,link,first_name,last_name," +
                "hometown&access_token=" + accessToken;
            var httpClient = new HttpClient();
            var userJson = await httpClient.GetStringAsync(requestUrl);
            var facebookResponse = JsonConvert.DeserializeObject<FacebookResponses>(userJson);
            return facebookResponse;
        }
    }
}
