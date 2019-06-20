using MiChofer.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using MiChofer.Services;

namespace MiChofer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginFacebookPage : ContentPage
    {
        private string ClientId = "353677225149886";



        public LoginFacebookPage()
        {
            InitializeComponent();

            var apiRequest = "https://www.facebook.com/dialog/oauth?client_id="
                + ClientId
                + "&display=popup&response_type=token&redirect_uri=http://www.facebook.com/connect/login_success.html";

            var webView = new WebView
            {
                Source = apiRequest,
                HeightRequest = 1
            };

            webView.Navigated += WebViewOnNavigated;

            Content = webView;
        }

        private async void WebViewOnNavigated(object sender, WebNavigatedEventArgs e)
        {
            var accessToken = ExtractAccessTokenFromUrl(e.Url);
            //string accessTokenString = accessToken.ToString();

            if (accessToken != "")
            {
                //App.Current.MainPage = new MainPage();

                FacebookViewModel vm = BindingContext as FacebookViewModel;

                await vm.SetFacebookUserProfileAsync(accessToken);

                //Guardar facebook profile en sesion
                Session.Instance.LoginDriverFacebook(vm.FacebookProfile);

                App.Current.MainPage = new MainPage();

            }


        }
        private string ExtractAccessTokenFromUrl(string url)
        {
            var at = "";
            if (url.Contains("access_token") && url.Contains("&expires_in="))
            {
                at = url.Replace("https://www.facebook.com/connect/login_success.html#access_token=", "");

                var accessToken = at.Remove(at.IndexOf("&expires_in="));

                return accessToken;

            }

            
            return string.Empty;
        }

        //public async Task GetFacebookProfileAsync(String accessToken)
        //{
        //    var requestUrl = "https://graph.facebook.com/v2.7/me/" + "?fields=name,picture,cover,age_range,devices,email,gender,is_verified" + "&access_token="
        //    + accessToken;
        //    var httpClient = new HttpClient();
        //    var userJson = await httpClient.GetStringAsync(requestUrl);
        //}



    }
}