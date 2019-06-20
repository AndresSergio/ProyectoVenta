using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MiChofer.UI.Views;
using MiChofer.Models;
using MiChofer.UI.Views.Login;
using MiChofer.UI.ViewModels;
using System.Diagnostics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MiChofer
{
    public partial class App : Application
    {

        public static MasterPageViewModel masterVm;
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTk2MDVAMzEzNzJlMzEyZTMwZnRFb0c3RkxKUFQzNnhXOW9GemwxWXV0dFFDOHMvb04yOTJIOXJVSVdsWT0 =");
            //@31372e312e30fM6ATt0I9zeCgoxyVnkODoxhzc9vaOQiwI5WDYrGQr8 =

            InitializeComponent();

            //MainPage = new NavigationPage(new LoginPage());
            MainPage = new NavigationPage(new SessionPage());
            masterVm = new MasterPageViewModel();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Debug.WriteLine("OnStart");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Debug.WriteLine("OnSleeps");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Debug.WriteLine("OnResume");
        }



    }
}
