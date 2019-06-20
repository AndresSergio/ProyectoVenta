using MiChofer.Models;
using MiChofer.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiChofer
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : ContentPage
	{


        public Master()
        {
            this.BindingContext = App.masterVm;
            InitializeComponent();
        }

	}
}