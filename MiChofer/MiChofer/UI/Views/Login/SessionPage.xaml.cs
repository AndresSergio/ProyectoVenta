using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MiChofer.UI.Views.Login.Clientes;
using MiChofer.UI.Views.Login.Encargados;

namespace MiChofer.UI.Views.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SessionPage : ContentPage
	{
		public SessionPage ()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }


        //usar evento click en un enlace
        //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    //Navigation.PushAsync(new LoginPage());
        //    //Navigation.PushAsync(new OpinionChoferView());
        //    Navigation.PushAsync(new LoginPage());

        //}

        //private async void GradientButton_OnTouchesEnded(object sender, IEnumerable<NGraphics.Point> e)
        //{
        //    await Navigation.PushAsync(new LoginFacebookPage());
        //}

        //private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        //{

        //    Navigation.PushAsync(new OpinionChoferView());
        //}




        //pasar url de un enlace en un label...
        //public ICommand ClickCommand => new Command<string>((url) =>
        //{
        //    Device.OpenUri(new System.Uri(url));
        //});
    }
}