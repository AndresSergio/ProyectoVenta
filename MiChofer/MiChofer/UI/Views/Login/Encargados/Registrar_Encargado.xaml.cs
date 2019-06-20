using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiChofer.UI.Views.Login.Encargados
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registrar_Encargado : ContentPage
	{
		public Registrar_Encargado ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PapupPage());
        }
    }
}