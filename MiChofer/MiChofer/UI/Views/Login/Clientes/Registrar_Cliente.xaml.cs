using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiChofer.UI.Views.Login.Clientes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registrar_Cliente : ContentPage
	{
		public Registrar_Cliente ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Lista_de_clientes());
        }
    }
}