using MiChofer.UI.ViewModels;
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
	public partial class Lista_de_clientes : ContentPage
	{
		public Lista_de_clientes ()
		{
			InitializeComponent ();
            ListaDeClientes itemClientes = new ListaDeClientes();
            this.BindingContext = itemClientes;
            listadeclientes.ItemsSource = itemClientes.itemClientes;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registrar_Cliente());
        }
    }
}